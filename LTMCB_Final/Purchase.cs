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
using System.Diagnostics;

namespace LTMCB_Final
{
    public partial class Purchase : Form
    {
        public static Purchase instance;
        ClientTcpConnection tcp = Program.tcpConnection;
        public MomoInfo momo = new MomoInfo();
        string[] Ticket; //List Tickets from previous step
        string AccountID = login.AccountID; //Current Logged in account

        public Purchase(List<string> listTicket)
        {
            Ticket = listTicket.ToArray();
            InitializeComponent();
            LoadInfo();
            
        }
        //Khách hàng: Account "Select Name From dbo.Account Where AcccountID = " + AccountId
        //Tổng tiền : TicketOnBill 
        //Số lượng: TicketOnBill
        //Phim: TicketOnBill -> Ticket -> Movie
        private void btnPurchase_Click(object sender, EventArgs e)
        {

            JObject jMomo = JObject.Parse(tcp.SendAndRevceiveStr(@"GETMOMO"));

            momo.endpoint = jMomo.GetValue("endpoint").ToString();
            momo.partnerCode = jMomo.GetValue("partnerCode").ToString();
            momo.accessKey = jMomo.GetValue("accessKey").ToString();
            momo.serectkey = jMomo.GetValue("serectkey").ToString();
            momo.redirectUrl = jMomo.GetValue("redirectUrl").ToString();
            momo.ipnUrl = jMomo.GetValue("ipnUrl").ToString();
            momo.storeId = jMomo.GetValue("storeId").ToString();
            momo.partnerName = jMomo.GetValue("partnerName").ToString();
            momo.amount = lbTotal.Text;
            momo.orderInfo = lbCustomer.Text + " thanh toán";

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
            string amount = momo.amount.Split(' ')[0];
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

            //Process.Start(@"http://stackoverflow.com");
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = jmessage.GetValue("payUrl").ToString();
            proc.Start();

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
            string queryresponseFromMomo = MomoRequest.sendCheckRequest(queryendpoint, querymessage.ToString());
            JObject jquerymessage = JObject.Parse(queryresponseFromMomo);

            if (Int32.Parse(jquerymessage.GetValue("resultCode").ToString()) == 0)
            {
                string transId = jquerymessage.GetValue("transId").ToString();
                try
                {

                    for (int i = 0; i < Ticket.Length; i++)
                    {
                        string addRecord = "C"
                            + @"EXEC dbo.Pro_Purchase @Bill = '" + orderId + "',@RequestID = '" + requestId + "',@TransID = '" + transId + "', @Ticket = '" + Ticket[i] + "', @Account = '" + AccountID + "';";
                        if (Int32.Parse(tcp.SendAndRevceiveStr(addRecord)) == 0)
                        {
                            MessageBox.Show("Đã xảy ra lỗi, bạn sẽ được hoàn tiền trong thời gian sớm nhất!\n Chân thành xin lỗi vì sự cố này!"
                                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            MomoRequest.Refund(accessKey, transId, Int64.Parse(amount));
                            return;
                        }
                    }

                    MessageBox.Show("Đặt vé thành công!\nChân thành cảm ơn quý khách.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

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

            json = JObject.Parse(tcp.SendAndRevceiveStr(@"GSELECT TOP 1 Name FROM dbo.Account WHERE AccountID = '" + AccountID + "';"));
            lbCustomer.Text = json.GetValue("Name").ToString();

            if (!Ticket.IsNullOrEmpty())
            {
                json = JObject.Parse(tcp.SendAndRevceiveStr(@"GSELECT TOP 1 Mov.Name FROM (dbo.Ticket TK JOIN dbo.ShowTimes ST ON ST.ShowTimeID = TK.ShowTimeID) JOIN dbo.Movie Mov ON ST.MovieID = Mov.MovieID WHERE TK.TicketID = '" + Ticket[0] + "';"));
                lbMovieName.Text = json.GetValue("Name").ToString();

                lbTicketAmount.Text = Ticket.Length.ToString();
                lbPaymentMethod.Text = "Momo";

                string list = "(";
                foreach (var i in Ticket) list += "'" + i + "',";
                list = list.Substring(0, list.Length - 1);
                list += ")";

                json = JObject.Parse(tcp.SendAndRevceiveStr(@"GSELECT SUM(SLT.Price) AS Price FROM ((dbo.Ticket TK JOIN dbo.ShowTimes ST ON ST.ShowTimeID = TK.ShowTimeID) JOIN dbo.Slot Sl ON Sl.SlotID = TK.SlotID) JOIN dbo.SlotType SlT ON SlT.SlotTypeID = Sl.SlotTypeID WHERE TK.TicketID IN " + list + ";"));
                lbTotal.Text = json.GetValue("Price").ToString() + " VND";
            }
        }
    }
}
