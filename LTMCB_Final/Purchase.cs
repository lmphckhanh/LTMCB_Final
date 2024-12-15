using LTMCB_Final.FunctionClass;
using LTMCB_Final.Momo;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTMCB_Final
{
    public partial class Purchase : Form
    {
        public static Purchase instance;
        ClientTcpConnection tcpConnection = Program.tcpConnection;
        public MomoInfo momo = new MomoInfo();
        string[] Ticket; //List Tickets from previous step
        string AccountID = ""; //Current Logged in account

        public Purchase()
        {
            InitializeComponent();
            LoadInfo();
        }
        //Khách hàng: Account "Select Name From dbo.Account Where AcccountID = " + AccountId
        //Tổng tiền : TicketOnBill 
        //Số lượng: TicketOnBill
        //Phim: TicketOnBill -> Ticket -> Movie
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            tcpConnection.TcpSend("GETMONO");
            string strMomo = null;
            while ((strMomo = tcpConnection.TcpReceive()).IsNullOrEmpty()) { }

            JObject jMomo = JObject.Parse(strMomo);

            momo.endpoint = jMomo.GetValue("endpoint").ToString();
            momo.partnerCode = jMomo.GetValue("partnerCode").ToString();
            momo.accessKey = jMomo.GetValue("accessKey").ToString();
            momo.serectkey = jMomo.GetValue("serectkey").ToString();
            momo.redirectUrl = jMomo.GetValue("redirectUrl").ToString();
            momo.ipnUrl = jMomo.GetValue("ipnUrl").ToString();
            momo.storeId = jMomo.GetValue("storeId").ToString();
            momo.partnerName = jMomo.GetValue("partnerName").ToString();
            momo.amount = lbTotal.Text;
            momo.orderInfo = lbCustomer.Text + "thanh toán";

            Payment();
        }
        private void Payment() //Payment Web
        {
            string endpoint = momo.endpoint; 
            string partnerCode = momo.partnerCode;
            string accessKey = momo.accessKey;
            string serectkey = momo.serectkey;
            string orderInfo = momo.orderInfo;
            string redirectUrl = momo.redirectUrl;
            string ipnUrl = momo.ipnUrl;
            string requestType = "captureWallet";
            string amount = momo.amount;
            string orderId = momo.orderId;
            string requestId = momo.requestId;
            string extraData = momo.extraData;

            //Before sign HMAC SHA256 signature
            string rawHash = "accessKey=" + accessKey +
                "&amount=" + amount +
                "&extraData=" + extraData +
                "&ipnUrl=" + ipnUrl +
                "&orderId=" + orderId +
                "&orderInfo=" + orderInfo +
                "&partnerCode=" + partnerCode +
                "&redirectUrl=" + redirectUrl +
                "&requestId=" + requestId +
                "&requestType=" + requestType
                ;

            MomoSecurity crypto = new MomoSecurity();

            string signature = crypto.signSHA256(rawHash, serectkey);

            //build body json request
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "partnerName", "Test" },
                { "storeId", "MomoTestStore" },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderId },
                { "orderInfo", orderInfo },
                { "redirectUrl", redirectUrl },
                { "ipnUrl", ipnUrl },
                { "lang", "en" },
                { "extraData", extraData },
                { "requestType", requestType },
                { "signature", signature }

            };

            string responseFromMomo = MomoRequest.sendMomoRequest(endpoint, message.ToString());

            JObject jmessage = JObject.Parse(responseFromMomo);

            System.Diagnostics.Process.Start(jmessage.GetValue("payUrl").ToString());

            /*----------------------------------------------------------------------*/
            //Lấy kết quả cuối cùng của đợt thanh toán

            string queryendpoint = "https://test-payment.momo.vn/v2/gateway/api/query";

            string queryRawHash = "accessKey=" + accessKey +
                "&orderId=" + orderId +
                "&partnerCode=" + partnerCode +
                "&requestId=" + requestId
                ;

            //sign signature SHA256
            string querysignature = crypto.signSHA256(queryRawHash, serectkey);

            JObject querymessage = new JObject
            {
                { "partnerCode", partnerCode },
                { "requestId", requestId },
                { "orderId", orderId },
                { "signature", querysignature },
                { "lang", "en" }

            };
            string queryresponseFromMomo = MomoRequest.sendMomoRequest(queryendpoint, querymessage.ToString());
            JObject jquerymessage = JObject.Parse(queryresponseFromMomo);

            if (Int32.Parse(jquerymessage.GetValue("resultCode").ToString()) == 0)
            {
                try
                {
                    MessageBox.Show("Thanh toán thành công, vé của bạn đã được đặt!\nChân thành cảm ơn quý kách",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = 0; i < Ticket.Length; i++)
                    {
                        string addRecord = "E"
                            + @"EXEC dbo.Pro_Purchase @Bill = '" + orderId + "',@RequestID = '" + requestId + "', @Ticket = '" + Ticket[i] + "', @Account = '" + AccountID + "';";
                        tcpConnection.TcpSend(addRecord);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi, bạn sẽ được hoàn tiền trong thời gian sớm nhất!\n Chân thành xin lỗi vì sự cố này!"
                        + "\nLỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Refund
                }
            }
            else
            {
                //Thất bại
                string failMessage = jquerymessage.GetValue("message").ToString();
                MessageBox.Show("Đã xảy ra lỗi trong quá trình thanh toán!\nQuý khách vui lòng thử lại.\nLỗi: "
                    + failMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadInfo()
        {
            JObject json = new JObject();
            tcpConnection.TcpSend(@"GSELECT TOP 1 Name FROM dbo.Account WHERE AccountID = '" + AccountID + "';");
            json = JObject.Parse(tcpConnection.TcpReceive());
            lbCustomer.Text = json.GetValue("Name").ToString();

            if (!Ticket.IsNullOrEmpty())
            {
                string temp = string.Empty;
                tcpConnection.TcpSend(@"GSELECT TOP 1 Mov.Name FROM (dbo.Ticket TK JOIN dbo.ShowTimes ST ON ST.ShowTimeID = TK.ShowTimeID) JOIN dbo.Movie Mov ON ST.MovieID = Mov.MovieID WHERE TK.TicketID = '" + Ticket[0] + "';");
                while ((temp = tcpConnection.TcpReceive()).IsNullOrEmpty()) { }
                json = JObject.Parse(temp);
                lbMovieName.Text = json.GetValue("Name").ToString();

                lbTicketAmount.Text = Ticket.Length.ToString();
                lbPaymentMethod.Text = "Momo";

                string list = "(";
                foreach (var i in Ticket) list += "'" + i + "',";
                list += "\b)";
                if (!Ticket.IsNullOrEmpty())
                    tcpConnection.TcpSend(@"GSELECT SUM(SLT.Price) AS Price FROM ((dbo.Ticket TK JOIN dbo.ShowTimes ST ON ST.ShowTimeID = TK.ShowTimeID) JOIN dbo.Slot Sl ON Sl.SlotID = TK.SlotID) JOIN dbo.SlotType SlT ON SlT.SlotTypeID = Sl.SlotTypeID
                    WHERE TK.TicketID IN " + list + ";");
                while ((temp = tcpConnection.TcpReceive()).IsNullOrEmpty()) { }
                json = JObject.Parse(temp);
                lbTotal.Text = json.GetValue("Price").ToString();
            }
        }
    }
}
