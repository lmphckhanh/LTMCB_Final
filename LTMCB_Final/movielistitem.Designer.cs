namespace LTMCB_Final
{
    partial class movielistitem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbName = new Label();
            btnBook = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbName.ForeColor = Color.Red;
            lbName.Location = new Point(3, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(174, 49);
            lbName.TabIndex = 0;
            lbName.Text = "Linh Miêu";
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            lbName.Click += lbName_Click;
            // 
            // btnBook
            // 
            btnBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBook.Location = new Point(3, 52);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(174, 44);
            btnBook.TabIndex = 1;
            btnBook.Text = "Đặt Vé";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lbName, 0, 0);
            tableLayoutPanel1.Controls.Add(btnBook, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 225);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(180, 99);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // movielistitem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "movielistitem";
            Size = new Size(180, 324);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbName;
        private Button btnBook;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
