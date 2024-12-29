namespace LTMCB_Final.Manager
{
    partial class AddMovie
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
            lsvCategory = new ListView();
            lsvMovieType = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbMovieID = new TextBox();
            tbMovieName = new TextBox();
            tbDirector = new TextBox();
            tbDuration = new TextBox();
            tbLang = new TextBox();
            tbPoster = new TextBox();
            label10 = new Label();
            label11 = new Label();
            btnAdd = new Button();
            cbStatus = new ComboBox();
            dtpReleaseDay = new DateTimePicker();
            tbReleaseDay = new TextBox();
            cbMinAge = new ComboBox();
            SuspendLayout();
            // 
            // lsvCategory
            // 
            lsvCategory.CheckBoxes = true;
            lsvCategory.Location = new Point(573, 77);
            lsvCategory.Name = "lsvCategory";
            lsvCategory.Size = new Size(422, 184);
            lsvCategory.TabIndex = 0;
            lsvCategory.UseCompatibleStateImageBehavior = false;
            lsvCategory.View = View.List;
            // 
            // lsvMovieType
            // 
            lsvMovieType.CheckBoxes = true;
            lsvMovieType.Location = new Point(573, 327);
            lsvMovieType.Name = "lsvMovieType";
            lsvMovieType.Size = new Size(422, 184);
            lsvMovieType.TabIndex = 1;
            lsvMovieType.UseCompatibleStateImageBehavior = false;
            lsvMovieType.View = View.List;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 35);
            label1.Name = "label1";
            label1.Size = new Size(95, 26);
            label1.TabIndex = 2;
            label1.Text = "Mã phim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 85);
            label2.Name = "label2";
            label2.Size = new Size(102, 26);
            label2.TabIndex = 3;
            label2.Text = "Tên phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 135);
            label3.Name = "label3";
            label3.Size = new Size(97, 26);
            label3.TabIndex = 4;
            label3.Text = "Đạo diễn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 185);
            label4.Name = "label4";
            label4.Size = new Size(115, 26);
            label4.TabIndex = 5;
            label4.Text = "Thời lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 235);
            label5.Name = "label5";
            label5.Size = new Size(124, 26);
            label5.TabIndex = 6;
            label5.Text = "Ngày ra mắt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 285);
            label6.Name = "label6";
            label6.Size = new Size(104, 26);
            label6.TabIndex = 7;
            label6.Text = "Ngôn ngữ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 335);
            label7.Name = "label7";
            label7.Size = new Size(171, 26);
            label7.TabIndex = 8;
            label7.Text = "Độ tuổi nhỏ nhất";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 385);
            label8.Name = "label8";
            label8.Size = new Size(70, 26);
            label8.TabIndex = 9;
            label8.Text = "Poster";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 435);
            label9.Name = "label9";
            label9.Size = new Size(106, 26);
            label9.TabIndex = 10;
            label9.Text = "Trạng thái";
            // 
            // tbMovieID
            // 
            tbMovieID.Location = new Point(249, 27);
            tbMovieID.Name = "tbMovieID";
            tbMovieID.Size = new Size(225, 34);
            tbMovieID.TabIndex = 11;
            // 
            // tbMovieName
            // 
            tbMovieName.Location = new Point(249, 77);
            tbMovieName.Name = "tbMovieName";
            tbMovieName.Size = new Size(225, 34);
            tbMovieName.TabIndex = 13;
            // 
            // tbDirector
            // 
            tbDirector.Location = new Point(249, 127);
            tbDirector.Name = "tbDirector";
            tbDirector.Size = new Size(225, 34);
            tbDirector.TabIndex = 14;
            // 
            // tbDuration
            // 
            tbDuration.Location = new Point(249, 177);
            tbDuration.Name = "tbDuration";
            tbDuration.Size = new Size(225, 34);
            tbDuration.TabIndex = 15;
            // 
            // tbLang
            // 
            tbLang.Location = new Point(249, 277);
            tbLang.Name = "tbLang";
            tbLang.Size = new Size(225, 34);
            tbLang.TabIndex = 18;
            // 
            // tbPoster
            // 
            tbPoster.Location = new Point(249, 377);
            tbPoster.Name = "tbPoster";
            tbPoster.Size = new Size(225, 34);
            tbPoster.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(573, 35);
            label10.Name = "label10";
            label10.Size = new Size(88, 26);
            label10.TabIndex = 21;
            label10.Text = "Thể loại";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(573, 285);
            label11.Name = "label11";
            label11.Size = new Size(107, 26);
            label11.TabIndex = 22;
            label11.Text = "Loại phim";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(293, 501);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 50);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Chưa công chiếu", "Công chiếu" });
            cbStatus.Location = new Point(249, 427);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(225, 34);
            cbStatus.TabIndex = 24;
            // 
            // dtpReleaseDay
            // 
            dtpReleaseDay.Location = new Point(449, 227);
            dtpReleaseDay.Name = "dtpReleaseDay";
            dtpReleaseDay.Size = new Size(25, 34);
            dtpReleaseDay.TabIndex = 25;
            dtpReleaseDay.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tbReleaseDay
            // 
            tbReleaseDay.Location = new Point(249, 227);
            tbReleaseDay.Name = "tbReleaseDay";
            tbReleaseDay.Size = new Size(194, 34);
            tbReleaseDay.TabIndex = 26;
            // 
            // cbMinAge
            // 
            cbMinAge.FormattingEnabled = true;
            cbMinAge.Items.AddRange(new object[] { "0+", "12+", "16+", "18+" });
            cbMinAge.Location = new Point(249, 327);
            cbMinAge.Name = "cbMinAge";
            cbMinAge.Size = new Size(225, 34);
            cbMinAge.TabIndex = 27;
            // 
            // AddMovie
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1040, 581);
            Controls.Add(cbMinAge);
            Controls.Add(tbReleaseDay);
            Controls.Add(dtpReleaseDay);
            Controls.Add(cbStatus);
            Controls.Add(btnAdd);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(tbPoster);
            Controls.Add(tbLang);
            Controls.Add(tbDuration);
            Controls.Add(tbDirector);
            Controls.Add(tbMovieName);
            Controls.Add(tbMovieID);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lsvMovieType);
            Controls.Add(lsvCategory);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.MidnightBlue;
            Name = "AddMovie";
            Text = "AddMovie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvCategory;
        private ListView lsvMovieType;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbMovieID;
        private TextBox tbMovieName;
        private TextBox tbDirector;
        private TextBox tbDuration;
        private TextBox tbLang;
        private TextBox tbPoster;
        private Label label10;
        private Label label11;
        private Button btnAdd;
        private ComboBox cbStatus;
        private DateTimePicker dtpReleaseDay;
        private TextBox tbReleaseDay;
        private ComboBox cbMinAge;
    }
}