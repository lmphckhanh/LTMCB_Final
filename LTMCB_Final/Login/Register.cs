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
            string name = fullname.Text.Trim();
            string phone = sdt.Text.Trim();
            string password = pw.Text.Trim();
            string confirmPassword = cfpw.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(email))
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

            AddAccountToDatabase(username, email, name, phone, password);
        }

                int exists = 0;// dbHelper.ExecuteScalar(checkQuery, checkParams);
                if (exists > 0)
                {
                    MessageBox.Show("Tên đăng nhập hoặc email đã tồn tại!", "Lỗi");
                    return;
                }

        // Thêm tài khoản vào database
        private void AddAccountToDatabase(string username, string email, string name, string phone, string password)
        {
            string connectionString = @" ";

                // Thêm tài khoản mới vào cơ sở dữ liệu
                string insertQuery = "INSERT INTO dbo.Account (Name, Email, Password) VALUES (@Name, @Email, @Password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@FullName", name);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = command.ExecuteNonQuery();

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