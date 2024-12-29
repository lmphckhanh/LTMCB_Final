namespace LTMCB_Final
{
    partial class AccountInfo
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
            lblTitile = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            btnEdit = new Button();
            btnBack = new Button();
            btnListBill = new Button();
            SuspendLayout();
            // 
            // lblTitile
            // 
            lblTitile.AutoSize = true;
            lblTitile.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitile.ForeColor = Color.MidnightBlue;
            lblTitile.Location = new Point(41, 49);
            lblTitile.Margin = new Padding(4, 0, 4, 0);
            lblTitile.Name = "lblTitile";
            lblTitile.Size = new Size(345, 37);
            lblTitile.TabIndex = 0;
            lblTitile.Text = "Thông Tin Người Dùng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(41, 148);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 1;
            label1.Text = "Họ và Tên: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(41, 222);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(41, 302);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 32);
            label3.TabIndex = 3;
            label3.Text = "Số điện thoại:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 13.8F);
            lblName.ForeColor = Color.MidnightBlue;
            lblName.Location = new Point(240, 146);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(142, 33);
            lblName.TabIndex = 5;
            lblName.Text = "Họ và Tên: ";
            lblName.Click += lblName_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 13.8F);
            lblEmail.ForeColor = Color.MidnightBlue;
            lblEmail.Location = new Point(240, 221);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(80, 33);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Times New Roman", 13.8F);
            lblPhoneNumber.ForeColor = Color.MidnightBlue;
            lblPhoneNumber.Location = new Point(240, 301);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(163, 33);
            lblPhoneNumber.TabIndex = 7;
            lblPhoneNumber.Text = "Số điện thoại";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.CornflowerBlue;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(41, 410);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(225, 56);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Đổi mật khẩu";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(388, 410);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 56);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnListBill
            // 
            btnListBill.BackColor = Color.CornflowerBlue;
            btnListBill.Cursor = Cursors.Hand;
            btnListBill.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnListBill.ForeColor = Color.White;
            btnListBill.Location = new Point(41, 346);
            btnListBill.Margin = new Padding(4);
            btnListBill.Name = "btnListBill";
            btnListBill.Size = new Size(225, 56);
            btnListBill.TabIndex = 11;
            btnListBill.Text = "Hóa đơn của tôi";
            btnListBill.UseVisualStyleBackColor = false;
            btnListBill.Click += btnListBill_Click;
            // 
            // AccountInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(582, 518);
            Controls.Add(btnListBill);
            Controls.Add(btnBack);
            Controls.Add(btnEdit);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitile);
            Margin = new Padding(4);
            Name = "AccountInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitile;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Button btnEdit;
        private Button btnBack;
        private Button btnListBill;
    }
}