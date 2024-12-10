using CinemaServer.FunctionClass;
using System.Net.Sockets;
using System.Net;
using System.Text;
using CinemaServer.Momo;
using CinemaServer.FunctionClass;
using Newtonsoft.Json.Linq;

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
                        ns.WriteAsync(Encoding.ASCII.GetBytes(mess));
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
                data = Encoding.ASCII.GetBytes(mess);
                ns.WriteAsync(data);
            }
        }


        public void TcpReceive(object obj)
        {
            TcpClient client = obj as TcpClient;
            NetworkStream ns = client.GetStream();
            byte[] data = new byte[dataSize];
            string mess = "";
            int receivedBytes = 0;

            try
            {
                while (ns.CanRead)
                {
                    do
                    {
                        receivedBytes = ns.ReadAsync(data, 0, data.Length).Result;
                        mess += Encoding.ASCII.GetString(data);
                    } while (ns.DataAvailable);

                    if (mess != "")
                    {
                        string syntax = mess.Substring(0, 1);
                        if (mess == "GETMOMO")
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
                        }
                        else if (syntax == "Q")
                        {
                            TcpSend(client, DTB.ToQuery(mess));
                        }
                        else if (syntax == "E")
                        {
                            DTB.Command(mess);
                        }
                        else if (syntax == "G")
                        {
                            TcpSend(client, DTB.GetObject(mess));
                        }
                        else
                        {
                            TcpSend(client, "Error");
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
