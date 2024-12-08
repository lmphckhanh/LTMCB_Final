using CinemaServer.FunctionClass;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace CinemaServer
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            TcpConnect();
        }
        TcpListener listener;
        List<TcpClient> listClient = new List<TcpClient>();
        int dataSize = 1; //(byte)
        ManipulateDataBase DTB = new ManipulateDataBase();

        string endpoint = "https://test-payment.momo.vn/v2/gateway/api/create";
        string partnerCode = "MOMO5RGX20191128";
        string accessKey = "M8brj9K6E22vXoDB";
        string serectkey = "nqQiVSgDMy809JoPF6OzP5OdBUB550Y4";
        string redirectUrl = "https://www.momo.vn/chuyen-nhan-tien";
        string ipnUrl = "42.118.191.128:8080"; //Chỉnh sửa tùy ý (không sử dụng nhưng ko đc để trống)
        string requestType = "captureWallet";

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

        public void Send(TcpClient client, string mess)
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
                        Send(client, mess);
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
