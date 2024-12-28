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
            label1.Location = new Point(105, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(330, 41);
            label1.TabIndex = 0;
            label1.Text = "QUÊN MẬT KHẨU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(25, 220);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 33);
            label2.TabIndex = 1;
            label2.Text = "Nhập email";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Times New Roman", 13.8F);
            tbEmail.Location = new Point(180, 210);
            tbEmail.Margin = new Padding(4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(306, 39);
            tbEmail.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F);
            button1.Location = new Point(259, 257);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(122, 60);
            button1.TabIndex = 3;
            button1.Text = "Lấy mã";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ForgotPw
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 461);
            Controls.Add(button1);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
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