using CinemaServer.FunctionClass;
using System.Net.Sockets;
using System.Net;
using System.Text;
using CinemaServer.Momo;
using CinemaServer.FunctionClass;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.IdentityModel.Tokens;

namespace CinemaServer
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            TcpConnect();
        }
        static MomoInfo momoInfo = new MomoInfo();
        TcpListener listener;
        List<TcpClient> listClient = new List<TcpClient>();
        int dataSize = 1; //(byte)
        ManipulateDataBase DTB = new ManipulateDataBase();

        public void TcpConnect()
        {
            listener = new TcpListener(IPAddress.Any, 8080);
            listener.Start();

            Thread Listening = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        TcpClient client = listener.AcceptTcpClient();
                        //NetworkStream ns = client.GetStream();
                        listClient.Add(client);

                        Thread Receiving = new Thread(TcpReceive);
                        Receiving.IsBackground = true;
                        Receiving.Start(client);
                    }
                }
                catch (Exception ex)
                {
                    TcpListener listener = new TcpListener(IPAddress.Any, 8080);
                }
            });
            Listening.IsBackground = true;
            Listening.Start();

        }

        public void TcpSendAll(string mess) //Optional
        {
            foreach (var client in listClient)
            {
                NetworkStream ns = client.GetStream();
                try
                {
                    if (ns.CanWrite && mess != "")
                    {
                        ns.WriteAsync(Encoding.UTF8.GetBytes(mess));
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Server Send Error: " + ex.Message);
                    ns.Close();
                }

            }
        }

        public void TcpSend(TcpClient client, string mess)
        {
            NetworkStream ns;
            byte[] data = new byte[dataSize];
            if (mess != string.Empty)
            {
                ns = client.GetStream();
                data = Encoding.UTF8.GetBytes(mess);
                ns.WriteAsync(data);
            }
        }
        public void TcpSendBytes(TcpClient client, string url)
        {
            NetworkStream ns;
            byte[] img = File.ReadAllBytes(url);
            if (!img.IsNullOrEmpty())
            {
                ns = client.GetStream();
                ns.WriteAsync(img);
            }
        }


        public void TcpReceive(object obj)
        {
            TcpClient client = obj as TcpClient;
            NetworkStream ns = client.GetStream();
            byte[] data = new byte[dataSize];
            string mess = "";
            int receivedBytes = 0;
            List<byte> listBytes = new List<byte>();

            try
            {
                while (ns.CanRead)
                {
                    do
                    {
                        receivedBytes = ns.ReadAsync(data, 0, data.Length).Result;
                        foreach (var item in data) listBytes.Add(item);
                    } while (ns.DataAvailable);
                    mess += Encoding.UTF8.GetString(listBytes.ToArray());
                    ns.Flush();
                    listBytes.Clear();
                    if (mess != "")
                    {
                        string syntax = mess.Substring(0, 1);
                        mess = mess.Substring(1);
                        if (syntax + mess == "GETMOMO")
                        {
                            JObject json = new JObject
                            {
                                {"endpoint", momoInfo.endpoint },
                                {"partnerCode", momoInfo.partnerCode },
                                {"accessKey", momoInfo.accessKey},
                                {"serectkey", momoInfo.serectkey },
                                {"redirectUrl", momoInfo.redirectUrl },
                                {"ipnUrl", momoInfo.ipnUrl },
                                {"storeId", momoInfo.storeId },
                                {"partnerName", momoInfo.partnerName }
                            };
                            TcpSend(client, json.ToString());
                            mess = "";
                        }
                        else if (syntax == "Q") //Query -> list
                        {
                            string rs = DTB.ToQuery(mess);
                            mess = "";
                            TcpSend(client, rs);

                        }
                        else if (syntax == "E") //Execute ko
                        {
                            DTB.Execute(mess);
                            mess = "";

                        }
                        else if (syntax == "C")
                        {
                            string rs = DTB.Execute(mess).ToString();
                            mess = "";
                            TcpSend(client,rs);

                        }
                        else if (syntax == "G")
                        {
                            string rs = DTB.GetObject(mess);
                            mess = "";
                            TcpSend(client, rs);

                        }
                        else if (syntax == "P")
                        {
                            string msg = mess;
                            mess = "";
                            TcpSendBytes(client, msg);
                        }
                        else
                        {
                            mess = "";
                            TcpSend(client, "Syntax Error");


                        }
                        mess = "";
                    }
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Server Receive Error: " + ex.Message, "Error");
                ns.Close();
            }
        }
    }
}
