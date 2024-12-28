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
            SuspendLayout();
            // 
            // lsvMovieList
            // 
            lsvMovieList.Location = new Point(30, 161);
            lsvMovieList.Name = "lsvMovieList";
            lsvMovieList.Size = new Size(669, 414);
            lsvMovieList.TabIndex = 0;
            lsvMovieList.UseCompatibleStateImageBehavior = false;
            lsvMovieList.ItemActivate += lsvMovieList_ItemActivate;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(30, 124);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(551, 31);
            tbSearch.TabIndex = 1;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Đang công chiếu", "Không công chiếu", "Tất cả" });
            cbStatus.Location = new Point(274, 81);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(134, 33);
            cbStatus.TabIndex = 2;
            // 
            // cbAge
            // 
            cbAge.FormattingEnabled = true;
            cbAge.Items.AddRange(new object[] { "0+", "12+", "16+", "18+" });
            cbAge.Location = new Point(492, 80);
            cbAge.Name = "cbAge";
            cbAge.Size = new Size(56, 33);
            cbAge.TabIndex = 3;
            // 
            // cbRate
            // 
            cbRate.FormattingEnabled = true;
            cbRate.Items.AddRange(new object[] { "0.0+", "1.0+", "2.0+", "3.0+", "4.0+", "4.5+", "5.0" });
            cbRate.Location = new Point(643, 80);
            cbRate.Name = "cbRate";
            cbRate.Size = new Size(56, 33);
            cbRate.TabIndex = 4;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(587, 124);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 89);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 6;
            label1.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 84);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 7;
            label2.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 84);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 8;
            label3.Text = "Độ tuổi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(554, 83);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 9;
            label4.Text = "Đánh giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 32);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 10;
            label5.Text = "Quản lý phim";
            // 
            // ManageMovie
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 587);
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
    }
}