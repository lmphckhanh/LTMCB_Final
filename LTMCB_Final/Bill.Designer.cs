namespace LTMCB_Final
{
    partial class Bill
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
            lbBillTitle = new Label();
            lbCustomer = new Label();
            lbMovieName = new Label();
            lbTicketAmount = new Label();
            lbBillId = new Label();
            lbDateTime = new Label();
            lbNumber = new Label();
            lbTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbRoom = new Label();
            btnDropBill = new Button();
            btnExit = new Button();
            label9 = new Label();
            lbAddress = new Label();
            SuspendLayout();
            // 
            // lbBillTitle
            // 
            lbBillTitle.AutoSize = true;
            lbBillTitle.Location = new Point(170, 50);
            lbBillTitle.Margin = new Padding(2, 0, 2, 0);
            lbBillTitle.Name = "lbBillTitle";
            lbBillTitle.Size = new Size(67, 20);
            lbBillTitle.TabIndex = 0;
            lbBillTitle.Text = "Hóa đơn";
            lbBillTitle.Click += lbBillTitle_Click;
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Location = new Point(174, 109);
            lbCustomer.Margin = new Padding(2, 0, 2, 0);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(89, 20);
            lbCustomer.TabIndex = 1;
            lbCustomer.Text = "Khách hàng:";
            lbCustomer.Click += lbCustomer_Click;
            // 
            // lbMovieName
            // 
            lbMovieName.AutoSize = true;
            lbMovieName.Location = new Point(175, 202);
            lbMovieName.Margin = new Padding(2, 0, 2, 0);
            lbMovieName.Name = "lbMovieName";
            lbMovieName.Size = new Size(45, 20);
            lbMovieName.TabIndex = 2;
            lbMovieName.Text = "Phim:";
            // 
            // lbTicketAmount
            // 
            lbTicketAmount.AutoSize = true;
            lbTicketAmount.Location = new Point(174, 243);
            lbTicketAmount.Margin = new Padding(2, 0, 2, 0);
            lbTicketAmount.Name = "lbTicketAmount";
            lbTicketAmount.Size = new Size(72, 20);
            lbTicketAmount.TabIndex = 3;
            lbTicketAmount.Text = "Số lượng:";
            // 
            // lbBillId
            // 
            lbBillId.AutoSize = true;
            lbBillId.Location = new Point(174, 330);
            lbBillId.Margin = new Padding(2, 0, 2, 0);
            lbBillId.Name = "lbBillId";
            lbBillId.Size = new Size(92, 20);
            lbBillId.TabIndex = 4;
            lbBillId.Text = "Mã hóa đơn:";
            // 
            // lbDateTime
            // 
            lbDateTime.AutoSize = true;
            lbDateTime.Location = new Point(172, 371);
            lbDateTime.Margin = new Padding(2, 0, 2, 0);
            lbDateTime.Name = "lbDateTime";
            lbDateTime.Size = new Size(74, 20);
            lbDateTime.TabIndex = 5;
            lbDateTime.Text = "Thời gian:";
            // 
            // lbNumber
            // 
            lbNumber.AutoSize = true;
            lbNumber.Location = new Point(175, 154);
            lbNumber.Margin = new Padding(2, 0, 2, 0);
            lbNumber.Name = "lbNumber";
            lbNumber.Size = new Size(104, 20);
            lbNumber.TabIndex = 6;
            lbNumber.Text = "Số điện thoại: ";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(170, 414);
            lbTotal.Margin = new Padding(2, 0, 2, 0);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(94, 20);
            lbTotal.TabIndex = 7;
            lbTotal.Text = "Tổng số tiền:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 109);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 8;
            label1.Text = "Khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 202);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 9;
            label2.Text = "Phim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 243);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 10;
            label3.Text = "Số lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 330);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 11;
            label4.Text = "Mã hóa đơn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 371);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 12;
            label5.Text = "Thời gian:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 154);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 13;
            label6.Text = "Số điện thoại: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 414);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 14;
            label7.Text = "Tổng số tiền:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 291);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 15;
            label8.Text = "Phòng:";
            // 
            // lbRoom
            // 
            lbRoom.AutoSize = true;
            lbRoom.Location = new Point(174, 291);
            lbRoom.Margin = new Padding(2, 0, 2, 0);
            lbRoom.Name = "lbRoom";
            lbRoom.Size = new Size(50, 20);
            lbRoom.TabIndex = 16;
            lbRoom.Text = "label9";
            // 
            // btnDropBill
            // 
            btnDropBill.Location = new Point(305, 464);
            btnDropBill.Margin = new Padding(2);
            btnDropBill.Name = "btnDropBill";
            btnDropBill.Size = new Size(86, 34);
            btnDropBill.TabIndex = 17;
            btnDropBill.Text = "Hủy vé";
            btnDropBill.UseVisualStyleBackColor = true;
            btnDropBill.Click += btnDropBill_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(305, 10);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 34);
            btnExit.TabIndex = 18;
            btnExit.Text = "[X]";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(62, 448);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 20;
            label9.Text = "Địa chỉ";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(175, 448);
            lbAddress.Margin = new Padding(2, 0, 2, 0);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(55, 20);
            lbAddress.TabIndex = 19;
            lbAddress.Text = "Địa chỉ";
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 520);
            Controls.Add(label9);
            Controls.Add(lbAddress);
            Controls.Add(btnExit);
            Controls.Add(btnDropBill);
            Controls.Add(lbRoom);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbTotal);
            Controls.Add(lbNumber);
            Controls.Add(lbDateTime);
            Controls.Add(lbBillId);
            Controls.Add(lbTicketAmount);
            Controls.Add(lbMovieName);
            Controls.Add(lbCustomer);
            Controls.Add(lbBillTitle);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Bill";
            Text = "Bill";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbBillTitle;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbMovieName;
        private System.Windows.Forms.Label lbTicketAmount;
        private System.Windows.Forms.Label lbBillId;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Label label8;
        private Label lbRoom;
        private Button btnDropBill;
        private Button btnExit;
        private Label label9;
        private Label lbAddress;
    }
}