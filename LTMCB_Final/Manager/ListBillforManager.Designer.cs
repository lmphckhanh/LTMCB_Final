﻿namespace LTMCB_Final.Manager
{
    partial class ListBillforManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBillforManager));
            label1 = new Label();
            btnDeleteBill = new Button();
            btnRefresh = new Button();
            lsvList = new ListView();
            STT = new ColumnHeader();
            BillID = new ColumnHeader();
            Customer = new ColumnHeader();
            Movie = new ColumnHeader();
            Price = new ColumnHeader();
            Date = new ColumnHeader();
            Time = new ColumnHeader();
            Status = new ColumnHeader();
            btnClearDate = new Button();
            label4 = new Label();
            cbBillStatus = new ComboBox();
            tbDateTo = new TextBox();
            tbDateFrom = new TextBox();
            dtpTo = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dtpFrom = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(446, 37);
            label1.TabIndex = 7;
            label1.Text = "Danh sách hóa đơn cho quản lí";
            // 
            // btnDeleteBill
            // 
            btnDeleteBill.BackColor = Color.CornflowerBlue;
            btnDeleteBill.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteBill.ForeColor = Color.White;
            btnDeleteBill.Location = new Point(1126, 646);
            btnDeleteBill.Name = "btnDeleteBill";
            btnDeleteBill.Size = new Size(160, 49);
            btnDeleteBill.TabIndex = 6;
            btnDeleteBill.Text = "Hủy vé";
            btnDeleteBill.UseVisualStyleBackColor = false;
            btnDeleteBill.Click += btnDeleteBill_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.CornflowerBlue;
            btnRefresh.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1126, 96);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(160, 49);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lsvList
            // 
            lsvList.Columns.AddRange(new ColumnHeader[] { STT, BillID, Customer, Movie, Price, Date, Time, Status });
            lsvList.ForeColor = Color.MidnightBlue;
            lsvList.FullRowSelect = true;
            lsvList.Location = new Point(30, 151);
            lsvList.MultiSelect = false;
            lsvList.Name = "lsvList";
            lsvList.Size = new Size(1256, 489);
            lsvList.TabIndex = 4;
            lsvList.UseCompatibleStateImageBehavior = false;
            lsvList.View = View.Details;
            lsvList.ItemActivate += lsvList_ItemActivate;
            // 
            // STT
            // 
            STT.Text = "STT";
            // 
            // BillID
            // 
            BillID.Text = "Mã hóa đơn";
            BillID.Width = 200;
            // 
            // Customer
            // 
            Customer.Text = "Khách hàng";
            Customer.Width = 200;
            // 
            // Movie
            // 
            Movie.Text = "Tên phim";
            Movie.Width = 200;
            // 
            // Price
            // 
            Price.Text = "Tổng tiền";
            Price.Width = 150;
            // 
            // Date
            // 
            Date.Text = "Ngày";
            Date.Width = 120;
            // 
            // Time
            // 
            Time.Text = "Giờ";
            Time.Width = 120;
            // 
            // Status
            // 
            Status.Text = "Trạng thái";
            Status.Width = 200;
            // 
            // btnClearDate
            // 
            btnClearDate.BackColor = Color.Salmon;
            btnClearDate.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearDate.ForeColor = Color.Black;
            btnClearDate.Location = new Point(495, 107);
            btnClearDate.Name = "btnClearDate";
            btnClearDate.Size = new Size(54, 40);
            btnClearDate.TabIndex = 22;
            btnClearDate.Text = "[x]";
            btnClearDate.UseVisualStyleBackColor = false;
            btnClearDate.Click += btnClearDate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(851, 64);
            label4.Name = "label4";
            label4.Size = new Size(127, 33);
            label4.TabIndex = 21;
            label4.Text = "Trạng thái";
            // 
            // cbBillStatus
            // 
            cbBillStatus.ForeColor = Color.MidnightBlue;
            cbBillStatus.FormattingEnabled = true;
            cbBillStatus.Items.AddRange(new object[] { "Còn hiệu lực", "Hết hiệu lực", "Tất cả" });
            cbBillStatus.Location = new Point(846, 104);
            cbBillStatus.Name = "cbBillStatus";
            cbBillStatus.Size = new Size(274, 41);
            cbBillStatus.TabIndex = 20;
            // 
            // tbDateTo
            // 
            tbDateTo.ForeColor = Color.MidnightBlue;
            tbDateTo.Location = new Point(555, 104);
            tbDateTo.Name = "tbDateTo";
            tbDateTo.PlaceholderText = "mm/dd/yyyy";
            tbDateTo.ReadOnly = true;
            tbDateTo.Size = new Size(208, 39);
            tbDateTo.TabIndex = 19;
            // 
            // tbDateFrom
            // 
            tbDateFrom.ForeColor = Color.MidnightBlue;
            tbDateFrom.Location = new Point(252, 102);
            tbDateFrom.Name = "tbDateFrom";
            tbDateFrom.PlaceholderText = "mm/dd/yyyy";
            tbDateFrom.ReadOnly = true;
            tbDateFrom.Size = new Size(212, 39);
            tbDateFrom.TabIndex = 18;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(769, 104);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(22, 39);
            dtpTo.TabIndex = 17;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(555, 68);
            label3.Name = "label3";
            label3.Size = new Size(120, 33);
            label3.TabIndex = 16;
            label3.Text = "Đến ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(252, 68);
            label2.Name = "label2";
            label2.Size = new Size(105, 33);
            label2.TabIndex = 15;
            label2.Text = "Từ ngày";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(470, 102);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(22, 39);
            dtpFrom.TabIndex = 14;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // ListBillforManager
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1310, 707);
            Controls.Add(btnClearDate);
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
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListBillforManager";
            Text = "ListBillforManager";
            Load += ListBillforManager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDeleteBill;
        private Button btnRefresh;
        private ListView lsvList;
        private Button btnClearDate;
        private Label label4;
        private ComboBox cbBillStatus;
        private TextBox tbDateTo;
        private TextBox tbDateFrom;
        private DateTimePicker dtpTo;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpFrom;
        private ColumnHeader STT;
        private ColumnHeader BillID;
        private ColumnHeader Customer;
        private ColumnHeader Movie;
        private ColumnHeader Price;
        private ColumnHeader Date;
        private ColumnHeader Time;
        private ColumnHeader Status;
    }
}