﻿namespace LTMCB_Final
{
    partial class ListBill
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
            lsvList = new ListView();
            btnRefresh = new Button();
            btnDeleteBill = new Button();
            label1 = new Label();
            dtpFrom = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtpTo = new DateTimePicker();
            tbDateFrom = new TextBox();
            tbDateTo = new TextBox();
            cbBillStatus = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // lsvList
            // 
            lsvList.Location = new Point(12, 116);
            lsvList.MultiSelect = false;
            lsvList.Name = "lsvList";
            lsvList.Size = new Size(677, 431);
            lsvList.TabIndex = 0;
            lsvList.UseCompatibleStateImageBehavior = false;
            lsvList.ItemActivate += lsvList_ItemActivate;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(540, 52);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(149, 57);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBill
            // 
            btnDeleteBill.Location = new Point(544, 553);
            btnDeleteBill.Name = "btnDeleteBill";
            btnDeleteBill.Size = new Size(145, 48);
            btnDeleteBill.TabIndex = 2;
            btnDeleteBill.Text = "Hủy vé";
            btnDeleteBill.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 3;
            label1.Text = "Danh sách hóa đơn";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(126, 78);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(29, 31);
            dtpFrom.TabIndex = 4;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 6;
            label2.Text = "Từ ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 52);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 7;
            label3.Text = "Đến ngày";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(276, 80);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(29, 31);
            dtpTo.TabIndex = 8;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // tbDateFrom
            // 
            tbDateFrom.Location = new Point(12, 78);
            tbDateFrom.Name = "tbDateFrom";
            tbDateFrom.ReadOnly = true;
            tbDateFrom.Size = new Size(117, 31);
            tbDateFrom.TabIndex = 9;
            // 
            // tbDateTo
            // 
            tbDateTo.Location = new Point(169, 78);
            tbDateTo.Name = "tbDateTo";
            tbDateTo.ReadOnly = true;
            tbDateTo.Size = new Size(114, 31);
            tbDateTo.TabIndex = 10;
            // 
            // cbBillStatus
            // 
            cbBillStatus.FormattingEnabled = true;
            cbBillStatus.Items.AddRange(new object[] { "Còn hiệu lực", "Hết hiệu lực", "Tất cả" });
            cbBillStatus.Location = new Point(334, 76);
            cbBillStatus.Name = "cbBillStatus";
            cbBillStatus.Size = new Size(182, 33);
            cbBillStatus.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 48);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 12;
            label4.Text = "Trạng thái";
            // 
            // ListBill
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 605);
            Controls.Add(label4);
            Controls.Add(cbBillStatus);
            Controls.Add(tbDateTo);
            Controls.Add(tbDateFrom);
            Controls.Add(dtpTo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpFrom);
            Controls.Add(label1);
            Controls.Add(btnDeleteBill);
            Controls.Add(btnRefresh);
            Controls.Add(lsvList);
            Name = "ListBill";
            Text = "ListBill";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvList;
        private Button btnRefresh;
        private Button btnDeleteBill;
        private Label label1;
        private DateTimePicker dtpFrom;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpTo;
        private TextBox tbDateFrom;
        private TextBox tbDateTo;
        private ComboBox cbBillStatus;
        private Label label4;
    }
}