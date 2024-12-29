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
using System.Security.Cryptography;
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
        string AccountID = login.AccountID;
        string BillStatus = "(0,1)";
        ClientTcpConnection tcp = Program.tcpConnection;
        public ListBill()
        {
            InitializeComponent();
            cbBillStatus.SelectedIndex = 2;
            instance = this;
            LoadBillList();
        }

        void LoadBillList()
        {
            string query = "";
            string js = "";

            switch (cbBillStatus.SelectedIndex)
            {
                case 0:
                    BillStatus = "(1)";
                    break;
                case 1:
                    BillStatus = "(0)";
                    break;
                case 2:
                    BillStatus = "(0,1)";
                    break;
                default:
                    BillStatus = "(0,1)";
                    break;
            }

            if (tbDateFrom.Text.IsNullOrEmpty() && tbDateTo.Text.IsNullOrEmpty())
            {
                query = @"QSELECT DISTINCT B.BillID, M.Name, B.TotalPrice, B.Date, B.Time, B.Status from ((((dbo.Bill B JOIN dbo.TicketOnBill TB ON TB.BillID = B.BillID) JOIN dbo.Ticket T ON T.TicketID = TB.TicketID) JOIN dbo.ShowTimes ST ON ST.ShowTimeID = T.ShowTimeID) JOIN dbo.Movie M ON M.MovieID = ST.MovieID) WHERE B.Status IN " + BillStatus + " AND B.AccountID = '" + AccountID + "' ORDER BY B.Date, B.Time DESC";
            }
            else
            {
                query = @"QSELECT DISTINCT B.BillID, M.Name, B.TotalPrice, B.Date, B.Time, B.Status from ((((dbo.Bill B JOIN dbo.TicketOnBill TB ON TB.BillID = B.BillID) JOIN dbo.Ticket T ON T.TicketID = TB.TicketID) JOIN dbo.ShowTimes ST ON ST.ShowTimeID = T.ShowTimeID) JOIN dbo.Movie M ON M.MovieID = ST.MovieID) WHERE B.Status IN " + BillStatus + " AND B.AccountID = '" + AccountID + "' AND (Date BETWEEN '" + tbDateFrom.Text + "' AND '" + tbDateTo.Text + "') ORDER BY B.Date, B.Time DESC";
            }

            string[] jArr = tcp.SendAndRevceiveStr(query).Split("<*>");
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

        private void btnClearDate_Click(object sender, EventArgs e)
        {
            tbDateFrom.Text = tbDateTo.Text = string.Empty;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lsvList.Items.Clear();
            LoadBillList();
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems[0].SubItems[6].Text == "Không còn hiệu lực")
            {
                MessageBox.Show("Hóa đơn không còn hiệu lực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string billId = lsvList.SelectedItems[0].SubItems[1].Text;
            string query = @"GSELECT TransID, TotalPrice FROM dbo.Bill WHERE BillID = '" + billId + "';";

            JObject job = JObject.Parse(tcp.SendAndRevceiveStr(query));
            string transId = job.GetValue("TransID").ToString();
            long price = Int64.Parse(job.GetValue("TotalPrice").ToString());

            JObject jmomo = JObject.Parse(tcp.SendAndRevceiveStr(@"GETMOMO"));
            string accessKey = jmomo.GetValue("accessKey").ToString();

            try
            {
                query = @"CEXEC dbo.Proc_DeleleBill @BillID = '" + billId + "';";
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
                        lsvList.Items.Clear();
                        LoadBillList();
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

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
