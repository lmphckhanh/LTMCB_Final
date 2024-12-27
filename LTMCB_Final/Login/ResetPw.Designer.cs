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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 52);
            label1.Name = "label1";
            label1.Size = new Size(312, 35);
            label1.TabIndex = 0;
            label1.Text = "ĐẶT LẠI MẬT KHẨU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(130, 26);
            label2.TabIndex = 1;
            label2.Text = "Mã xác nhận";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(141, 26);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(12, 241);
            label4.Name = "label4";
            label4.Size = new Size(192, 26);
            label4.TabIndex = 3;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F);
            button1.Location = new Point(149, 303);
            button1.Name = "button1";
            button1.Size = new Size(146, 49);
            button1.TabIndex = 4;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 13.8F);
            textBox1.Location = new Point(210, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 34);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 13.8F);
            textBox2.Location = new Point(210, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 34);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 13.8F);
            textBox3.Location = new Point(210, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 34);
            textBox3.TabIndex = 7;
            // 
            // ResetPw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 508);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ResetPw";
            Text = "ResetPw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}