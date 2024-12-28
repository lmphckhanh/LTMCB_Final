using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace LTMCB_Final.FunctionClass
{
    internal class ClientTcpConnection
    {
        public ClientTcpConnection() { }

        NetworkStream ns;
        TcpClient tcpClient = new TcpClient();
        IPAddress IP;
        IPEndPoint EPServer;
        string Ipv4Server = "127.0.0.1";
        int port = 8080;
        int dataSize = 1;

        public void TcpConnect()
        {
            IP = IPAddress.Parse(Ipv4Server);
            EPServer = new IPEndPoint(IP, port);
            try
            {
                tcpClient.Connect(EPServer);
                ns = tcpClient.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client Connect Error: " + ex.Message, "Error");
            }

        }

        public void TcpSend(string mess)
        {
            try
            {
                //NetworkStream ns = tcpClient.GetStream();
                byte[] data = Encoding.UTF8.GetBytes(mess);
                ns.WriteAsync(data, 0, data.Length);
                //ns.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client Send Error: " + ex.Message, "Error");
                ns.Close();
            }

        }

        public string TcpReceive()
        {
            //ns = tcpClient.GetStream();
            string mess = "";
            byte[] data = new byte[dataSize];
            int ReceiveBytes = 0;
            List<byte> listBytes = new List<byte>();

            try
            {
                while (ns.CanRead)
                {
                    if (!ns.DataAvailable) return mess;
                    do
                    {
                        ReceiveBytes = ns.ReadAsync(data, 0, data.Length).Result;
                        foreach (var item in data) listBytes.Add(item);
                        
                    } while (ns.DataAvailable);
                    mess += Encoding.UTF8.GetString(listBytes.ToArray());
                    if (mess != "")
                    {
                        return mess;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client Receiving Error: " + ex.Message, "Error");
                ns.Close();
            }
            return string.Empty;
        }
        public byte[] TcpReceiveBytes()
        {
            //ns = tcpClient.GetStream();
            byte[] data = new byte[dataSize];
            int ReceiveBytes = 0;
            List<byte> listBytes = new List<byte>();

            try
            {
                while (ns.CanRead)
                {
                    if (!ns.DataAvailable) return listBytes.ToArray();
                    do
                    {
                        ReceiveBytes = ns.ReadAsync(data, 0, data.Length).Result;
                        foreach (var item in data) listBytes.Add(item);
                        //mess += Encoding.UTF8.GetString(data);
                    } while (ns.DataAvailable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client Receiving Error: " + ex.Message, "Error");
                ns.Close();
            }
            return listBytes.ToArray();
        }

        public string SendAndRevceiveStr(string query)
        {
            string js = "";
            TcpSend(query);
            while (string.IsNullOrEmpty(js)) 
            {
                js = TcpReceive();
            }
            if (js == "NoData") js = "";
            return js;
        }

        public byte[] SendAndRevceiveBytes(string query)
        {
            byte[] bytes = null;
            TcpSend(query);
            while (bytes.IsNullOrEmpty())
            {
                bytes = TcpReceiveBytes();
            }
            return bytes;
        }
    }
}
