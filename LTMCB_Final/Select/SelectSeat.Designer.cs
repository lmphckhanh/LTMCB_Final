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
            groupBox1.SuspendLayout();
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
            label2.Location = new Point(637, 339);
            label2.Name = "label2";
            label2.Size = new Size(101, 26);
            label2.TabIndex = 7;
            label2.Text = "Tổng tiền";
            // 
            // SelectSeat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 502);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "SelectSeat";
            Text = "SelectSeat";
            groupBox1.ResumeLayout(false);
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
    }
}