using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildcatsWildFind_Admin
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            btnHome.Checked = true;

            if (btnHome.Checked)
            {
                HomePanel childForm = new HomePanel();
                LoadChildForm(childForm);

                // Pass btnHome directly to HighlightButton
                HighlightButton(btnHome);
            }
        }

        private void LoadChildForm(Form childForm)
        {
            PanelContainer.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            PanelContainer.Controls.Add(childForm);
            childForm.Show();
        }

        private void HighlightButton(Guna.UI2.WinForms.Guna2Button clickedButton)
        {
            // Reset styles for all Guna2Button controls inside PanelMenu
            ResetButtonStyles(PanelMenu);

            // Highlight the clicked button
            clickedButton.FillColor = Color.Maroon; // Highlight color
            clickedButton.ForeColor = Color.White; // Highlighted text color
            clickedButton.Checked = true; // Mark as checked
        }

        private void ResetButtonStyles(Control parent)
        {
            // Iterate through all controls inside the specified parent
            foreach (Control control in parent.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Button button)
                {
                    // Reset styles to default
                    button.FillColor = Color.White; // Default color
                    button.ForeColor = Color.Black; // Default text color
                    button.Checked = false; // Uncheck the button
                }
                else if (control.HasChildren)
                {
                    // Recursively reset styles for child controls
                    ResetButtonStyles(control);
                }
            }
        }





        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePanel childForm = new HomePanel();
            LoadChildForm(childForm);
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender); 
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportPanel childForm = new ReportPanel();
            LoadChildForm(childForm);
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            UnclaimedItems childForm = new UnclaimedItems();
            LoadChildForm(childForm);
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            RetrievalRequests childForm = new RetrievalRequests();
            LoadChildForm(childForm);
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryPanel childForm = new HistoryPanel();
            LoadChildForm(childForm);
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
