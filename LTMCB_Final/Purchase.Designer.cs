namespace LTMCB_Final
{
    partial class Purchase
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
            label7 = new Label();
            lbPaymentMethod = new Label();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            lbTotal = new Label();
            lbBillId = new Label();
            lbTicketAmount = new Label();
            lbMovieName = new Label();
            lbCustomer = new Label();
            lbBillTitle = new Label();
            btnPurchase = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 406);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 29;
            label7.Text = "Tổng số tiền:";
            // 
            // lbPaymentMethod
            // 
            lbPaymentMethod.AutoSize = true;
            lbPaymentMethod.Location = new Point(330, 348);
            lbPaymentMethod.Name = "lbPaymentMethod";
            lbPaymentMethod.Size = new Size(210, 25);
            lbPaymentMethod.TabIndex = 26;
            lbPaymentMethod.Text = "Phương thức thanh toán:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 290);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 25;
            label3.Text = "Số lượng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 224);
            label8.Name = "label8";
            label8.Size = new Size(56, 25);
            label8.TabIndex = 24;
            label8.Text = "Phim:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(78, 154);
            label9.Name = "label9";
            label9.Size = new Size(108, 25);
            label9.TabIndex = 23;
            label9.Text = "Khách hàng:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(328, 406);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(115, 25);
            lbTotal.TabIndex = 22;
            lbTotal.Text = "Tổng số tiền:";
            // 
            // lbBillId
            // 
            lbBillId.AutoSize = true;
            lbBillId.Location = new Point(79, 348);
            lbBillId.Name = "lbBillId";
            lbBillId.Size = new Size(210, 25);
            lbBillId.TabIndex = 19;
            lbBillId.Text = "Phương thức thanh toán:";
            // 
            // lbTicketAmount
            // 
            lbTicketAmount.AutoSize = true;
            lbTicketAmount.Location = new Point(329, 290);
            lbTicketAmount.Name = "lbTicketAmount";
            lbTicketAmount.Size = new Size(89, 25);
            lbTicketAmount.TabIndex = 18;
            lbTicketAmount.Text = "Số lượng:";
            // 
            // lbMovieName
            // 
            lbMovieName.AutoSize = true;
            lbMovieName.Location = new Point(329, 224);
            lbMovieName.Name = "lbMovieName";
            lbMovieName.Size = new Size(56, 25);
            lbMovieName.TabIndex = 17;
            lbMovieName.Text = "Phim:";
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Location = new Point(330, 154);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(108, 25);
            lbCustomer.TabIndex = 16;
            lbCustomer.Text = "Khách hàng:";
            // 
            // lbBillTitle
            // 
            lbBillTitle.AutoSize = true;
            lbBillTitle.Location = new Point(224, 68);
            lbBillTitle.Name = "lbBillTitle";
            lbBillTitle.Size = new Size(101, 25);
            lbBillTitle.TabIndex = 15;
            lbBillTitle.Text = "Thanh toán";
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(314, 485);
            btnPurchase.Margin = new Padding(3, 4, 3, 4);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(220, 65);
            btnPurchase.TabIndex = 30;
            btnPurchase.Text = "Thanh toán";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // Purchase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 590);
            Controls.Add(btnPurchase);
            Controls.Add(label7);
            Controls.Add(lbPaymentMethod);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(lbTotal);
            Controls.Add(lbBillId);
            Controls.Add(lbTicketAmount);
            Controls.Add(lbMovieName);
            Controls.Add(lbCustomer);
            Controls.Add(lbBillTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Purchase";
            Text = "Thanh toán";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPaymentMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbBillId;
        private System.Windows.Forms.Label lbTicketAmount;
        private System.Windows.Forms.Label lbMovieName;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbBillTitle;
        private System.Windows.Forms.Button btnPurchase;
    }
}