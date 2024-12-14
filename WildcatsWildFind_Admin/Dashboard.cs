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

        private void btnHome_Click(object sender, EventArgs e)
        {

            HomePanel childForm = new HomePanel();
            LoadChildForm(childForm);
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportPanel childForm = new ReportPanel();
            LoadChildForm(childForm);
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
