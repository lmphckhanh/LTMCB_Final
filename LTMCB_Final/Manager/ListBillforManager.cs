using LTMCB_Final.FunctionClass;
using Microsoft.Identity.Client;
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

namespace LTMCB_Final.Manager
{
    public partial class ListBillforManager : Form
    {
        string BillStatus = "1";
        ClientTcpConnection tcp = Program.tcpConnection;
        public ListBillforManager()
        {
            InitializeComponent();

        }
        void LoadBillList()
        {
            string query = @"SELECT DISTINCT B.BillID, A.Name, M.Name, B.TotalPrice, B.Date, B.Time, B.Status from (((((dbo.Bill B JOIN dbo.TicketOnBill TB ON TB.BillID = B.BillID) JOIN dbo.Ticket T ON T.TicketID = TB.TicketID) JOIN dbo.ShowTimes ST ON ST.ShowTimeID = T.ShowTimeID) JOIN dbo.Movie M ON M.MovieID = ST.MovieID)JOIN dbo.Account A ON A.AccountID = B.AccountID) WHERE B.Status = 1 ORDER BY B.Date, B.Time DESC;";
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
                item.SubItems.Add(arr[2].ToString());
                item.SubItems.Add(arr[3].ToString() + "VND");
                item.SubItems.Add(arr[4].ToString().Split(' ')[0]);
                item.SubItems.Add(arr[5].ToString().Split('.')[0]);
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
    }
}

