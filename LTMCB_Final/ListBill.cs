using LTMCB_Final.FunctionClass;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LTMCB_Final
{

    public partial class ListBill : Form
    {
        public static ListBill instance;
        public string selectedBill;
        string AccountID = "";
        string BillStatus = "(1)";
        ClientTcpConnection tcp = Program.tcpConnection;
        public ListBill()
        {
            InitializeComponent();
            cbBillStatus.SelectedIndex = 2;
            instance = this;
            LoadCollumns();
            LoadBillList();
        }
        void LoadCollumns()
        {
            lsvList.Columns.Add("TT");
            lsvList.Columns.Add("ID");
            lsvList.Columns.Add("Movie");
            lsvList.Columns.Add("Price");
            lsvList.Columns.Add("Date");
            lsvList.Columns.Add("Time");
            lsvList.Columns.Add("Status");
        }

        void LoadBillList()
        {   
            switch (cbBillStatus.SelectedIndex)
            {
                case 0: BillStatus = "(1)";
                    break;
                case 1: BillStatus = "(0)";
                    break;
                case 2: BillStatus = "(0,1)";
                    break;
                default: BillStatus = "(0,1)";
                    break;
            }
            string query = "";
            if (tbDateFrom.Text.IsNullOrEmpty() && tbDateTo.Text.IsNullOrEmpty())
            {
                query = @"SELECT DISTINCT B.BillID, M.Name, B.TotalPrice, B.Date, B.Time, B.Status from ((((dbo.Bill B JOIN dbo.TicketOnBill TB ON TB.BillID = B.BillID) JOIN dbo.Ticket T ON T.TicketID = TB.TicketID) JOIN dbo.ShowTimes ST ON ST.ShowTimeID = T.ShowTimeID) JOIN dbo.Movie M ON M.MovieID = ST.MovieID) WHERE B.Status IN " + BillStatus + " AND B.AccountID = '" + AccountID + "' ORDER BY B.Date, B.Time DESC";
            }
            else
            {
                query = @"SELECT DISTINCT B.BillID, M.Name, B.TotalPrice, B.Date, B.Time, B.Status from ((((dbo.Bill B JOIN dbo.TicketOnBill TB ON TB.BillID = B.BillID) JOIN dbo.Ticket T ON T.TicketID = TB.TicketID) JOIN dbo.ShowTimes ST ON ST.ShowTimeID = T.ShowTimeID) JOIN dbo.Movie M ON M.MovieID = ST.MovieID) WHERE B.Status IN " + BillStatus + " AND B.AccountID = '" + AccountID + "' AND (Date BETWEEN '" + tbDateFrom + "' AND '" + tbDateTo + "') ORDER BY B.Date, B.Time DESC";
            }

            string js = "";

            tcp.TcpSend(query);

            while ((js = tcp.TcpReceive()).IsNullOrEmpty()) { }
            string[] jArr = js.Split("<*>");
            JObject[] jlist = new JObject[jArr.Length - 1];
            for (int i = 0; i < jArr.Length - 1; i++)
            {
                jlist[i] = JObject.Parse(jArr[i]);
            }

            int index = 1;
            foreach (var i in jlist)
            {
                ListViewItem item = new ListViewItem(index.ToString());
                //var list = i.PropertyValues();
                object[] arr = i.PropertyValues().ToArray();

                item.SubItems.Add(arr[0].ToString());
                item.SubItems.Add(arr[1].ToString());
                item.SubItems.Add(arr[2].ToString() + "VND");
                item.SubItems.Add(arr[3].ToString().Split(' ')[0]);
                item.SubItems.Add(arr[4].ToString().Split('.')[0]);
                if (arr[5].ToString() == "True") item.SubItems.Add("Còn hiệu lực");
                else item.SubItems.Add("Không còn hiệu lực");

                lsvList.Items.Add(item);
                index++;
            }
        }

        private void lsvList_ItemActivate(object sender, EventArgs e)
        {
            string billId = lsvList.SelectedItems[0].SubItems[1].Text;
            Bill bill = new Bill(billId);
            bill.ShowDialog();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            tbDateFrom.Text = dtpFrom.Value.ToShortDateString();
            if (tbDateTo.Text.IsNullOrEmpty()) dtpTo.Value = dtpFrom.Value;
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            tbDateTo.Text = dtpTo.Value.ToShortDateString();
            if (tbDateFrom.Text.IsNullOrEmpty()) dtpFrom.Value = dtpTo.Value;
        }
    }
}
