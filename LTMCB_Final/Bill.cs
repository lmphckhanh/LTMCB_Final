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
        ClientTcpConnection tcp = Program.tcpConnection;

        public static Bill instance;
        string BillID = "";
        public string AccountID = "";

        public Bill()
        {
            InitializeComponent();
            instance = this;
            LoadInfo();
        }
        public Bill(string Bill)
        {
            InitializeComponent();
            instance = this;
            BillID = Bill;
            LoadInfo();
        }

        void LoadInfo()
        {
            JObject json = new JObject();
            lbBillId.Text = BillID;

            json = JObject.Parse(tcp.SendAndRevceiveStr(@"GSELECT TOP 1 Name, Phone FROM dbo.Account WHERE AccountID = '" + AccountID + "';"));
            lbCustomer.Text = json.GetValue("Name").ToString();
            lbNumber.Text = json.GetValue("Phone").ToString();

            json = JObject.Parse(tcp.SendAndRevceiveStr(@"GSELECT TOP 1 Mov.Name FROM ((dbo.TicketOnBill TB JOIN dbo.Ticket TK ON	TK.TicketID = TB.TicketID) JOIN dbo.ShowTimes ST ON ST.ShowTimeID = TK.ShowTimeID) JOIN dbo.Movie Mov ON ST.MovieID = Mov.MovieID WHERE TB.BillID = '" + BillID + "';"));
            lbMovieName.Text = json.GetValue("Name").ToString();

            json = JObject.Parse(tcp.SendAndRevceiveStr(@"GSELECT COUNT(TicketID) AS Count FROM dbo.TicketOnBill WHERE BillID = '" + BillID + "';"));
            lbTicketAmount.Text = json.GetValue("Count").ToString();

            string Q = tcp.SendAndRevceiveStr(@"QSELECT R.RoomName, SL.Col, SL.Row, C.Address  FROM (((((dbo.TicketOnBill TB JOIN dbo.Ticket TK ON TK.TicketID = TB.TicketID) JOIN dbo.Slot SL ON TK.SlotID = SL.SlotID) JOIN dbo.SlotInRoom SR ON SR.SlotID = SL.SlotID) JOIN dbo.Room R ON SR.RoomID = R.RoomID) JOIN dbo.RoomInCinema RC ON RC.RoomID = R.RoomID) JOIN dbo.Cinema C ON C.CinemaID = RC.CinemaID WHERE TB.BillID = '" + BillID + "';");
            string[] rs = Q.Split("<*>");

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

            json = JObject.Parse(tcp.SendAndRevceiveStr(@"GSELECT TOP 1 Date, Time, TotalPrice FROM dbo.Bill WHERE BillID = '" + BillID + "';"));

            lbTotal.Text = json.GetValue("TotalPrice").ToString();
            lbDateTime.Text = json.GetValue("Date").ToString() + " " + json.GetValue("Time").ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDropBill_Click(object sender, EventArgs e)
        {
            string query = @"GSELECT TransID, TotalPrice FROM dbo.Bill WHERE BillID = '" + BillID + "';";

            JObject job = JObject.Parse(tcp.SendAndRevceiveStr(query));
            string transId = job.GetValue("TransID").ToString();
            long price = Int64.Parse(job.GetValue("TotalPrice").ToString());

            JObject jmomo = JObject.Parse(tcp.SendAndRevceiveStr(@"GETMOMO"));
            string accessKey = jmomo.GetValue("accessKey").ToString();

            try
            {
                query = @"CEXEC dbo.Proc_DeleleBill @BillID = '" + BillID + "';";

                string numRows = tcp.SendAndRevceiveStr(query);

                if (Int32.Parse(numRows) > 0)
                {
                    string rs = MomoRequest.Refund(accessKey, transId, price);
                    JObject jrs = JObject.Parse(rs);
                    string rscode = jrs.GetValue("resultCode").ToString();
                    if (rscode == "0")
                    {
                        //Thành công
                        MessageBox.Show("Hủy vé thành công!\nBạn sẽ được hoàn tiền trong thời gian sớm nhất", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hủy vé thất bại!\n" + jrs.GetValue("message").ToString(), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Thất bại
                    }
                }
                else
                {
                    MessageBox.Show("Hủy vé thất bại!\nLỗi Database!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Thất bại
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void lbCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
