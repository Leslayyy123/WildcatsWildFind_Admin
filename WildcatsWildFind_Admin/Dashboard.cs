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
        bool sidebarExpand;
        private string adminUser;
        public Dashboard(string username)
        {
            InitializeComponent();
            btnHome.Checked = true;

            if (btnHome.Checked)
            {
                HomePanel childForm = new HomePanel();
                LoadChildForm(childForm);
                HighlightButton(btnHome);
                adminUser = username;
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
            ResetButtonStyles(panelMenu);
            clickedButton.FillColor = Color.Maroon;
            clickedButton.ForeColor = Color.White;
            clickedButton.Checked = true;
        }

        private void ResetButtonStyles(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Button button)
                {
                    button.FillColor = Color.White;
                    button.ForeColor = Color.Black;
                    button.Checked = false;
                }
                else if (control.HasChildren)
                {
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
            ReportPanel childForm = new ReportPanel(adminUser);
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
            RetrievalRequests childForm = new RetrievalRequests(adminUser);
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

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelMenu.Width -= 50;
                if (panelMenu.Width == panelMenu.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                panelMenu.Width += 50;
                if (panelMenu.Width == panelMenu.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
