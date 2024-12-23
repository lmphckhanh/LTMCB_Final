using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LTMCB_Final.Login
{
    public partial class ResetPw : Form
    {
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
            
        }
    }
}
