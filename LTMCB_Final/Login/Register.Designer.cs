namespace LTMCB_Final
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
            usn = new TextBox();
            pw = new TextBox();
            cfpw = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            mail = new TextBox();
            label6 = new Label();
            label7 = new Label();
            fullname = new TextBox();
            sdt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 25);
            label1.Name = "label1";
            label1.Size = new Size(157, 35);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(48, 88);
            label2.Name = "label2";
            label2.Size = new Size(151, 26);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(48, 356);
            label3.Name = "label3";
            label3.Size = new Size(99, 26);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(48, 427);
            label4.Name = "label4";
            label4.Size = new Size(192, 26);
            label4.TabIndex = 3;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // usn
            // 
            usn.Font = new Font("Times New Roman", 13.8F);
            usn.Location = new Point(262, 80);
            usn.Name = "usn";
            usn.Size = new Size(307, 34);
            usn.TabIndex = 4;
            // 
            // pw
            // 
            pw.Font = new Font("Times New Roman", 13.8F);
            pw.Location = new Point(262, 348);
            pw.Name = "pw";
            pw.Size = new Size(307, 34);
            pw.TabIndex = 5;
            pw.UseSystemPasswordChar = true;
            // 
            // cfpw
            // 
            cfpw.Font = new Font("Times New Roman", 13.8F);
            cfpw.Location = new Point(262, 419);
            cfpw.Name = "cfpw";
            cfpw.Size = new Size(307, 34);
            cfpw.TabIndex = 6;
            cfpw.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F);
            button1.Location = new Point(243, 488);
            button1.Name = "button1";
            button1.Size = new Size(157, 46);
            button1.TabIndex = 7;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(273, 552);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(93, 22);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng nhập";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(48, 151);
            label5.Name = "label5";
            label5.Size = new Size(65, 26);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // mail
            // 
            mail.Font = new Font("Times New Roman", 13.8F);
            mail.Location = new Point(159, 143);
            mail.Name = "mail";
            mail.Size = new Size(410, 34);
            mail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F);
            label6.Location = new Point(48, 218);
            label6.Name = "label6";
            label6.Size = new Size(101, 26);
            label6.TabIndex = 11;
            label6.Text = "Họ và tên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F);
            label7.Location = new Point(48, 287);
            label7.Name = "label7";
            label7.Size = new Size(135, 26);
            label7.TabIndex = 12;
            label7.Text = "Số điện thoại";
            // 
            // fullname
            // 
            fullname.Font = new Font("Times New Roman", 13.8F);
            fullname.Location = new Point(262, 210);
            fullname.Name = "fullname";
            fullname.Size = new Size(307, 34);
            fullname.TabIndex = 13;
            // 
            // sdt
            // 
            sdt.Font = new Font("Times New Roman", 13.8F);
            sdt.Location = new Point(262, 279);
            sdt.Name = "sdt";
            sdt.Size = new Size(307, 34);
            sdt.TabIndex = 14;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 587);
            Controls.Add(sdt);
            Controls.Add(fullname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(mail);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(cfpw);
            Controls.Add(pw);
            Controls.Add(usn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox usn;
        private TextBox pw;
        private TextBox cfpw;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label5;
        private TextBox mail;
        private Label label6;
        private Label label7;
        private TextBox fullname;
        private TextBox sdt;
    }
}