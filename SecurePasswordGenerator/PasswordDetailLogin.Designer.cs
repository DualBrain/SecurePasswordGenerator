namespace SecurePasswordGenerator
{
    partial class PasswordDetailLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordDetailLogin));
            this.grpPassProtect = new System.Windows.Forms.GroupBox();
            this.lblPasswordTrue = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtPasswordProtected = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.grpPassProtect.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPassProtect
            // 
            this.grpPassProtect.AutoSize = true;
            this.grpPassProtect.Controls.Add(this.lblPasswordTrue);
            this.grpPassProtect.Controls.Add(this.btnShow);
            this.grpPassProtect.Controls.Add(this.txtPasswordProtected);
            this.grpPassProtect.Controls.Add(this.lblPassword);
            this.grpPassProtect.Location = new System.Drawing.Point(13, 13);
            this.grpPassProtect.Name = "grpPassProtect";
            this.grpPassProtect.Size = new System.Drawing.Size(392, 181);
            this.grpPassProtect.TabIndex = 0;
            this.grpPassProtect.TabStop = false;
            this.grpPassProtect.Text = "Security Password";
            // 
            // lblPasswordTrue
            // 
            this.lblPasswordTrue.AutoSize = true;
            this.lblPasswordTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordTrue.Location = new System.Drawing.Point(115, 147);
            this.lblPasswordTrue.Name = "lblPasswordTrue";
            this.lblPasswordTrue.Size = new System.Drawing.Size(0, 16);
            this.lblPasswordTrue.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(115, 98);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(156, 37);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show Password Detail";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtPasswordProtected
            // 
            this.txtPasswordProtected.Location = new System.Drawing.Point(19, 63);
            this.txtPasswordProtected.Name = "txtPasswordProtected";
            this.txtPasswordProtected.Size = new System.Drawing.Size(359, 20);
            this.txtPasswordProtected.TabIndex = 1;
            this.txtPasswordProtected.UseSystemPasswordChar = true;
            this.txtPasswordProtected.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordProtected_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(16, 28);
            this.lblPassword.MaximumSize = new System.Drawing.Size(350, 50);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 15);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // PasswordDetailLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 206);
            this.Controls.Add(this.grpPassProtect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PasswordDetailLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password Protected";
            this.Load += new System.EventHandler(this.PasswordDetailLogin_Load);
            this.grpPassProtect.ResumeLayout(false);
            this.grpPassProtect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPassProtect;
        public System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtPasswordProtected;
        private System.Windows.Forms.Label lblPasswordTrue;
    }
}