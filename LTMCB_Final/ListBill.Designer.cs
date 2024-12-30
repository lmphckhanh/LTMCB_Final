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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBill));
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
            lsvList.FullRowSelect = true;
            lsvList.Location = new Point(22, 164);
            lsvList.Margin = new Padding(2);
            lsvList.MultiSelect = false;
            lsvList.Name = "lsvList";
            lsvList.Size = new Size(1190, 463);
            lsvList.TabIndex = 0;
            lsvList.UseCompatibleStateImageBehavior = false;
            lsvList.View = View.Details;
            lsvList.ItemActivate += lsvList_ItemActivate;
            lsvList.SelectedIndexChanged += lsvList_SelectedIndexChanged;
            // 
            // STT
            // 
            STT.Text = "STT";
            // 
            // BillID
            // 
            BillID.Text = "Mã hóa đơn";
            BillID.Width = 150;
            // 
            // MovieName
            // 
            MovieName.Text = "Tên phim";
            MovieName.Width = 300;
            // 
            // Price
            // 
            Price.Text = "Tổng tiền";
            Price.Width = 200;
            // 
            // Date
            // 
            Date.Text = "Ngày";
            Date.Width = 150;
            // 
            // Time
            // 
            Time.Text = "Giờ";
            Time.Width = 150;
            // 
            // Status
            // 
            Status.Text = "Trạng thái";
            Status.Width = 200;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.CornflowerBlue;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1074, 90);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(138, 62);
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
            btnDeleteBill.Location = new Point(1074, 631);
            btnDeleteBill.Margin = new Padding(2);
            btnDeleteBill.Name = "btnDeleteBill";
            btnDeleteBill.Size = new Size(138, 62);
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
            label1.Location = new Point(22, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(284, 37);
            label1.TabIndex = 3;
            label1.Text = "Danh sách hóa đơn";
            // 
            // dtpFrom
            // 
            dtpFrom.Font = new Font("Times New Roman", 13.8F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(233, 113);
            dtpFrom.Margin = new Padding(2);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(29, 39);
            dtpFrom.TabIndex = 4;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(36, 78);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 33);
            label2.TabIndex = 6;
            label2.Text = "Từ ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(266, 79);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 33);
            label3.TabIndex = 7;
            label3.Text = "Đến ngày";
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Times New Roman", 13.8F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(460, 114);
            dtpTo.Margin = new Padding(2);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(29, 39);
            dtpTo.TabIndex = 8;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // tbDateFrom
            // 
            tbDateFrom.Font = new Font("Times New Roman", 13.8F);
            tbDateFrom.ForeColor = Color.MidnightBlue;
            tbDateFrom.Location = new Point(36, 113);
            tbDateFrom.Margin = new Padding(2);
            tbDateFrom.Name = "tbDateFrom";
            tbDateFrom.PlaceholderText = "mm/dd/yyyy";
            tbDateFrom.ReadOnly = true;
            tbDateFrom.Size = new Size(193, 39);
            tbDateFrom.TabIndex = 9;
            // 
            // tbDateTo
            // 
            tbDateTo.Font = new Font("Times New Roman", 13.8F);
            tbDateTo.ForeColor = Color.MidnightBlue;
            tbDateTo.Location = new Point(266, 114);
            tbDateTo.Margin = new Padding(2);
            tbDateTo.Name = "tbDateTo";
            tbDateTo.PlaceholderText = "mm/dd/yyyy";
            tbDateTo.ReadOnly = true;
            tbDateTo.Size = new Size(190, 39);
            tbDateTo.TabIndex = 10;
            // 
            // cbBillStatus
            // 
            cbBillStatus.Font = new Font("Times New Roman", 13.8F);
            cbBillStatus.ForeColor = Color.MidnightBlue;
            cbBillStatus.FormattingEnabled = true;
            cbBillStatus.Items.AddRange(new object[] { "Còn hiệu lực", "Hết hiệu lực", "Tất cả" });
            cbBillStatus.Location = new Point(565, 111);
            cbBillStatus.Margin = new Padding(2);
            cbBillStatus.Name = "cbBillStatus";
            cbBillStatus.Size = new Size(182, 41);
            cbBillStatus.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(565, 76);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 33);
            label4.TabIndex = 12;
            label4.Text = "Trạng thái";
            // 
            // btnClearDate
            // 
            btnClearDate.BackColor = Color.Salmon;
            btnClearDate.Cursor = Cursors.Hand;
            btnClearDate.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearDate.ForeColor = Color.Black;
            btnClearDate.Location = new Point(504, 111);
            btnClearDate.Margin = new Padding(2);
            btnClearDate.Name = "btnClearDate";
            btnClearDate.Size = new Size(42, 42);
            btnClearDate.TabIndex = 13;
            btnClearDate.Text = "[x]";
            btnClearDate.UseVisualStyleBackColor = false;
            btnClearDate.Click += btnClearDate_Click;
            // 
            // ListBill
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1223, 709);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ListBill";
            StartPosition = FormStartPosition.CenterScreen;
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