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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChonPhim));
            helpProvider1 = new HelpProvider();
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            btnHome = new Button();
            label1 = new Label();
            label2 = new Label();
            btnRefresh = new Button();
            btnClearFilter = new Button();
            btnManage = new Button();
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
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.7014046F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.2985954F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 304F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(btnHome, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(btnRefresh, 3, 1);
            tableLayoutPanel1.Controls.Add(btnClearFilter, 2, 1);
            tableLayoutPanel1.Controls.Add(btnManage, 2, 0);
            tableLayoutPanel1.Location = new Point(-5, 2);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0827065F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.91729F));
            tableLayoutPanel1.Size = new Size(1215, 164);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.MidnightBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(373, 58);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 41);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHome.BackColor = Color.CornflowerBlue;
            btnHome.Cursor = Cursors.Hand;
            btnHome.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(1047, 4);
            btnHome.Margin = new Padding(4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(164, 45);
            btnHome.TabIndex = 6;
            btnHome.Text = "Tùy Chọn";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(266, 37);
            label1.TabIndex = 0;
            label1.Text = "Phim Đang Chiếu";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(373, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(351, 54);
            label2.TabIndex = 3;
            label2.Text = "Thể Loại";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.CornflowerBlue;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1047, 58);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(164, 45);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearFilter.BackColor = Color.CornflowerBlue;
            btnClearFilter.Cursor = Cursors.Hand;
            btnClearFilter.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearFilter.ForeColor = Color.White;
            btnClearFilter.Location = new Point(864, 58);
            btnClearFilter.Margin = new Padding(4);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(164, 45);
            btnClearFilter.TabIndex = 8;
            btnClearFilter.Text = "Hủy lọc";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // btnManage
            // 
            btnManage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnManage.BackColor = Color.CornflowerBlue;
            btnManage.Cursor = Cursors.Hand;
            btnManage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManage.ForeColor = Color.White;
            btnManage.Location = new Point(864, 4);
            btnManage.Margin = new Padding(4);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(164, 45);
            btnManage.TabIndex = 9;
            btnManage.Text = "Quản lý";
            btnManage.UseVisualStyleBackColor = false;
            btnManage.Click += btnManage_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.ForeColor = Color.MidnightBlue;
            flowLayoutPanel1.Location = new Point(-5, 101);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1215, 455);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, accountInfomationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(243, 68);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(242, 32);
            toolStripMenuItem1.Text = "Logout";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // accountInfomationToolStripMenuItem
            // 
            accountInfomationToolStripMenuItem.Name = "accountInfomationToolStripMenuItem";
            accountInfomationToolStripMenuItem.Size = new Size(242, 32);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1211, 555);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ChonPhim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChonPhim";
            FormClosed += ChonPhim_FormClosed;
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
        private Button button1;
        private Button btnRefresh;
        private Button btnClearFilter;
        private Button btnManage;
    }
}
