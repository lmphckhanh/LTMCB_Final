namespace LTMCB_Final.Manager
{
    partial class ListBillforManager
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
            btnDeleteBill = new Button();
            btnRefresh = new Button();
            lsvList = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 27);
            label1.Name = "label1";
            label1.Size = new Size(258, 25);
            label1.TabIndex = 7;
            label1.Text = "Danh sách hóa đơn cho quản lí";
            // 
            // btnDeleteBill
            // 
            btnDeleteBill.Location = new Point(607, 545);
            btnDeleteBill.Name = "btnDeleteBill";
            btnDeleteBill.Size = new Size(145, 48);
            btnDeleteBill.TabIndex = 6;
            btnDeleteBill.Text = "Hủy vé";
            btnDeleteBill.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(607, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(145, 48);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lsvList
            // 
            lsvList.Location = new Point(37, 69);
            lsvList.MultiSelect = false;
            lsvList.Name = "lsvList";
            lsvList.Size = new Size(715, 470);
            lsvList.TabIndex = 4;
            lsvList.UseCompatibleStateImageBehavior = false;
            // 
            // ListBillforManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 608);
            Controls.Add(label1);
            Controls.Add(btnDeleteBill);
            Controls.Add(btnRefresh);
            Controls.Add(lsvList);
            Name = "ListBillforManager";
            Text = "ListBillforManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDeleteBill;
        private Button btnRefresh;
        private ListView lsvList;
    }
}