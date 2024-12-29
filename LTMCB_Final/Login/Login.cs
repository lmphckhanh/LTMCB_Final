using LTMCB_Final.FunctionClass;
using LTMCB_Final.Login;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTMCB_Final
{
    public partial class login : Form
    {
        ClientTcpConnection tcp = Program.tcpConnection;
        public static string AccountID = "";
        public static string RoleID = "";
        public login()
        {
            InitializeComponent();
            Loadinfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = phone.Text.Trim();
            string password = Encryption(pw.Text.Trim());

            if (string.IsNullOrEmpty(num) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi");
                return;
            }

            string query = @"GSELECT TOP 1 * FROM dbo.Account WHERE Phone = '" + num + "' AND Password = '" + password + "';";
            string rs = tcp.SendAndRevceiveStr(query);
            JObject json = new JObject();
            try
            {
                json = JObject.Parse(rs);
                AccountID = json.GetValue("AccountID").ToString();
                MessageBox.Show("Đăng Nhập Thành Công");
                this.Hide();
                ChonPhim chonPhim = new ChonPhim();
                chonPhim.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPw forgotPasswordForm = new ForgotPw();
            forgotPasswordForm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }
        string Encryption(string input) //Encrypting password
        {
            HashAlgorithm alg = SHA256.Create(); //use SHA256 Encryption
            byte[] inputBytes = Encoding.UTF8.GetBytes(input); //Turning input into byte array
            byte[] hashBytes = alg.ComputeHash(inputBytes); //Hash byte array
            string HashPassword = BitConverter.ToString(hashBytes); //Turn byte array into string
            return HashPassword;
        }
        private void Loadinfo()
        {

            string num = phone.Text.Trim();
            string password = Encryption(pw.Text.Trim());

            string query = @"GSELECT TOP 1 RoleID, AccountID FROM dbo.Account WHERE Phone = '" + num + "' AND Password = '" + password + "';";
            string rs = tcp.SendAndRevceiveStr(query);
            JObject json = new JObject();
            try
            {
                json = JObject.Parse(rs);
              

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tải thông tin người dùng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
