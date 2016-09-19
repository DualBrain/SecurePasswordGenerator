using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurePasswordGenerator
{
    public partial class SavePassword : Form
    {
        Provider p = new Provider("psCnf.ok");

        public SavePassword()
        {
            InitializeComponent();
        }


        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            bool tableExists = p.CheckTable("passwords");
            if (!tableExists)
            {
                int cr = p.CreateTable("passwords");
            }

            bool isEmpty = txtTitle.Text == string.Empty && txtPassword.Text == string.Empty;
 
            string customPass = txtCustom.Text;

            int ins = 0;

            if (!isEmpty)
            {
                ins = p.InsertData(txtTitle.Text, txtPassword.Text, customPass);
                
                if (ins > 0)
                {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "Password Saved :)";
                }
                else
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Sorry Not Saved :(";
                }
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Title and Password is Required :(";
            }
            
            
            
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
            txtPassword.Focus();
        }

        private void SavePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            PasswordList pList = new PasswordList();

            lblStatus.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtCustom.Text = string.Empty;
            pList.dgvPasswordList.DataSource = p.GetDataTable();
            
        }
    }
}
