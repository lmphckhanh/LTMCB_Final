namespace LTMCB_Final.Manager
{
    partial class ManageMovie
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
            lsvMovieList = new ListView();
            tbSearch = new TextBox();
            cbStatus = new ComboBox();
            cbAge = new ComboBox();
            cbRate = new ComboBox();
            btnLoad = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnDeleteMovie = new Button();
            SuspendLayout();
            // 
            // lsvMovieList
            // 
            lsvMovieList.Location = new Point(39, 178);
            lsvMovieList.Name = "lsvMovieList";
            lsvMovieList.Size = new Size(871, 400);
            lsvMovieList.TabIndex = 0;
            lsvMovieList.UseCompatibleStateImageBehavior = false;
            lsvMovieList.ItemActivate += lsvMovieList_ItemActivate;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(39, 138);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(716, 34);
            tbSearch.TabIndex = 1;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Đang công chiếu", "Không công chiếu", "Tất cả" });
            cbStatus.Location = new Point(309, 84);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(173, 34);
            cbStatus.TabIndex = 2;
            // 
            // cbAge
            // 
            cbAge.FormattingEnabled = true;
            cbAge.Items.AddRange(new object[] { "0+", "12+", "16+", "18+" });
            cbAge.Location = new Point(613, 84);
            cbAge.Name = "cbAge";
            cbAge.Size = new Size(72, 34);
            cbAge.TabIndex = 3;
            // 
            // cbRate
            // 
            cbRate.FormattingEnabled = true;
            cbRate.Items.AddRange(new object[] { "0.0+", "1.0+", "2.0+", "3.0+", "4.0+", "4.5+", "5.0" });
            cbRate.Location = new Point(838, 84);
            cbRate.Name = "cbRate";
            cbRate.Size = new Size(72, 34);
            cbRate.TabIndex = 4;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.CornflowerBlue;
            btnLoad.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(806, 124);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(104, 48);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 92);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 6;
            label1.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 92);
            label2.Name = "label2";
            label2.Size = new Size(106, 26);
            label2.TabIndex = 7;
            label2.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(524, 92);
            label3.Name = "label3";
            label3.Size = new Size(83, 26);
            label3.TabIndex = 8;
            label3.Text = "Độ tuổi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(733, 92);
            label4.Name = "label4";
            label4.Size = new Size(96, 26);
            label4.TabIndex = 9;
            label4.Text = "Đánh giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 34);
            label5.Name = "label5";
            label5.Size = new Size(180, 32);
            label5.TabIndex = 10;
            label5.Text = "Quản lý phim";
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.BackColor = Color.CornflowerBlue;
            btnDeleteMovie.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteMovie.ForeColor = Color.White;
            btnDeleteMovie.Location = new Point(764, 593);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(146, 45);
            btnDeleteMovie.TabIndex = 11;
            btnDeleteMovie.Text = "Xóa phim";
            btnDeleteMovie.UseVisualStyleBackColor = false;
            btnDeleteMovie.Click += btnDeleteMovie_Click;
            // 
            // ManageMovie
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(946, 659);
            Controls.Add(btnDeleteMovie);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoad);
            Controls.Add(cbRate);
            Controls.Add(cbAge);
            Controls.Add(cbStatus);
            Controls.Add(tbSearch);
            Controls.Add(lsvMovieList);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.MidnightBlue;
            Name = "ManageMovie";
            Text = "ManageMovie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvMovieList;
        private TextBox tbSearch;
        private ComboBox cbStatus;
        private ComboBox cbAge;
        private ComboBox cbRate;
        private Button btnLoad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnDeleteMovie;
    }
}