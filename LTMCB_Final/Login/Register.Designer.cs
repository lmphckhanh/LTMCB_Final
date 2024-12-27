namespace LTMCB_Final.Login
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            btnRegister = new Button();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            tbEmail = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tbPhone = new TextBox();
            dtpBirthDay = new DateTimePicker();
            tbBirthDay = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 41);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(60, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 33);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(60, 445);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 33);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(60, 534);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(228, 33);
            label4.TabIndex = 3;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Times New Roman", 13.8F);
            tbUsername.Location = new Point(328, 100);
            tbUsername.Margin = new Padding(4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(383, 39);
            tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Times New Roman", 13.8F);
            tbPassword.Location = new Point(328, 435);
            tbPassword.Margin = new Padding(4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(383, 39);
            tbPassword.TabIndex = 5;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Font = new Font("Times New Roman", 13.8F);
            tbConfirmPassword.Location = new Point(328, 524);
            tbConfirmPassword.Margin = new Padding(4);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(383, 39);
            tbConfirmPassword.TabIndex = 6;
            tbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Times New Roman", 13.8F);
            btnRegister.Location = new Point(304, 610);
            btnRegister.Margin = new Padding(4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(196, 58);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(341, 690);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(116, 27);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(60, 189);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 33);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Times New Roman", 13.8F);
            tbEmail.Location = new Point(199, 179);
            tbEmail.Margin = new Padding(4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(512, 39);
            tbEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F);
            label6.Location = new Point(60, 272);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(127, 33);
            label6.TabIndex = 11;
            label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F);
            label7.Location = new Point(60, 359);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(163, 33);
            label7.TabIndex = 12;
            label7.Text = "Số điện thoại";
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Times New Roman", 13.8F);
            tbPhone.Location = new Point(328, 349);
            tbPhone.Margin = new Padding(4);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(383, 39);
            tbPhone.TabIndex = 14;
            // 
            // dtpBirthDay
            // 
            dtpBirthDay.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthDay.Location = new Point(680, 266);
            dtpBirthDay.Margin = new Padding(4);
            dtpBirthDay.Name = "dtpBirthDay";
            dtpBirthDay.Size = new Size(31, 39);
            dtpBirthDay.TabIndex = 15;
            // 
            // tbBirthDay
            // 
            tbBirthDay.Font = new Font("Times New Roman", 13.8F);
            tbBirthDay.Location = new Point(289, 266);
            tbBirthDay.Margin = new Padding(4);
            tbBirthDay.Name = "tbBirthDay";
            tbBirthDay.Size = new Size(383, 39);
            tbBirthDay.TabIndex = 16;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 734);
            Controls.Add(tbBirthDay);
            Controls.Add(dtpBirthDay);
            Controls.Add(tbPhone);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(tbEmail);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(btnRegister);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbConfirmPassword;
        private Button btnRegister;
        private LinkLabel linkLabel1;
        private Label label5;
        private TextBox tbEmail;
        private Label label6;
        private Label label7;
        private TextBox tbPhone;
        private DateTimePicker dtpBirthDay;
        private TextBox tbBirthDay;
    }
}