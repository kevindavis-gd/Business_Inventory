namespace Inventory
{
    partial class UpdateForm
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
            this.label_itemID = new System.Windows.Forms.Label();
            this.label_itemName = new System.Windows.Forms.Label();
            this.label_itemCount = new System.Windows.Forms.Label();
            this.label_ItemCost = new System.Windows.Forms.Label();
            this.textBox_ItemID = new System.Windows.Forms.TextBox();
            this.textBox_ItemName = new System.Windows.Forms.TextBox();
            this.textBox_ItemCount = new System.Windows.Forms.TextBox();
            this.textBox_ItemCost = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_itemID
            // 
            this.label_itemID.AutoSize = true;
            this.label_itemID.Location = new System.Drawing.Point(22, 63);
            this.label_itemID.Name = "label_itemID";
            this.label_itemID.Size = new System.Drawing.Size(51, 17);
            this.label_itemID.TabIndex = 0;
            this.label_itemID.Text = "Item ID";
            // 
            // label_itemName
            // 
            this.label_itemName.AutoSize = true;
            this.label_itemName.Location = new System.Drawing.Point(101, 63);
            this.label_itemName.Name = "label_itemName";
            this.label_itemName.Size = new System.Drawing.Size(75, 17);
            this.label_itemName.TabIndex = 1;
            this.label_itemName.Text = "Item Name";
            // 
            // label_itemCount
            // 
            this.label_itemCount.AutoSize = true;
            this.label_itemCount.Location = new System.Drawing.Point(204, 63);
            this.label_itemCount.Name = "label_itemCount";
            this.label_itemCount.Size = new System.Drawing.Size(86, 17);
            this.label_itemCount.TabIndex = 2;
            this.label_itemCount.Text = "Item Amount";
            // 
            // label_ItemCost
            // 
            this.label_ItemCost.AutoSize = true;
            this.label_ItemCost.Location = new System.Drawing.Point(321, 63);
            this.label_ItemCost.Name = "label_ItemCost";
            this.label_ItemCost.Size = new System.Drawing.Size(66, 17);
            this.label_ItemCost.TabIndex = 3;
            this.label_ItemCost.Text = "Item Cost";
            // 
            // textBox_ItemID
            // 
            this.textBox_ItemID.Location = new System.Drawing.Point(12, 83);
            this.textBox_ItemID.Name = "textBox_ItemID";
            this.textBox_ItemID.ReadOnly = true;
            this.textBox_ItemID.Size = new System.Drawing.Size(71, 22);
            this.textBox_ItemID.TabIndex = 4;
            // 
            // textBox_ItemName
            // 
            this.textBox_ItemName.Location = new System.Drawing.Point(104, 83);
            this.textBox_ItemName.Name = "textBox_ItemName";
            this.textBox_ItemName.Size = new System.Drawing.Size(71, 22);
            this.textBox_ItemName.TabIndex = 5;
            // 
            // textBox_ItemCount
            // 
            this.textBox_ItemCount.Location = new System.Drawing.Point(207, 83);
            this.textBox_ItemCount.Name = "textBox_ItemCount";
            this.textBox_ItemCount.Size = new System.Drawing.Size(72, 22);
            this.textBox_ItemCount.TabIndex = 6;
            // 
            // textBox_ItemCost
            // 
            this.textBox_ItemCost.Location = new System.Drawing.Point(315, 83);
            this.textBox_ItemCost.Name = "textBox_ItemCost";
            this.textBox_ItemCost.Size = new System.Drawing.Size(72, 22);
            this.textBox_ItemCost.TabIndex = 7;
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(315, 136);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 8;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(234, 136);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 171);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_ItemCost);
            this.Controls.Add(this.textBox_ItemCount);
            this.Controls.Add(this.textBox_ItemName);
            this.Controls.Add(this.textBox_ItemID);
            this.Controls.Add(this.label_ItemCost);
            this.Controls.Add(this.label_itemCount);
            this.Controls.Add(this.label_itemName);
            this.Controls.Add(this.label_itemID);
            this.Name = "UpdateForm";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_itemID;
        private System.Windows.Forms.Label label_itemName;
        private System.Windows.Forms.Label label_itemCount;
        private System.Windows.Forms.Label label_ItemCost;
        private System.Windows.Forms.TextBox textBox_ItemID;
        private System.Windows.Forms.TextBox textBox_ItemName;
        private System.Windows.Forms.TextBox textBox_ItemCount;
        private System.Windows.Forms.TextBox textBox_ItemCost;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
    }
}