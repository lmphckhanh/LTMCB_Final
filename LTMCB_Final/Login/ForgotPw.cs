using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTMCB_Final.Login;
using System.Data.SqlClient;

namespace LTMCB_Final
{
    public partial class ForgotPw : Form
    {
        private string verificationCode; // Lưu mã xác nhận
        private string connectionString = @" ";
        public ForgotPw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email!", "Lỗi");
                return;
            }

            // Kiểm tra email có tồn tại trong database hay không
            if (!IsEmailRegistered(email))
            {
                MessageBox.Show("Email này không tồn tại trong hệ thống!", "Lỗi");
                return;
            }

            // Tạo mã xác nhận
            Random random = new Random();
            verificationCode = random.Next(100000, 999999).ToString();

            // Gửi mã xác nhận qua email
            try
            {
                SendEmail(email, verificationCode);
                MessageBox.Show("Mã xác nhận đã được gửi đến email của bạn.", "Thông báo");

                // Mở Form nhập mã xác nhận và mật khẩu mới
                LTMCB_Final.Login.ResetPw resetForm = new LTMCB_Final.Login.ResetPw(email, verificationCode);
                resetForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}", "Lỗi");
            }
        }

        // Hàm kiểm tra email có tồn tại trong cơ sở dữ liệu
        private bool IsEmailRegistered(string email)
        {
            
        }
        private void SendEmail(string toEmail, string code)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("your-email@gmail.com");
            mail.To.Add(toEmail);
            mail.Subject = "Mã xác nhận khôi phục mật khẩu";
            mail.Body = $"Mã xác nhận của bạn là: {code}";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("your-email@gmail.com", "your-email-password"),
                EnableSsl = true
            };

            smtp.Send(mail);
        }
    }
}
