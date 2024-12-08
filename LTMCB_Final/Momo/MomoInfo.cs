using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTMCB_Final.Momo
{
    internal class MomoInfo
    {
        public string endpoint { get; set; } //Server
        public string partnerCode { get; set; } //Server
        public string accessKey { get; set; } //Server
        public string serectkey { get; set; } //Server
        public string redirectUrl { get; set; } //Server
        public string ipnUrl { get; set; } //Server
        public string requestType { get; set; } //Client
        //"captureWallet"
        public string amount { get; set; } //Client
        public string orderId { get; set; } //Client
        // Guid.NewGuid().ToString();
        public string requestId { get; set; } //Client
        //Guid.NewGuid().ToString();
        public string extraData { get; set; } //Client
        public string orderInfo { get; set; } //Client
        public string signature { get; set; } //Client Hash
        public string storeId { get; set; } // Server
        public string partnerName { get; set; }//Server

        public MomoInfo()
        {
            orderId = Guid.NewGuid().ToString();
            requestId = Guid.NewGuid().ToString();
            extraData = "";
            orderInfo = "<Username> thanh toán";
        }
    }
}
