namespace Inventory
{
    partial class newCompanyForm
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
            this.label_CompanyOwner = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_owner = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_CompanyName
            // 
            this.label_CompanyName.AutoSize = true;
            this.label_CompanyName.Location = new System.Drawing.Point(64, 68);
            this.label_CompanyName.Name = "label_CompanyName";
            this.label_CompanyName.Size = new System.Drawing.Size(108, 17);
            this.label_CompanyName.TabIndex = 0;
            this.label_CompanyName.Text = "Company Name";
            // 
            // label_CompanyOwner
            // 
            this.label_CompanyOwner.AutoSize = true;
            this.label_CompanyOwner.Location = new System.Drawing.Point(206, 68);
            this.label_CompanyOwner.Name = "label_CompanyOwner";
            this.label_CompanyOwner.Size = new System.Drawing.Size(112, 17);
            this.label_CompanyOwner.TabIndex = 1;
            this.label_CompanyOwner.Text = "Company Owner";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(67, 88);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(105, 22);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_owner
            // 
            this.textBox_owner.Location = new System.Drawing.Point(209, 88);
            this.textBox_owner.Name = "textBox_owner";
            this.textBox_owner.Size = new System.Drawing.Size(100, 22);
            this.textBox_owner.TabIndex = 3;
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Location = new System.Drawing.Point(243, 127);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 4;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(156, 127);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // newCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 163);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_owner);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_CompanyOwner);
            this.Controls.Add(this.label_CompanyName);
            this.Name = "newCompanyForm";
            this.Text = "newCompanyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CompanyName;
        private System.Windows.Forms.Label label_CompanyOwner;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_owner;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_Cancel;
    }
}