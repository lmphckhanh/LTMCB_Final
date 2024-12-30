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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPw));
            label1 = new Label();
            label2 = new Label();
            tbEmail = new TextBox();
            button1 = new Button();
            btnConfirm = new Button();
            tbCode = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
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
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(13, 170);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 33);
            label2.TabIndex = 1;
            label2.Text = "Nhập email";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Times New Roman", 13.8F);
            tbEmail.ForeColor = Color.MidnightBlue;
            tbEmail.Location = new Point(180, 167);
            tbEmail.Margin = new Padding(4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(306, 39);
            tbEmail.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(331, 214);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(155, 62);
            button1.TabIndex = 3;
            button1.Text = "Lấy mã";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.CornflowerBlue;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(331, 348);
            btnConfirm.Margin = new Padding(4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(155, 62);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tbCode
            // 
            tbCode.Font = new Font("Times New Roman", 13.8F);
            tbCode.ForeColor = Color.MidnightBlue;
            tbCode.Location = new Point(180, 301);
            tbCode.Margin = new Padding(4);
            tbCode.Name = "tbCode";
            tbCode.Size = new Size(306, 39);
            tbCode.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(13, 304);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 33);
            label3.TabIndex = 5;
            label3.Text = "Nhập mã";
            // 
            // ForgotPw
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(532, 461);
            Controls.Add(tbCode);
            Controls.Add(label3);
            Controls.Add(btnConfirm);
            Controls.Add(button1);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ForgotPw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbEmail;
        private Button button1;
        private Button btnConfirm;
        private TextBox tbCode;
        private Label label3;
    }
}