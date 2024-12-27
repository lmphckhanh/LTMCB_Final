using LTMCB_Final.FunctionClass;
using Newtonsoft.Json.Linq;
using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Sử dụng Microsoft.Data.SqlClient thay vì System.Data.SqlClient
using System.Text;

namespace LTMCB_Final
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usn.Text.Trim();
            string email = mail.Text.Trim();
            string password = pw.Text.Trim();
            string confirmPassword = cfpw.Text.Trim();

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi");
                return;
            }

            try
            {
                // Kiểm tra xem tài khoản đã tồn tại chưa
                string checkQuery = "SELECT COUNT(1) FROM dbo.Account WHERE Name = @Name OR Email = @Email";
                SqlParameter[] checkParams =
                {
                    new SqlParameter("@Name", username),
                    new SqlParameter("@Email", email)
                };

                int exists = 0;// dbHelper.ExecuteScalar(checkQuery, checkParams);
                if (exists > 0)
                {
                    MessageBox.Show("Tên đăng nhập hoặc email đã tồn tại!", "Lỗi");
                    return;
                }

                // Mã hóa mật khẩu

                // Thêm tài khoản mới vào cơ sở dữ liệu
                string insertQuery = "INSERT INTO dbo.Account (Name, Email, Password) VALUES (@Name, @Email, @Password)";

                SqlParameter[] insertParams =
                {
                    new SqlParameter("@Name", username),
                    new SqlParameter("@Email", email),
                   // new SqlParameter("@Password", encryptedPassword)
                };

                int rowsAffected = 0;// dbHelper.ExecuteNonQuery(insertQuery, insertParams);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công!", "Lỗi");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi truy vấn cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Hàm kiểm tra email hợp lệ
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}