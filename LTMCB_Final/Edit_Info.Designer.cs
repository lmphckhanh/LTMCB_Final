namespace LTMCB_Final
{
    partial class Edit_Info
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
            btnSave = new Button();
            tbNew = new TextBox();
            tbComfirm = new TextBox();
            lbNew = new Label();
            lbComfirm = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(73, 344);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // tbNew
            // 
            tbNew.Font = new Font("Segoe UI", 12F);
            tbNew.Location = new Point(47, 162);
            tbNew.Name = "tbNew";
            tbNew.Size = new Size(405, 34);
            tbNew.TabIndex = 4;
            // 
            // tbComfirm
            // 
            tbComfirm.Font = new Font("Segoe UI", 12F);
            tbComfirm.Location = new Point(47, 251);
            tbComfirm.Name = "tbComfirm";
            tbComfirm.Size = new Size(405, 34);
            tbComfirm.TabIndex = 5;
            // 
            // lbNew
            // 
            lbNew.AutoSize = true;
            lbNew.Location = new Point(47, 139);
            lbNew.Name = "lbNew";
            lbNew.Size = new Size(50, 20);
            lbNew.TabIndex = 7;
            lbNew.Text = "label1";
            // 
            // lbComfirm
            // 
            lbComfirm.AutoSize = true;
            lbComfirm.Location = new Point(47, 228);
            lbComfirm.Name = "lbComfirm";
            lbComfirm.Size = new Size(50, 20);
            lbComfirm.TabIndex = 8;
            lbComfirm.Text = "label1";
            
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Name", "PhoneNumber", "Email", "Address" });
            comboBox1.Location = new Point(47, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 28);
            comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(36, 24);
            label1.Name = "label1";
            label1.Size = new Size(388, 35);
            label1.TabIndex = 10;
            label1.Text = "Chọn Thông Tin Muốn Thay Đổi";
          
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(287, 344);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Edit_Info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 437);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(lbComfirm);
            Controls.Add(lbNew);
            Controls.Add(tbComfirm);
            Controls.Add(tbNew);
            Controls.Add(btnSave);
            Name = "Edit_Info";
            Text = "Edit_Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private TextBox tbNew;
        private TextBox tbComfirm;
        private Label lbNew;
        private Label lbComfirm;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnCancel;
    }
}