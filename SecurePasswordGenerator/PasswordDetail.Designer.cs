namespace SecurePasswordGenerator
{
    partial class PasswordDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordDetail));
            this.grpPasswordDetail = new System.Windows.Forms.GroupBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCustomPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblCustomPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpPasswordDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPasswordDetail
            // 
            this.grpPasswordDetail.AutoSize = true;
            this.grpPasswordDetail.Controls.Add(this.lblUpdate);
            this.grpPasswordDetail.Controls.Add(this.btnUpdate);
            this.grpPasswordDetail.Controls.Add(this.txtCustomPassword);
            this.grpPasswordDetail.Controls.Add(this.txtPassword);
            this.grpPasswordDetail.Controls.Add(this.txtTitle);
            this.grpPasswordDetail.Controls.Add(this.lblCustomPassword);
            this.grpPasswordDetail.Controls.Add(this.lblPassword);
            this.grpPasswordDetail.Controls.Add(this.lblTitle);
            this.grpPasswordDetail.Location = new System.Drawing.Point(13, 13);
            this.grpPasswordDetail.Name = "grpPasswordDetail";
            this.grpPasswordDetail.Size = new System.Drawing.Size(423, 285);
            this.grpPasswordDetail.TabIndex = 0;
            this.grpPasswordDetail.TabStop = false;
            this.grpPasswordDetail.Text = "Password Detail";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(17, 240);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(0, 16);
            this.lblUpdate.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(289, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 34);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Password";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCustomPassword
            // 
            this.txtCustomPassword.Location = new System.Drawing.Point(20, 191);
            this.txtCustomPassword.Name = "txtCustomPassword";
            this.txtCustomPassword.Size = new System.Drawing.Size(383, 20);
            this.txtCustomPassword.TabIndex = 5;
            this.txtCustomPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomPassword_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(20, 96);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassword.Size = new System.Drawing.Size(383, 53);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(20, 35);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(383, 20);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTitle_KeyDown);
            // 
            // lblCustomPassword
            // 
            this.lblCustomPassword.AutoSize = true;
            this.lblCustomPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomPassword.Location = new System.Drawing.Point(148, 172);
            this.lblCustomPassword.Name = "lblCustomPassword";
            this.lblCustomPassword.Size = new System.Drawing.Size(131, 16);
            this.lblCustomPassword.TabIndex = 2;
            this.lblCustomPassword.Text = "Custom Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(176, 77);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(187, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // PasswordDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 314);
            this.Controls.Add(this.grpPasswordDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PasswordDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password Detail";
            this.Load += new System.EventHandler(this.PasswordDetail_Load);
            this.grpPasswordDetail.ResumeLayout(false);
            this.grpPasswordDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPasswordDetail;
        private System.Windows.Forms.Label lblCustomPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdate;
        public System.Windows.Forms.TextBox txtCustomPassword;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtTitle;
    }
}