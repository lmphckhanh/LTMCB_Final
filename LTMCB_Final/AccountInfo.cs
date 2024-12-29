using LTMCB_Final.FunctionClass;
using LTMCB_Final.Momo;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
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
        ClientTcpConnection tcp = Program.tcpConnection;

        public AccountInfo()
        {
            InitializeComponent();

        }

        public AccountInfo(string name,string email, string phone)
        {
            lblName.Text = name;
            lblEmail.Text = email;
            lblPhoneNumber.Text = phone;

        }

        public AccountInfo(string id)
        {
            InitializeComponent();
            string query = @"GSELECT AccountID, Name, Email, Phone FROM dbo.Account;";

            string json = tcp.SendAndRevceiveStr(query);
            JObject job = new JObject();
            try
            {
                job = JObject.Parse(json);
                lblName.Text = job.GetValue("Name").ToString();
                lblEmail.Text = job.GetValue("Email").ToString();
                lblPhoneNumber.Text = job.GetValue("Phone").ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }


        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();// Ẩn form này
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit_Info edit_Info = new Edit_Info();
            edit_Info.Show();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
