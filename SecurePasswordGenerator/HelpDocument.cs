using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SecurePasswordGenerator
{
    public partial class HelpDocument : Form
    {
        public HelpDocument()
        {
            InitializeComponent();
        }

        private void HelpDocument_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {
                Close();
            }
            else if (e.Control && e.KeyCode == Keys.D1 
                || e.Control && e.KeyCode == Keys.NumPad1 
                || e.Control && e.KeyCode == Keys.G)
            {
                tbHelpDoc.SelectedTab = tpGeneral;
            }
            else if (e.Control && e.KeyCode == Keys.D2 
                || e.Control && e.KeyCode == Keys.NumPad2 
                || e.Control && e.KeyCode == Keys.U)
            {
                tbHelpDoc.SelectedTab = tpUsage;
            }
            else if (e.Control && e.KeyCode == Keys.D3 
                || e.Control && e.KeyCode == Keys.NumPad3 
                || e.Control && e.KeyCode == Keys.S)
            {
                tbHelpDoc.SelectedTab = tpShortcuts;
            }
            else if (e.Control && e.KeyCode == Keys.D4 
                || e.Control && e.KeyCode == Keys.NumPad4 
                || e.Control && e.KeyCode == Keys.A)
            {
                tbHelpDoc.SelectedTab = tpAbout;
            }
        }

        private void lnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lnkGithub.Text);
        }

        private void lnkDevSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lnkDevSite.Text);
        }
    }
}
