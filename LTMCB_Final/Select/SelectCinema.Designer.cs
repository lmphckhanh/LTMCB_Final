﻿namespace LTMCB_Final
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            listView1 = new ListView();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 31);
            label1.Name = "label1";
            label1.Size = new Size(175, 35);
            label1.TabIndex = 0;
            label1.Text = "CHỌN RẠP";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 13.8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(193, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 34);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 13.8F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(193, 156);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(199, 34);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.Font = new Font("Times New Roman", 13.8F);
            listView1.Location = new Point(35, 264);
            listView1.Name = "listView1";
            listView1.Size = new Size(357, 161);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F);
            button1.Location = new Point(134, 440);
            button1.Name = "button1";
            button1.Size = new Size(175, 42);
            button1.TabIndex = 4;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(35, 105);
            label2.Name = "label2";
            label2.Size = new Size(138, 26);
            label2.TabIndex = 5;
            label2.Text = "Vị trí của bạn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(35, 165);
            label3.Name = "label3";
            label3.Size = new Size(93, 26);
            label3.TabIndex = 6;
            label3.Text = "Cụm rạp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(35, 225);
            label4.Name = "label4";
            label4.Size = new Size(145, 26);
            label4.TabIndex = 7;
            label4.Text = "Danh sách rạp";
            // 
            // SelectCinema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 508);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "SelectCinema";
            Text = "SelectCinema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ListView listView1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}