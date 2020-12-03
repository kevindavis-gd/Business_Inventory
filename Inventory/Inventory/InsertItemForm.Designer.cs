namespace Inventory
{
    partial class Form_InsertItem
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
            this.label_ItemName = new System.Windows.Forms.Label();
            this.label_ItemCount = new System.Windows.Forms.Label();
            this.label_ItemCost = new System.Windows.Forms.Label();
            this.textBox_ItemName = new System.Windows.Forms.TextBox();
            this.textBox_ItemCount = new System.Windows.Forms.TextBox();
            this.textBox_ItemCost = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_ItemId = new System.Windows.Forms.Label();
            this.textBox_ItemID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_ItemName
            // 
            this.label_ItemName.AutoSize = true;
            this.label_ItemName.Location = new System.Drawing.Point(41, 25);
            this.label_ItemName.Name = "label_ItemName";
            this.label_ItemName.Size = new System.Drawing.Size(75, 17);
            this.label_ItemName.TabIndex = 0;
            this.label_ItemName.Text = "Item Name";
            // 
            // label_ItemCount
            // 
            this.label_ItemCount.AutoSize = true;
            this.label_ItemCount.Location = new System.Drawing.Point(5, 56);
            this.label_ItemCount.Name = "label_ItemCount";
            this.label_ItemCount.Size = new System.Drawing.Size(111, 17);
            this.label_ItemCount.TabIndex = 1;
            this.label_ItemCount.Text = "Number of Items";
            // 
            // label_ItemCost
            // 
            this.label_ItemCost.AutoSize = true;
            this.label_ItemCost.Location = new System.Drawing.Point(34, 88);
            this.label_ItemCost.Name = "label_ItemCost";
            this.label_ItemCost.Size = new System.Drawing.Size(82, 17);
            this.label_ItemCost.TabIndex = 2;
            this.label_ItemCost.Text = "Cost of Item";
            // 
            // textBox_ItemName
            // 
            this.textBox_ItemName.Location = new System.Drawing.Point(122, 22);
            this.textBox_ItemName.Name = "textBox_ItemName";
            this.textBox_ItemName.Size = new System.Drawing.Size(100, 22);
            this.textBox_ItemName.TabIndex = 3;
            // 
            // textBox_ItemCount
            // 
            this.textBox_ItemCount.Location = new System.Drawing.Point(122, 53);
            this.textBox_ItemCount.Name = "textBox_ItemCount";
            this.textBox_ItemCount.Size = new System.Drawing.Size(100, 22);
            this.textBox_ItemCount.TabIndex = 4;
            // 
            // textBox_ItemCost
            // 
            this.textBox_ItemCost.Location = new System.Drawing.Point(122, 88);
            this.textBox_ItemCost.Name = "textBox_ItemCost";
            this.textBox_ItemCost.Size = new System.Drawing.Size(100, 22);
            this.textBox_ItemCost.TabIndex = 5;
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Location = new System.Drawing.Point(147, 172);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(55, 172);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // label_ItemId
            // 
            this.label_ItemId.AutoSize = true;
            this.label_ItemId.Location = new System.Drawing.Point(70, 128);
            this.label_ItemId.Name = "label_ItemId";
            this.label_ItemId.Size = new System.Drawing.Size(51, 17);
            this.label_ItemId.TabIndex = 8;
            this.label_ItemId.Text = "Item ID";
            // 
            // textBox_ItemID
            // 
            this.textBox_ItemID.Location = new System.Drawing.Point(122, 125);
            this.textBox_ItemID.Name = "textBox_ItemID";
            this.textBox_ItemID.Size = new System.Drawing.Size(100, 22);
            this.textBox_ItemID.TabIndex = 9;
            // 
            // Form_InsertItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 207);
            this.Controls.Add(this.textBox_ItemID);
            this.Controls.Add(this.label_ItemId);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_ItemCost);
            this.Controls.Add(this.textBox_ItemCount);
            this.Controls.Add(this.textBox_ItemName);
            this.Controls.Add(this.label_ItemCost);
            this.Controls.Add(this.label_ItemCount);
            this.Controls.Add(this.label_ItemName);
            this.Name = "Form_InsertItem";
            this.Text = "Insert Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ItemName;
        private System.Windows.Forms.Label label_ItemCount;
        private System.Windows.Forms.Label label_ItemCost;
        private System.Windows.Forms.TextBox textBox_ItemName;
        private System.Windows.Forms.TextBox textBox_ItemCount;
        private System.Windows.Forms.TextBox textBox_ItemCost;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_ItemId;
        private System.Windows.Forms.TextBox textBox_ItemID;
    }
}