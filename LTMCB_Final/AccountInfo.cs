using Azure;
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
        public string AccountID = login.AccountID;
        public AccountInfo()
        {
            InitializeComponent();
            LoadInfo();
        }

      

        public AccountInfo(string id)
        {
            InitializeComponent();
           
            LoadInfo(); 
        }
        private void LoadInfo()
        {

            string id = login.AccountID;
            try
            {

                string query = @"GSELECT TOP 1 Name, Phone, Email FROM dbo.Account WHERE AccountID = '" + id + "';";
                string rs = tcp.SendAndRevceiveStr(query);
                if (string.IsNullOrEmpty(rs))
                {
                    MessageBox.Show("Không thể tải thông tin tài khoản. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                
                    JObject json = new JObject();
                try
                {
                    json = JObject.Parse(rs);
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
            Edit_Info edit_Info = new Edit_Info();
            edit_Info.Show();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
