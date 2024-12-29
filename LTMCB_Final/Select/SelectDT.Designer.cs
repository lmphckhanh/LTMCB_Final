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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(311, 41);
            label1.TabIndex = 0;
            label1.Text = "CHỌN CA CHIẾU";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Times New Roman", 13.8F);
            dtpDate.Location = new Point(720, 191);
            dtpDate.Margin = new Padding(4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(31, 39);
            dtpDate.TabIndex = 1;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F);
            button1.Location = new Point(156, 627);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(124, 59);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 13.8F);
            button2.Location = new Point(551, 627);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(124, 59);
            button2.TabIndex = 5;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(93, 191);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 33);
            label3.TabIndex = 6;
            label3.Text = "Chọn ngày";
            // 
            // lsvShowTimes
            // 
            lsvShowTimes.Location = new Point(38, 280);
            lsvShowTimes.MultiSelect = false;
            lsvShowTimes.Name = "lsvShowTimes";
            lsvShowTimes.Size = new Size(768, 340);
            lsvShowTimes.TabIndex = 9;
            lsvShowTimes.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(93, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 33);
            label2.TabIndex = 10;
            label2.Text = "Rạp";
            // 
            // cbCinema
            // 
            cbCinema.FormattingEnabled = true;
            cbCinema.Location = new Point(289, 80);
            cbCinema.Name = "cbCinema";
            cbCinema.Size = new Size(464, 33);
            cbCinema.TabIndex = 11;
            cbCinema.SelectedIndexChanged += cbCinema_SelectedIndexChanged;
            // 
            // tbDate
            // 
            tbDate.Location = new Point(289, 194);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(424, 31);
            tbDate.TabIndex = 12;
            // 
            // tbCinema
            // 
            tbCinema.Location = new Point(29, 27);
            tbCinema.Name = "tbCinema";
            tbCinema.Size = new Size(150, 31);
            tbCinema.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(93, 133);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 33);
            label5.TabIndex = 14;
            label5.Text = "Địa chỉ";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(289, 133);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(424, 31);
            tbAddress.TabIndex = 15;
            // 
            // SelectDT
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 717);
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
            Margin = new Padding(4);
            Name = "SelectDT";
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
    }
}