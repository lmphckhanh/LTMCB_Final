namespace LTMCB_Final
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            phone = new TextBox();
            pw = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            btnShowPass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(155, 88);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(235, 41);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(44, 196);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 33);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(44, 299);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 33);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // phone
            // 
            phone.Font = new Font("Times New Roman", 13.8F);
            phone.ForeColor = Color.MidnightBlue;
            phone.Location = new Point(246, 186);
            phone.Margin = new Padding(4);
            phone.Name = "phone";
            phone.Size = new Size(249, 39);
            phone.TabIndex = 0;
            // 
            // pw
            // 
            pw.Font = new Font("Times New Roman", 13.8F);
            pw.ForeColor = Color.MidnightBlue;
            pw.Location = new Point(246, 289);
            pw.Margin = new Padding(4);
            pw.Name = "pw";
            pw.Size = new Size(249, 39);
            pw.TabIndex = 1;
            pw.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(155, 394);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(245, 59);
            button1.TabIndex = 5;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F);
            linkLabel1.ForeColor = Color.MidnightBlue;
            linkLabel1.LinkColor = Color.MidnightBlue;
            linkLabel1.Location = new Point(95, 486);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(169, 27);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Times New Roman", 12F);
            linkLabel2.ForeColor = Color.MidnightBlue;
            linkLabel2.LinkColor = Color.MidnightBlue;
            linkLabel2.Location = new Point(336, 486);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(93, 27);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Đăng ký";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // btnShowPass
            // 
            btnShowPass.BackColor = Color.CornflowerBlue;
            btnShowPass.Cursor = Cursors.Hand;
            btnShowPass.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowPass.ForeColor = Color.White;
            btnShowPass.Location = new Point(410, 336);
            btnShowPass.Margin = new Padding(4);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(85, 45);
            btnShowPass.TabIndex = 18;
            btnShowPass.Text = "👁";
            btnShowPass.UseVisualStyleBackColor = false;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // login
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(532, 635);
            Controls.Add(btnShowPass);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(pw);
            Controls.Add(phone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "login";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += login_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox phone;
        private TextBox pw;
        private Button button1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Button btnShowPass;
    }
}