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

namespace LTMCB_Final.Login
{
    public partial class ResetPw : Form
    {
        private ClientTcpConnection tcp = Program.tcpConnection;
        private string userEmail;
        private string verificationCode;
        public ResetPw(string email, string code)
        {
            InitializeComponent();
            userEmail = email;
            verificationCode = code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputCode = textBox1.Text.Trim();
            string newPassword = textBox2.Text.Trim();
            string confirmPassword = textBox3.Text.Trim();

            if (inputCode != verificationCode)
            {
                MessageBox.Show("Mã xác nhận không chính xác!", "Lỗi");
                return;
            }

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

        private bool UpdatePassword(string email, string newPassword)
        {
            try
            {
                string query = $"UPDATE dbo.Account SET Password = '{newPassword}' WHERE Email = '{email}'";
                string response = tcp.SendAndRevceiveStr(query);
                JObject jsonResponse = JObject.Parse(response);
                string status = jsonResponse["status"].ToString();
                return status == "success";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật mật khẩu: {ex.Message}", "Lỗi");
                return false;
            }
        }
    }
}
