using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaServer.Momo
{
    internal class MomoInfo
    {
        string endpoint { get; set; } //Server
        string partnerCode { get; set; } //Server
        string accessKey { get; set; } //Server
        string serectkey { get; set; } //Server
        string redirectUrl { get; set; } //Server
        string ipnUrl { get; set; } //Server
        //string requestType { get; set; } //Client
        //"captureWallet"
        string storeId; // Server
        string partnerName; //Server

        public MomoInfo()
        {
            endpoint = "https://test-payment.momo.vn/v2/gateway/api/create";
            partnerCode = "MOMO5RGX20191128";
            accessKey = "M8brj9K6E22vXoDB";
            serectkey = "nqQiVSgDMy809JoPF6OzP5OdBUB550Y4";
            redirectUrl = "https://www.momo.vn/chuyen-nhan-tien";
            ipnUrl = "42.118.191.128:8080"; //Chỉnh sửa tùy ý (không sử dụng nhưng ko đc để trống)
            storeId = "MomoTestStore";
            partnerName = "Test";
        }
    }
}
