using LTMCB_Final.FunctionClass;
using LTMCB_Final.Momo;
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
namespace LTMCB_Final
{
    public partial class AccountInfo : Form
    {
        ClientTcpConnection tcpConnection = Program.tcpConnection;

        public AccountInfo()
        {
            InitializeComponent();
           // LoadInfo();
        }


       /* void LoadInfo()
        {
            JObject json = new JObject();
            string temp = string.Empty;

           // tcpConnection.TcpSend(@"GSELECT TOP 1 Name, Phone, Address, Email FROM dbo.Account WHERE AccountID = '" + AccountID + "';");
            while ((temp = tcpConnection.TcpReceive()).IsNullOrEmpty()) { };
            json = JObject.Parse(temp);

            lblName.Text = json.GetValue("Name").ToString();
            lblPhoneNumber.Text = json.GetValue("Phone").ToString();
            lblAddress.Text = json.GetValue("Address").ToString();
            lblEmail.Text = json.GetValue("Email").ToString();
        }
       */

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();// Ẩn form này
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit_Info edit_Info = new Edit_Info();
            edit_Info.Show();
        }
    }
}
