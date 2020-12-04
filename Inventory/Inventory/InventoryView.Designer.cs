namespace Inventory
{
    partial class InventoryView
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
            this.label_CompanyName = new System.Windows.Forms.Label();
            this.listBox_Items = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CompanyName
            // 
            this.label_CompanyName.AutoSize = true;
            this.label_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CompanyName.Location = new System.Drawing.Point(12, 24);
            this.label_CompanyName.Name = "label_CompanyName";
            this.label_CompanyName.Size = new System.Drawing.Size(222, 32);
            this.label_CompanyName.TabIndex = 0;
            this.label_CompanyName.Text = "CompanyName";
            // 
            // listBox_Items
            // 
            this.listBox_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Items.FormattingEnabled = true;
            this.listBox_Items.ItemHeight = 16;
            this.listBox_Items.Location = new System.Drawing.Point(0, 0);
            this.listBox_Items.Name = "listBox_Items";
            this.listBox_Items.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_Items.Size = new System.Drawing.Size(520, 328);
            this.listBox_Items.TabIndex = 1;
            this.listBox_Items.SelectedIndexChanged += new System.EventHandler(this.listBox_Items_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_CompanyName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox_Items);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 328);
            this.panel2.TabIndex = 3;
            // 
            // InventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryView";
            this.Text = "InventoryView";
            this.Load += new System.EventHandler(this.InventoryView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_CompanyName;
        public System.Windows.Forms.ListBox listBox_Items;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}