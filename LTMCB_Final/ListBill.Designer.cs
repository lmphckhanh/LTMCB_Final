namespace LTMCB_Final
{
    partial class ListBill
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
            lsvList = new ListView();
            SuspendLayout();
            // 
            // lsvList
            // 
            lsvList.Location = new Point(12, 77);
            lsvList.Name = "lsvList";
            lsvList.Size = new Size(715, 470);
            lsvList.TabIndex = 0;
            lsvList.UseCompatibleStateImageBehavior = false;
            lsvList.ItemActivate += lsvList_ItemActivate;
            // 
            // ListBill
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 605);
            Controls.Add(lsvList);
            Name = "ListBill";
            Text = "ListBill";
            ResumeLayout(false);
        }

        #endregion

        private ListView lsvList;
    }
}