namespace LTMCB_Final
{
    partial class SelectDT
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
            dtpDate = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            lsvShowTimes = new ListView();
            label2 = new Label();
            cbCinema = new ComboBox();
            tbDate = new TextBox();
            tbCinema = new TextBox();
            label5 = new Label();
            tbAddress = new TextBox();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(289, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 37);
            label1.TabIndex = 0;
            label1.Text = "CHỌN CA CHIẾU";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Times New Roman", 13.8F);
            dtpDate.Location = new Point(603, 179);
            dtpDate.Margin = new Padding(4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(32, 39);
            dtpDate.TabIndex = 1;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(146, 644);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(124, 59);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(570, 644);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(124, 59);
            button2.TabIndex = 5;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(33, 191);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 33);
            label3.TabIndex = 6;
            label3.Text = "Chọn ngày";
            // 
            // lsvShowTimes
            // 
            lsvShowTimes.Font = new Font("Times New Roman", 13.8F);
            lsvShowTimes.ForeColor = Color.MidnightBlue;
            lsvShowTimes.Location = new Point(29, 244);
            lsvShowTimes.Margin = new Padding(2);
            lsvShowTimes.MultiSelect = false;
            lsvShowTimes.Name = "lsvShowTimes";
            lsvShowTimes.Size = new Size(779, 385);
            lsvShowTimes.TabIndex = 9;
            lsvShowTimes.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(42, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 33);
            label2.TabIndex = 10;
            label2.Text = "Rạp";
            // 
            // cbCinema
            // 
            cbCinema.Font = new Font("Times New Roman", 13.8F);
            cbCinema.ForeColor = Color.MidnightBlue;
            cbCinema.FormattingEnabled = true;
            cbCinema.Location = new Point(171, 84);
            cbCinema.Margin = new Padding(2);
            cbCinema.Name = "cbCinema";
            cbCinema.Size = new Size(464, 41);
            cbCinema.TabIndex = 11;
            cbCinema.SelectedIndexChanged += cbCinema_SelectedIndexChanged;
            // 
            // tbDate
            // 
            tbDate.Font = new Font("Times New Roman", 13.8F);
            tbDate.ForeColor = Color.MidnightBlue;
            tbDate.Location = new Point(171, 179);
            tbDate.Margin = new Padding(2);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(424, 39);
            tbDate.TabIndex = 12;
            // 
            // tbCinema
            // 
            tbCinema.Font = new Font("Times New Roman", 13.8F);
            tbCinema.ForeColor = Color.MidnightBlue;
            tbCinema.Location = new Point(18, 23);
            tbCinema.Margin = new Padding(2);
            tbCinema.Name = "tbCinema";
            tbCinema.Size = new Size(150, 39);
            tbCinema.TabIndex = 13;
            tbCinema.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(33, 144);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 33);
            label5.TabIndex = 14;
            label5.Text = "Địa chỉ";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Times New Roman", 13.8F);
            tbAddress.ForeColor = Color.MidnightBlue;
            tbAddress.Location = new Point(171, 132);
            tbAddress.Margin = new Padding(2);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(464, 39);
            tbAddress.TabIndex = 15;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.CornflowerBlue;
            btnLoad.Cursor = Cursors.Hand;
            btnLoad.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(684, 159);
            btnLoad.Margin = new Padding(4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(124, 59);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // SelectDT
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(839, 718);
            Controls.Add(btnLoad);
            Controls.Add(tbAddress);
            Controls.Add(label5);
            Controls.Add(tbCinema);
            Controls.Add(tbDate);
            Controls.Add(cbCinema);
            Controls.Add(label2);
            Controls.Add(lsvShowTimes);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtpDate);
            Controls.Add(label1);
            Cursor = Cursors.Default;
            Margin = new Padding(4);
            Name = "SelectDT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectDT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private ListView lsvShowTimes;
        private Label label2;
        private ComboBox cbCinema;
        private TextBox tbDate;
        private TextBox tbCinema;
        private Label label5;
        private TextBox tbAddress;
        private Button btnLoad;
    }
}