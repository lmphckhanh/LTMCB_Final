using System.Windows.Forms;

namespace LTMCB_Final
{
    partial class ChonPhim
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            helpProvider1 = new HelpProvider();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            btnHome = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            accountInfomationToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.7014046F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.2985954F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 363F));
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(btnHome, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Location = new Point(-4, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0827065F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.91729F));
            tableLayoutPanel1.Size = new Size(972, 131);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 32);
            label1.TabIndex = 0;
            label1.Text = "Phim Đang Chiếu";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.MidnightBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(311, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 34);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(311, 0);
            label2.Name = "label2";
            label2.Size = new Size(294, 43);
            label2.TabIndex = 3;
            label2.Text = "Thể Loại";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHome.BackColor = Color.CornflowerBlue;
            btnHome.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(838, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(131, 36);
            btnHome.TabIndex = 6;
            btnHome.Text = "Tùy Chọn";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.ForeColor = Color.MidnightBlue;
            flowLayoutPanel1.Location = new Point(-4, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(972, 364);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, accountInfomationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(210, 52);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(209, 24);
            toolStripMenuItem1.Text = "Logout";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // accountInfomationToolStripMenuItem
            // 
            accountInfomationToolStripMenuItem.Name = "accountInfomationToolStripMenuItem";
            accountInfomationToolStripMenuItem.Size = new Size(209, 24);
            accountInfomationToolStripMenuItem.Text = "Account Infomation";
            accountInfomationToolStripMenuItem.Click += accountInfomationToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(32, 19);
            // 
            // ChonPhim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(969, 444);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "ChonPhim";
            Text = "Form1";
            Load += ChonPhim_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private HelpProvider helpProvider1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnHome;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem accountInfomationToolStripMenuItem;
    }
}
