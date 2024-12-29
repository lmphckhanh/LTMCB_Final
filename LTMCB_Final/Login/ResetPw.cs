using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LTMCB_Final.FunctionClass;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;

namespace LTMCB_Final.Login
{
    public partial class ResetPw : Form
    {
        private ClientTcpConnection tcp = Program.tcpConnection;
        private string userEmail;
        private string AccountID = login.AccountID;
        public ResetPw()
        {
            InitializeComponent();
        }
        public ResetPw(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = textBox2.Text.Trim();
            string confirmPassword = textBox3.Text.Trim();


            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mật khẩu!", "Lỗi");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi");
                return;
            }

            // Cập nhật mật khẩu mới vào database
            if (string.IsNullOrEmpty(AccountID))
            {
                if (UpdatePassword(userEmail, newPassword))
                {
                    MessageBox.Show("Mật khẩu đã được cập nhật thành công!", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật mật khẩu thất bại. Vui lòng thử lại sau!", "Lỗi");
                }
            }
            else
            {
                if (UpdatePassword2(AccountID, newPassword))
                {
                    MessageBox.Show("Mật khẩu đã được cập nhật thành công!", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật mật khẩu thất bại. Vui lòng thử lại sau!", "Lỗi");
                }
            }

        }

        private bool UpdatePassword(string email, string newPassword)
        {
            string pass = Encryption(newPassword);
            try
            {
                string query = $"CUPDATE dbo.Account SET Password = '{pass}' WHERE Email = '{email}'";
                if (Int32.Parse(tcp.SendAndRevceiveStr(query)) > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private bool UpdatePassword2(string account, string newPassword)
        {
            string pass = Encryption(newPassword);
            try
            {
                string query = $"CUPDATE dbo.Account SET Password = '{pass}' WHERE AccountID = '{AccountID}'";
                if (Int32.Parse(tcp.SendAndRevceiveStr(query)) > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        string Encryption(string input) //Encrypting password
        {
            HashAlgorithm alg = SHA256.Create(); //use SHA256 Encryption
            byte[] inputBytes = Encoding.UTF8.GetBytes(input); //Turning input into byte array
            byte[] hashBytes = alg.ComputeHash(inputBytes); //Hash byte array
            string HashPassword = BitConverter.ToString(hashBytes); //Turn byte array into string
            return HashPassword;
        }
    }
}
