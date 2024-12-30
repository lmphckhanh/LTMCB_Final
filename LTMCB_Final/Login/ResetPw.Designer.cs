namespace LTMCB_Final.Login
{
    partial class ResetPw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPw));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnShowPass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(82, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(372, 41);
            label1.TabIndex = 0;
            label1.Text = "ĐẶT LẠI MẬT KHẨU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(18, 153);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(171, 33);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(18, 229);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(228, 33);
            label4.TabIndex = 3;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(189, 307);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(182, 61);
            button1.TabIndex = 4;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 13.8F);
            textBox2.ForeColor = Color.MidnightBlue;
            textBox2.Location = new Point(265, 143);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 39);
            textBox2.TabIndex = 0;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 13.8F);
            textBox3.ForeColor = Color.MidnightBlue;
            textBox3.Location = new Point(265, 219);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 39);
            textBox3.TabIndex = 1;
            textBox3.UseSystemPasswordChar = true;
            // 
            // btnShowPass
            // 
            btnShowPass.BackColor = Color.CornflowerBlue;
            btnShowPass.Cursor = Cursors.Hand;
            btnShowPass.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowPass.ForeColor = Color.White;
            btnShowPass.Location = new Point(423, 266);
            btnShowPass.Margin = new Padding(4);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.RightToLeft = RightToLeft.No;
            btnShowPass.Size = new Size(85, 45);
            btnShowPass.TabIndex = 19;
            btnShowPass.Text = "👁";
            btnShowPass.UseVisualStyleBackColor = false;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // ResetPw
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(532, 403);
            Controls.Add(btnShowPass);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ResetPw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnShowPass;
    }
}