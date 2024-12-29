using Azure;
using LTMCB_Final.FunctionClass;
using LTMCB_Final.Login;
using LTMCB_Final.Manager;
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
        public string AccountID = login.AccountID;
        public AccountInfo()
        {
            InitializeComponent();
            LoadInfo();
            if (login.RoleID == "QL")
            {
                btnListBill.Text = "Quản lý hóa đơn";
            }
        }



        public AccountInfo(string id)
        {
            InitializeComponent();

            LoadInfo();
        }
        private void LoadInfo()
        {

            try
            {

                string query = @"GSELECT TOP 1 Name, Phone, Email FROM dbo.Account WHERE AccountID = '" + AccountID + "';";
                JObject json = new JObject();
                try
                {
                    json = JObject.Parse(tcp.SendAndRevceiveStr(query));
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu từ server không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblName.Text = json.GetValue("Name").ToString();
                lblPhoneNumber.Text = json.GetValue("Phone").ToString();
                lblEmail.Text = json.GetValue("Email").ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();// Ẩn form này
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ResetPw reset = new ResetPw();
            reset.ShowDialog();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnListBill_Click(object sender, EventArgs e)
        {
            if(login.RoleID == "QL")
            {
                ListBillforManager list = new ListBillforManager();
                list.Show();
                this.Hide();
            }
            else
            {
                ListBill listBill = new ListBill();
                listBill.Show();
                this.Hide();
            }

        }
    }
}
