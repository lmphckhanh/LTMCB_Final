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
            SuspendLayout();
            // 
            // lblTitile
            // 
            lblTitile.AutoSize = true;
            lblTitile.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitile.ForeColor = Color.MidnightBlue;
            lblTitile.Location = new Point(33, 39);
            lblTitile.Name = "lblTitile";
            lblTitile.Size = new Size(294, 32);
            lblTitile.TabIndex = 0;
            lblTitile.Text = "Thông Tin Người Dùng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(33, 118);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 1;
            label1.Text = "Họ và Tên: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(33, 178);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(33, 242);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 3;
            label3.Text = "Số điện thoại:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 13.8F);
            lblName.ForeColor = Color.MidnightBlue;
            lblName.Location = new Point(192, 117);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 26);
            lblName.TabIndex = 5;
            lblName.Text = "Họ và Tên: ";
            lblName.Click += lblName_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 13.8F);
            lblEmail.ForeColor = Color.MidnightBlue;
            lblEmail.Location = new Point(192, 177);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(65, 26);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Times New Roman", 13.8F);
            lblPhoneNumber.ForeColor = Color.MidnightBlue;
            lblPhoneNumber.Location = new Point(192, 241);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(135, 26);
            lblPhoneNumber.TabIndex = 7;
            lblPhoneNumber.Text = "Số điện thoại";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.CornflowerBlue;
            btnEdit.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(33, 328);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(180, 45);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit Account";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(310, 328);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 45);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AccountInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(466, 414);
            Controls.Add(btnBack);
            Controls.Add(btnEdit);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitile);
            Name = "AccountInfo";
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
    }
}