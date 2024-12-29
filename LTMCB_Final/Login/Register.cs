using LTMCB_Final.FunctionClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LTMCB_Final.Login
{
    public partial class Register : Form
    {
        ClientTcpConnection tcp = Program.tcpConnection;
        public Register()
        {
            InitializeComponent();
        }

    

        private void dtpBirthDay_ValueChanged(object sender, EventArgs e)
        {
            tbBirthDay.Text = dtpBirthDay.Value.ToShortDateString();
        }

        private bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^[0-9]{10,11}$");
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        string Encryption(string input) //Encrypting password
        {
            HashAlgorithm alg = SHA256.Create(); //use SHA256 Encryption
            byte[] inputBytes = Encoding.UTF8.GetBytes(input); //Turning input into byte array
            byte[] hashBytes = alg.ComputeHash(inputBytes); //Hash byte array
            string HashPassword = BitConverter.ToString(hashBytes); //Turn byte array into string
            return HashPassword;
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            if (tbUsername.Text == string.Empty)
            {
                MessageBox.Show("Tên người dùng không dược bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbEmail.Text == string.Empty)
            {
                return;
            }
            else if (tbBirthDay.Text == string.Empty)
            {
                return;
            }
            else if (tbPhone.Text == string.Empty)
            {
                return;
            }
            else if (tbPassword.Text == string.Empty)
            {
                return;
            }
            else if (tbConfirmPassword.Text == string.Empty)
            {
                return;
            }

            if (!IsValidEmail(tbEmail.Text))
            {
                return;
            }
            else if (!IsValidPhone(tbPhone.Text))
            {
                return;
            }
            else if (tbPassword.Text.Length < 8)
            {
                return;
            }
            else if (tbConfirmPassword.Text != tbPassword.Text)
            {
                return;
            }

            string accountId = Guid.NewGuid().ToString();
            string pass = Encryption(tbPassword.Text);
            string query = @"CINSERT INTO dbo.Account (AccountID,Name, Email, Phone, Password, BirthDay, RoleID) VALUES ('" + accountId + "', N'" + tbUsername.Text + "', N'" + tbEmail.Text + "', N'" + tbPhone.Text + "', '" + pass + "', " + tbBirthDay + ",DEFAULT);";

            int rs = Int32.Parse(tcp.SendAndRevceiveStr(query));
            if (rs > 0)
            {
                //thanh cong
            }
            else
            {
                //that bai
            }

        }
    }
}