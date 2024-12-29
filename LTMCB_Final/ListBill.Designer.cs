namespace LTMCB_Final
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
            STT = new ColumnHeader();
            BillID = new ColumnHeader();
            MovieName = new ColumnHeader();
            Price = new ColumnHeader();
            Date = new ColumnHeader();
            Time = new ColumnHeader();
            Status = new ColumnHeader();
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
            btnClearDate = new Button();
            SuspendLayout();
            // 
            // lsvList
            // 
            lsvList.Columns.AddRange(new ColumnHeader[] { STT, BillID, MovieName, Price, Date, Time, Status });
            lsvList.Font = new Font("Times New Roman", 13.8F);
            lsvList.ForeColor = Color.MidnightBlue;
            lsvList.Location = new Point(18, 131);
            lsvList.Margin = new Padding(2);
            lsvList.MultiSelect = false;
            lsvList.Name = "lsvList";
            lsvList.Size = new Size(618, 371);
            lsvList.TabIndex = 0;
            lsvList.UseCompatibleStateImageBehavior = false;
            lsvList.ItemActivate += lsvList_ItemActivate;
            // 
            // BillID
            // 
            BillID.Text = "Mã hóa đơn";
            // 
            // MovieName
            // 
            MovieName.Text = "Tên phim";
            // 
            // Price
            // 
            Price.Text = "Tổng tiền";
            // 
            // Date
            // 
            Date.Text = "Ngày";
            // 
            // Time
            // 
            Time.Text = "Giờ";
            // 
            // Status
            // 
            Status.Text = "Trạng thái";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.CornflowerBlue;
            btnRefresh.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(526, 76);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 50);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDeleteBill
            // 
            btnDeleteBill.BackColor = Color.CornflowerBlue;
            btnDeleteBill.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnDeleteBill.ForeColor = Color.White;
            btnDeleteBill.Location = new Point(526, 506);
            btnDeleteBill.Margin = new Padding(2);
            btnDeleteBill.Name = "btnDeleteBill";
            btnDeleteBill.Size = new Size(110, 50);
            btnDeleteBill.TabIndex = 2;
            btnDeleteBill.Text = "Hủy vé";
            btnDeleteBill.UseVisualStyleBackColor = false;
            btnDeleteBill.Click += btnDeleteBill_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(18, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 32);
            label1.TabIndex = 3;
            label1.Text = "Danh sách hóa đơn";
            // 
            // dtpFrom
            // 
            dtpFrom.Font = new Font("Times New Roman", 13.8F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(116, 93);
            dtpFrom.Margin = new Padding(2);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(24, 34);
            dtpFrom.TabIndex = 4;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(18, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 26);
            label2.TabIndex = 6;
            label2.Text = "Từ ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(206, 65);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 26);
            label3.TabIndex = 7;
            label3.Text = "Đến ngày";
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Times New Roman", 13.8F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(302, 93);
            dtpTo.Margin = new Padding(2);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(24, 34);
            dtpTo.TabIndex = 8;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // tbDateFrom
            // 
            tbDateFrom.Font = new Font("Times New Roman", 13.8F);
            tbDateFrom.ForeColor = Color.MidnightBlue;
            tbDateFrom.Location = new Point(18, 93);
            tbDateFrom.Margin = new Padding(2);
            tbDateFrom.Name = "tbDateFrom";
            tbDateFrom.PlaceholderText = "mm/dd/yyyy";
            tbDateFrom.ReadOnly = true;
            tbDateFrom.Size = new Size(94, 34);
            tbDateFrom.TabIndex = 9;
            // 
            // tbDateTo
            // 
            tbDateTo.Font = new Font("Times New Roman", 13.8F);
            tbDateTo.ForeColor = Color.MidnightBlue;
            tbDateTo.Location = new Point(206, 93);
            tbDateTo.Margin = new Padding(2);
            tbDateTo.Name = "tbDateTo";
            tbDateTo.PlaceholderText = "mm/dd/yyyy";
            tbDateTo.ReadOnly = true;
            tbDateTo.Size = new Size(92, 34);
            tbDateTo.TabIndex = 10;
            // 
            // cbBillStatus
            // 
            cbBillStatus.Font = new Font("Times New Roman", 13.8F);
            cbBillStatus.ForeColor = Color.MidnightBlue;
            cbBillStatus.FormattingEnabled = true;
            cbBillStatus.Items.AddRange(new object[] { "Còn hiệu lực", "Hết hiệu lực", "Tất cả" });
            cbBillStatus.Location = new Point(356, 92);
            cbBillStatus.Margin = new Padding(2);
            cbBillStatus.Name = "cbBillStatus";
            cbBillStatus.Size = new Size(146, 34);
            cbBillStatus.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(356, 64);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 26);
            label4.TabIndex = 12;
            label4.Text = "Trạng thái";
            // 
            // btnClearDate
            // 
            btnClearDate.BackColor = Color.Salmon;
            btnClearDate.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearDate.ForeColor = Color.Black;
            btnClearDate.Location = new Point(144, 93);
            btnClearDate.Margin = new Padding(2);
            btnClearDate.Name = "btnClearDate";
            btnClearDate.Size = new Size(34, 34);
            btnClearDate.TabIndex = 13;
            btnClearDate.Text = "[x]";
            btnClearDate.UseVisualStyleBackColor = false;
            btnClearDate.Click += btnClearDate_Click;
            // 
            // ListBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(647, 567);
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
            Margin = new Padding(2);
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
        private Button btnClearDate;
        private ColumnHeader STT;
        private ColumnHeader BillID;
        private ColumnHeader MovieName;
        private ColumnHeader Price;
        private ColumnHeader Date;
        private ColumnHeader Time;
        private ColumnHeader Status;
    }
}