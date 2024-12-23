namespace LTMCB_Final
{
    partial class Login
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
            usn = new TextBox();
            pw = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 70);
            label1.Name = "label1";
            label1.Size = new Size(196, 35);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(35, 157);
            label2.Name = "label2";
            label2.Size = new Size(151, 26);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(35, 239);
            label3.Name = "label3";
            label3.Size = new Size(99, 26);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // usn
            // 
            usn.Font = new Font("Times New Roman", 13.8F);
            usn.Location = new Point(197, 149);
            usn.Name = "usn";
            usn.Size = new Size(200, 34);
            usn.TabIndex = 3;
            // 
            // pw
            // 
            pw.Font = new Font("Times New Roman", 13.8F);
            pw.Location = new Point(197, 231);
            pw.Name = "pw";
            pw.Size = new Size(200, 34);
            pw.TabIndex = 4;
            pw.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F);
            button1.Location = new Point(124, 315);
            button1.Name = "button1";
            button1.Size = new Size(196, 47);
            button1.TabIndex = 5;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F);
            linkLabel1.Location = new Point(76, 389);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(134, 22);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Times New Roman", 12F);
            linkLabel2.Location = new Point(269, 389);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(75, 22);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Đăng ký";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 508);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(pw);
            Controls.Add(usn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usn;
        private TextBox pw;
        private Button button1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}