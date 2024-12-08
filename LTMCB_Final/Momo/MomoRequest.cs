using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace LTMCB_Final.Momo
{
    internal class MomoRequest
    {
        public static bool BinaryCheck(int[] a, int n, int value)
        {
            int l = 0, r = n - 1;
            do
            {
                int mid = (l + r) / 2;
                if (a[mid] == value) return true;
                else if (value < a[mid]) r = mid - 1;
                else l = mid + 1;
            } while (l <= r);
            return false;
        }
        public static string sendMomoRequest(string endpoint, string postJsonString)
        {

            try
            {
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(endpoint);

                var postData = postJsonString;

                var data = Encoding.UTF8.GetBytes(postData);

                httpWReq.ProtocolVersion = HttpVersion.Version11;
                httpWReq.Method = "POST";
                httpWReq.ContentType = "application/json";

                httpWReq.ContentLength = data.Length;
                httpWReq.ReadWriteTimeout = 30000;
                httpWReq.Timeout = 35000;
                Stream stream = httpWReq.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();

                string jsonresponse = "";

                using (var reader = new StreamReader(response.GetResponseStream()))
                {

                    string temp = null;
                    while ((temp = reader.ReadLine()) != null)
                    {
                        jsonresponse += temp;
                    }
                }
                return jsonresponse;
            }
            catch (WebException e)
            {
                return null;
            }
        }

        public static string sendCheckRequest(string endpoint, string postJsonString)
        {

            try
            {
                bool isFinalCode = false;
                int[] finalCodeArray = { 0, 98, 99, 1001, 1002, 1003, 1004, 1005, 1006, 1007,
                                 1017, 1026, 1080, 1081, 1088, 2019, 4001, 4002, 4100 };

                var data = Encoding.UTF8.GetBytes(postJsonString);
                string jsonresponse = "";

                while (!isFinalCode)
                {
                    HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(endpoint);

                    httpWReq.ProtocolVersion = HttpVersion.Version11;
                    httpWReq.Method = "POST";
                    httpWReq.ContentType = "application/json";

                    httpWReq.ContentLength = data.Length;
                    httpWReq.ReadWriteTimeout = 30000;
                    httpWReq.Timeout = 35000;
                    jsonresponse = "";
                    Stream stream = httpWReq.GetRequestStream();
                    stream.Write(data, 0, data.Length);
                    stream.Close();

                    HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();

                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        string temp = null;
                        while ((temp = reader.ReadLine()) != null)
                        {
                            jsonresponse += temp;
                        }
                    }
                    JObject jresponse = JObject.Parse(jsonresponse);
                    int resultCode = Int32.Parse(jresponse.GetValue("resultCode").ToString());
                    isFinalCode = BinaryCheck(finalCodeArray, finalCodeArray.Length, resultCode);

                    Thread.Sleep(1000);
                }
                return jsonresponse;
            }
            catch (WebException e)
            {
                return e.Message;
            }
        }
    }
}
