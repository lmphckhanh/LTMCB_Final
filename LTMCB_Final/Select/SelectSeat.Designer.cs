namespace LTMCB_Final
{
    partial class SelectSeat
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
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            seat = new Button();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(373, 41);
            label1.Name = "label1";
            label1.Size = new Size(179, 35);
            label1.TabIndex = 0;
            label1.Text = "CHỌN GHẾ";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F);
            button1.Location = new Point(637, 394);
            button1.Name = "button1";
            button1.Size = new Size(98, 48);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 13.8F);
            button2.Location = new Point(768, 394);
            button2.Name = "button2";
            button2.Size = new Size(98, 48);
            button2.TabIndex = 5;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(seat);
            groupBox1.Location = new Point(47, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 339);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // seat
            // 
            seat.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seat.Location = new Point(18, 26);
            seat.Name = "seat";
            seat.Size = new Size(50, 50);
            seat.TabIndex = 0;
            seat.Text = "S";
            seat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(637, 350);
            label2.Name = "label2";
            label2.Size = new Size(101, 26);
            label2.TabIndex = 7;
            label2.Text = "Tổng tiền";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(637, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 229);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(21, 26);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 0;
            button3.Text = "A1";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(21, 95);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 1;
            button4.Text = "A1";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(21, 164);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 2;
            button5.Text = "A1";
            button5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 39);
            label3.Name = "label3";
            label3.Size = new Size(73, 26);
            label3.TabIndex = 3;
            label3.Text = "Đã đặt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 108);
            label4.Name = "label4";
            label4.Size = new Size(68, 26);
            label4.TabIndex = 4;
            label4.Text = "Trống";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 177);
            label5.Name = "label5";
            label5.Size = new Size(114, 26);
            label5.TabIndex = 5;
            label5.Text = "Đang chọn";
            // 
            // SelectSeat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 502);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "SelectSeat";
            Text = "SelectSeat";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label2;
        private Button seat;
        private GroupBox groupBox2;
        private Button button3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button5;
        private Button button4;
    }
}