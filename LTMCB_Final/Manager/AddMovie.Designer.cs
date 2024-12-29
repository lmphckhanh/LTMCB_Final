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
            lsvCategory.Location = new Point(426, 78);
            lsvCategory.Margin = new Padding(2);
            lsvCategory.Name = "lsvCategory";
            lsvCategory.Size = new Size(186, 134);
            lsvCategory.TabIndex = 0;
            lsvCategory.UseCompatibleStateImageBehavior = false;
            lsvCategory.View = View.List;
            // 
            // lsvMovieType
            // 
            lsvMovieType.CheckBoxes = true;
            lsvMovieType.Location = new Point(426, 267);
            lsvMovieType.Margin = new Padding(2);
            lsvMovieType.Name = "lsvMovieType";
            lsvMovieType.Size = new Size(186, 134);
            lsvMovieType.TabIndex = 1;
            lsvMovieType.UseCompatibleStateImageBehavior = false;
            lsvMovieType.View = View.List;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 90);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 2;
            label1.Text = "Mã phim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 147);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Đạo diễn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 178);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 5;
            label4.Text = "Thời lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 212);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 6;
            label5.Text = "Ngày ra mắt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 246);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 7;
            label6.Text = "Ngôn ngữ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 287);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 8;
            label7.Text = "Độ tuổi nhỏ nhất";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 314);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 9;
            label8.Text = "Poster";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 349);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 10;
            label9.Text = "Trạng thái";
            // 
            // tbMovieID
            // 
            tbMovieID.Location = new Point(182, 86);
            tbMovieID.Margin = new Padding(2);
            tbMovieID.Name = "tbMovieID";
            tbMovieID.Size = new Size(121, 27);
            tbMovieID.TabIndex = 11;
            // 
            // tbMovieName
            // 
            tbMovieName.Location = new Point(182, 113);
            tbMovieName.Margin = new Padding(2);
            tbMovieName.Name = "tbMovieName";
            tbMovieName.Size = new Size(121, 27);
            tbMovieName.TabIndex = 13;
            // 
            // tbDirector
            // 
            tbDirector.Location = new Point(182, 142);
            tbDirector.Margin = new Padding(2);
            tbDirector.Name = "tbDirector";
            tbDirector.Size = new Size(121, 27);
            tbDirector.TabIndex = 14;
            // 
            // tbDuration
            // 
            tbDuration.Location = new Point(182, 176);
            tbDuration.Margin = new Padding(2);
            tbDuration.Name = "tbDuration";
            tbDuration.Size = new Size(121, 27);
            tbDuration.TabIndex = 15;
            // 
            // tbLang
            // 
            tbLang.Location = new Point(182, 242);
            tbLang.Margin = new Padding(2);
            tbLang.Name = "tbLang";
            tbLang.Size = new Size(121, 27);
            tbLang.TabIndex = 18;
            // 
            // tbPoster
            // 
            tbPoster.Location = new Point(182, 314);
            tbPoster.Margin = new Padding(2);
            tbPoster.Name = "tbPoster";
            tbPoster.Size = new Size(121, 27);
            tbPoster.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(426, 45);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 21;
            label10.Text = "Thể loại";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(426, 234);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 22;
            label11.Text = "Loại phim";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(182, 402);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 27);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Chưa công chiếu", "Công chiếu" });
            cbStatus.Location = new Point(182, 349);
            cbStatus.Margin = new Padding(2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(121, 28);
            cbStatus.TabIndex = 24;
            // 
            // dtpReleaseDay
            // 
            dtpReleaseDay.Location = new Point(306, 210);
            dtpReleaseDay.Margin = new Padding(2);
            dtpReleaseDay.Name = "dtpReleaseDay";
            dtpReleaseDay.Size = new Size(22, 27);
            dtpReleaseDay.TabIndex = 25;
            dtpReleaseDay.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tbReleaseDay
            // 
            tbReleaseDay.Location = new Point(182, 210);
            tbReleaseDay.Margin = new Padding(2);
            tbReleaseDay.Name = "tbReleaseDay";
            tbReleaseDay.Size = new Size(121, 27);
            tbReleaseDay.TabIndex = 26;
            // 
            // cbMinAge
            // 
            cbMinAge.FormattingEnabled = true;
            cbMinAge.Items.AddRange(new object[] { "0+", "12+", "16+", "18+" });
            cbMinAge.Location = new Point(182, 281);
            cbMinAge.Margin = new Padding(2);
            cbMinAge.Name = "cbMinAge";
            cbMinAge.Size = new Size(121, 28);
            cbMinAge.TabIndex = 27;
            // 
            // AddMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 447);
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
            Margin = new Padding(2);
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