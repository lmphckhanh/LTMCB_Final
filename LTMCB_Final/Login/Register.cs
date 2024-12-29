using LTMCB_Final.FunctionClass;
using Microsoft.Identity.Client;
using Newtonsoft.Json.Linq;
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
            tbBirthDay.Text = dtpBirthDay.Value.ToString("MM/dd/yyyy");
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

            string AccountId = Guid.NewGuid().ToString();
            string pass = Encryption(tbPassword.Text);
            string query = @"CINSERT INTO dbo.Account (AccountID,Name, Email, Phone, Password, BirthDay, RoleID) VALUES ('" + AccountId + "', N'" + tbUsername.Text + "', N'" + tbEmail.Text + "', N'" + tbPhone.Text + "', '" + pass + "', '" + tbBirthDay.Text + "',DEFAULT);";

            if (Int32.Parse(tcp.SendAndRevceiveStr(query)) > 0)
            {
                MessageBox.Show("Đăng Ký thành công!", "Thành công");
                login login = new login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng Ký thất bại!", "Thất bại");
            }




        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (tbPassword.UseSystemPasswordChar && tbConfirmPassword.UseSystemPasswordChar)
            {
                tbConfirmPassword.UseSystemPasswordChar = false;
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbConfirmPassword.UseSystemPasswordChar = true;
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}