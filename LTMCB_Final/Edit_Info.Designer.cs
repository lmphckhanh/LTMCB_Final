﻿namespace LTMCB_Final
{
    partial class Edit_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Info));
            btnSave = new Button();
            tbNew = new TextBox();
            tbComfirm = new TextBox();
            lbNew = new Label();
            lbComfirm = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CornflowerBlue;
            btnSave.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(136, 425);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 62);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tbNew
            // 
            tbNew.Font = new Font("Times New Roman", 13.8F);
            tbNew.ForeColor = Color.MidnightBlue;
            tbNew.Location = new Point(79, 222);
            tbNew.Margin = new Padding(4, 4, 4, 4);
            tbNew.Name = "tbNew";
            tbNew.Size = new Size(508, 39);
            tbNew.TabIndex = 4;
            // 
            // tbComfirm
            // 
            tbComfirm.Font = new Font("Times New Roman", 13.8F);
            tbComfirm.ForeColor = Color.MidnightBlue;
            tbComfirm.Location = new Point(79, 336);
            tbComfirm.Margin = new Padding(4, 4, 4, 4);
            tbComfirm.Name = "tbComfirm";
            tbComfirm.Size = new Size(505, 39);
            tbComfirm.TabIndex = 5;
            // 
            // lbNew
            // 
            lbNew.AutoSize = true;
            lbNew.Font = new Font("Times New Roman", 13.8F);
            lbNew.ForeColor = Color.MidnightBlue;
            lbNew.Location = new Point(79, 186);
            lbNew.Margin = new Padding(4, 0, 4, 0);
            lbNew.Name = "lbNew";
            lbNew.Size = new Size(83, 33);
            lbNew.TabIndex = 7;
            lbNew.Text = "label1";
            // 
            // lbComfirm
            // 
            lbComfirm.AutoSize = true;
            lbComfirm.Font = new Font("Times New Roman", 13.8F);
            lbComfirm.ForeColor = Color.MidnightBlue;
            lbComfirm.Location = new Point(79, 300);
            lbComfirm.Margin = new Padding(4, 0, 4, 0);
            lbComfirm.Name = "lbComfirm";
            lbComfirm.Size = new Size(83, 33);
            lbComfirm.TabIndex = 8;
            lbComfirm.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 13.8F);
            comboBox1.ForeColor = Color.MidnightBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Name", "PhoneNumber", "Email", "Address" });
            comboBox1.Location = new Point(79, 111);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 41);
            comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(79, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(478, 37);
            label1.TabIndex = 10;
            label1.Text = "Chọn Thông Tin Muốn Thay Đổi";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.CornflowerBlue;
            btnCancel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(391, 425);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 62);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Edit_Info
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(671, 522);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(lbComfirm);
            Controls.Add(lbNew);
            Controls.Add(tbComfirm);
            Controls.Add(tbNew);
            Controls.Add(btnSave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "Edit_Info";
            Text = "Edit_Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private TextBox tbNew;
        private TextBox tbComfirm;
        private Label lbNew;
        private Label lbComfirm;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnCancel;
    }
}