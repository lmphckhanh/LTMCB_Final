namespace LTMCB_Final
{
    partial class ForgotPw
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
            tbEmail = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(84, 80);
            label1.Name = "label1";
            label1.Size = new Size(276, 35);
            label1.TabIndex = 0;
            label1.Text = "QUÊN MẬT KHẨU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(20, 176);
            label2.Name = "label2";
            label2.Size = new Size(118, 26);
            label2.TabIndex = 1;
            label2.Text = "Nhập email";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Times New Roman", 13.8F);
            tbEmail.ForeColor = Color.MidnightBlue;
            tbEmail.Location = new Point(144, 168);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(246, 34);
            tbEmail.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(160, 240);
            button1.Name = "button1";
            button1.Size = new Size(124, 50);
            button1.TabIndex = 3;
            button1.Text = "Lấy mã";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ForgotPw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(426, 369);
            Controls.Add(button1);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ForgotPw";
            Text = "ForgotPw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbEmail;
        private Button button1;
    }
}