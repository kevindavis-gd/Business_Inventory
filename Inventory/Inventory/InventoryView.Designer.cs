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
            this.menuStrip_child = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_child.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CompanyName
            // 
            this.label_CompanyName.AutoSize = true;
            this.label_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CompanyName.Location = new System.Drawing.Point(112, 34);
            this.label_CompanyName.Name = "label_CompanyName";
            this.label_CompanyName.Size = new System.Drawing.Size(222, 32);
            this.label_CompanyName.TabIndex = 0;
            this.label_CompanyName.Text = "CompanyName";
            // 
            // listBox_Items
            // 
            this.listBox_Items.FormattingEnabled = true;
            this.listBox_Items.ItemHeight = 16;
            this.listBox_Items.Location = new System.Drawing.Point(56, 69);
            this.listBox_Items.MultiColumn = true;
            this.listBox_Items.Name = "listBox_Items";
            this.listBox_Items.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_Items.Size = new System.Drawing.Size(330, 308);
            this.listBox_Items.TabIndex = 1;
            // 
            // menuStrip_child
            // 
            this.menuStrip_child.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_child.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip_child.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_child.Name = "menuStrip_child";
            this.menuStrip_child.Size = new System.Drawing.Size(450, 28);
            this.menuStrip_child.TabIndex = 2;
            this.menuStrip_child.Text = "Business";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem,
            this.updateItemToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // InsertItemToolStripMenuItem
            // 
            this.InsertItemToolStripMenuItem.Name = "InsertItemToolStripMenuItem";
            this.InsertItemToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.InsertItemToolStripMenuItem.Text = "Insert Item";
            this.InsertItemToolStripMenuItem.Click += new System.EventHandler(this.InsertItemToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // updateItemToolStripMenuItem
            // 
            this.updateItemToolStripMenuItem.Name = "updateItemToolStripMenuItem";
            this.updateItemToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateItemToolStripMenuItem.Text = "Update Item";
            // 
            // InventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 471);
            this.Controls.Add(this.listBox_Items);
            this.Controls.Add(this.label_CompanyName);
            this.Controls.Add(this.menuStrip_child);
            this.MainMenuStrip = this.menuStrip_child;
            this.Name = "InventoryView";
            this.Text = "InventoryView";
            this.Load += new System.EventHandler(this.InventoryView_Load);
            this.menuStrip_child.ResumeLayout(false);
            this.menuStrip_child.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CompanyName;
        private System.Windows.Forms.ListBox listBox_Items;
        private System.Windows.Forms.MenuStrip menuStrip_child;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateItemToolStripMenuItem;
    }
}