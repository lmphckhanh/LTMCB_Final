using LTMCB_Final.FunctionClass;
using LTMCB_Final.Momo;
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

namespace LTMCB_Final
{
    public partial class Bill : Form
    {
        ClientTcpConnection tcpConnection = Program.tcpConnection;

        public static Bill instance;
        public string BillID = "";
        public string AccountID = "";

        public Bill()
        {
            InitializeComponent();
            instance = this;
            LoadInfo();
        }

        void LoadInfo()
        {
            JObject json = new JObject();
            lbBillId.Text = BillID;

            tcpConnection.TcpSend(@"GSELECT TOP 1 Name, Phone FROM dbo.Account WHERE AccountID = '" + AccountID + "';");
            json = JObject.Parse(tcpConnection.TcpReceive());
            lbCustomer.Text = json.GetValue("Name").ToString();
            lbNumber.Text = json.GetValue("Phone").ToString();

            tcpConnection.TcpSend(@"GSELECT TOP 1 Mov.Name FROM ((dbo.TicketOnBill TB JOIN dbo.Ticket TK ON	TK.TicketID = TB.TicketID) JOIN dbo.ShowTimes ST ON ST.ShowTimeID = TK.ShowTimeID) JOIN dbo.Movie Mov ON ST.MovieID = Mov.MovieID WHERE TB.BillID = '" + BillID + "';");
            json = JObject.Parse(tcpConnection.TcpReceive());
            lbMovieName.Text = json.GetValue("Name").ToString();

            tcpConnection.TcpSend(@"GSELECT COUNT(TicketID) AS Count FROM dbo.TicketOnBill WHERE BillID = '" + BillID + "'; ");
            json = JObject.Parse(tcpConnection.TcpReceive());
            lbTicketAmount.Text = json.GetValue("Count").ToString();

            tcpConnection.TcpSend(@"QSELECT R.RoomName, SL.Col, SL.Row, C.Address  FROM (((((dbo.TicketOnBill TB JOIN dbo.Ticket TK ON TK.TicketID = TB.TicketID) JOIN dbo.Slot SL ON TK.SlotID = SL.SlotID) JOIN dbo.SlotInRoom SR ON SR.SlotID = SL.SlotID) JOIN dbo.Room R ON SR.RoomID = R.RoomID) JOIN dbo.RoomInCinema RC ON RC.RoomID = R.RoomID) JOIN dbo.Cinema C ON C.CinemaID = RC.CinemaID WHERE TB.BillID = '" + BillID + "';");
            string Q = tcpConnection.TcpReceive();
            string[] rs = Q.Split('\0');

            if (!rs.IsNullOrEmpty())
            {
                json = JObject.Parse(rs[0]);
                lbRoom.Text = json.GetValue("RoomName").ToString() + " (" + json.GetValue("Col").ToString() + json.GetValue("Row").ToString();
                lbAddress.Text = json.GetValue("Address").ToString();
            }
            for (int i = 1; i < rs.Length; i++)
            {
                json = JObject.Parse(rs[i]);
                lbRoom.Text += "," + json.GetValue("Col").ToString() + json.GetValue("Row").ToString();
            }
            lbRoom.Text += ")";

            tcpConnection.TcpSend(@"GSELECT TOP 1 Date, Time, TotalPrice FROM dbo.Bill WHERE BillID = '" + BillID + "';");
            json = JObject.Parse(tcpConnection.TcpReceive());

            lbTotal.Text = json.GetValue("TotalPrice").ToString();
            lbDateTime.Text = json.GetValue("Date").ToString() + " " + json.GetValue("Time").ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDropBill_Click(object sender, EventArgs e)
        {
            try
            {
                tcpConnection.TcpSend(@"EEXEC dbo.Proc_DeleleBill @BillID = '" + BillID +"';");
                //Refund
                MessageBox.Show("Hủy vé thành công!\nBạn sẽ được hoàn tiền trong thời gian sớm nhất!","Thành công",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                
                MessageBox.Show("Hủy vé thất bại!\n" + ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
