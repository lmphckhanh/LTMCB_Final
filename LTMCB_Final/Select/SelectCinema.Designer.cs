namespace LTMCB_Final
{
    partial class SelectCinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCinema));
            label1 = new Label();
            comboBox2 = new ComboBox();
            listView1 = new ListView();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(168, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(209, 41);
            label1.TabIndex = 0;
            label1.Text = "CHỌN RẠP";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 13.8F);
            comboBox2.ForeColor = Color.MidnightBlue;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(241, 99);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(248, 41);
            comboBox2.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Font = new Font("Times New Roman", 13.8F);
            listView1.ForeColor = Color.MidnightBlue;
            listView1.Location = new Point(44, 235);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(445, 286);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(168, 550);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(219, 52);
            button1.TabIndex = 4;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(44, 110);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 33);
            label3.TabIndex = 6;
            label3.Text = "Cụm rạp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(44, 184);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 33);
            label4.TabIndex = 7;
            label4.Text = "Danh sách rạp";
            // 
            // SelectCinema
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(532, 635);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "SelectCinema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectCinema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox2;
        private ListView listView1;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}