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
using System.Net.Sockets;
using LTMCB_Final.FunctionClass;
using Newtonsoft.Json.Linq;

namespace LTMCB_Final
{
    public partial class ForgotPw : Form
    {
        ClientTcpConnection tcp = Program.tcpConnection;
        private string verificationCode; // Lưu mã xác nhận
        private string connectionString = @" ";
        public ForgotPw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}", "Lỗi");
            }
        }

        // Hàm kiểm tra email có tồn tại trong cơ sở dữ liệu
        private bool IsEmailRegistered(string email)
        {
            string rs = tcp.SendAndRevceiveStr(@"GSELECT TOP 1 AccountID FROM dbo.Account WHERE Email = '" + tbEmail.Text + "';");
            return !string.IsNullOrEmpty(rs);
        }
        private void SendEmail(string toEmail, string code)
        {
            try
            {
                var from = new MailAddress("lekhoi323@gmail.com");
                var to = new MailAddress(toEmail);
                string pass = "llfj qmft ydtb tvrd";
                string subject = "Đặt lại mật khẩu";
                string body = "Mã xác nhận của bạn là: " + code;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(from.Address, pass),
                    Timeout = 200000
                };

                using (var mess = new MailMessage(from, to)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(mess);
                }

                //MessageBox.Show("Sent!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbCode.Text == verificationCode)
            {
                ResetPw rs = new ResetPw(tbEmail.Text);
                rs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã xác nhận không chính xác!", "Lỗi");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
