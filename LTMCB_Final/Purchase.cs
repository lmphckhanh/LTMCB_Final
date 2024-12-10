using LTMCB_Final.FunctionClass;
using LTMCB_Final.Momo;
using Microsoft.Identity.Client;
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
        ClientTcpConnection tcpConnection = Program.tcpConnection;
        
        MomoInfo momo = new MomoInfo();
        public Purchase()
        {
            InitializeComponent();
        }
        //Khách hàng: Account "Select Name From dbo.Account Where AcccountID = " + AccountId
        //Tổng tiền : TicketOnBill 
        //Số lượng: TicketOnBill
        //Phim: TicketOnBill -> Ticket -> Movie
        private void btnPurchase_Click(object sender, EventArgs e)
        {

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
                //Thành công
            }
            else
            {
                //Thất bại
                string failMessage = jquerymessage.GetValue("message").ToString();
            }
        }
    }
}
