using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
                byte[] data = Encoding.ASCII.GetBytes(mess);
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

            try
            {
                while (ns.CanRead)
                {
                    if (!ns.DataAvailable) return mess;
                    do
                    {
                        ReceiveBytes = ns.ReadAsync(data, 0, data.Length).Result;
                        mess += Encoding.ASCII.GetString(data);
                    } while (ns.DataAvailable);

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
    }
}
