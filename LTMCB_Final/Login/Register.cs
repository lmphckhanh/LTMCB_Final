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

            // Kiểm tra định dạng email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi");
                return;
            }

            // Thêm tài khoản mới vào database

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

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
