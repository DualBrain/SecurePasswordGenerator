namespace SecurePasswordGenerator
{
    partial class SavePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavePassword));
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCustom = new System.Windows.Forms.Label();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.grpPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPassword
            // 
            this.grpPassword.AutoSize = true;
            this.grpPassword.Controls.Add(this.txtCustom);
            this.grpPassword.Controls.Add(this.lblCustom);
            this.grpPassword.Controls.Add(this.lblStatus);
            this.grpPassword.Controls.Add(this.txtPassword);
            this.grpPassword.Controls.Add(this.btnSavePassword);
            this.grpPassword.Controls.Add(this.txtTitle);
            this.grpPassword.Controls.Add(this.lblPassword);
            this.grpPassword.Controls.Add(this.lblTitle);
            this.grpPassword.Location = new System.Drawing.Point(13, 13);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Size = new System.Drawing.Size(298, 342);
            this.grpPassword.TabIndex = 0;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "Save Password";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(18, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Password Title";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(18, 98);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 18);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(21, 62);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(257, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Location = new System.Drawing.Point(78, 267);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(115, 23);
            this.btnSavePassword.TabIndex = 1;
            this.btnSavePassword.Text = "Save Password";
            this.btnSavePassword.UseVisualStyleBackColor = true;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(21, 129);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassword.Size = new System.Drawing.Size(257, 54);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.Location = new System.Drawing.Point(18, 304);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 18);
            this.lblStatus.TabIndex = 4;
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustom.Location = new System.Drawing.Point(18, 198);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(247, 18);
            this.lblCustom.TabIndex = 5;
            this.lblCustom.Text = "Custom Password for This Title";
            // 
            // txtCustom
            // 
            this.txtCustom.Location = new System.Drawing.Point(21, 231);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(257, 20);
            this.txtCustom.TabIndex = 6;
            // 
            // SavePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 372);
            this.Controls.Add(this.grpPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SavePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SavePassword_FormClosing);
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSavePassword;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.Label lblCustom;
    }
}