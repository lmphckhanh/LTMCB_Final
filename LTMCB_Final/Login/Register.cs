using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

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
            string birthday = DOB.Text.Trim();
            string phone = sdt.Text.Trim();
            string password = pw.Text.Trim();
            string confirmPassword = cfpw.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(birthday) ||
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

            // Kiểm tra định dạng email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi");
                return;
            }

            AddAccountToDatabase(username, email, birthday, phone, password);
        }

        // Hàm kiểm tra email hợp lệ
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        // Thêm tài khoản vào database
        private void AddAccountToDatabase(string username, string email, string birthday, string phone, string password)
        {
            string connectionString = @" ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO  VALUES ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@DOB", birthday);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký tài khoản thành công!", "Thành công");
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký tài khoản thất bại. Vui lòng thử lại.", "Lỗi");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
