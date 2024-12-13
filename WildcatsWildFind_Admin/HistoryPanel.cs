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
    public partial class HistoryPanel : Form
    {
        public HistoryPanel()
        {
            InitializeComponent();

            tbxSearch.Text = "Search";
            tbxSearch.ForeColor = Color.Gray;

            tbxSearch.Enter += TbxSearch_Enter;
            tbxSearch.Leave += TbxSearch_Leave;
        }

        private void TbxSearch_Enter(object sender, EventArgs e)
        {

            if (tbxSearch.Text == "Search")
            {
                tbxSearch.Text = "";
                tbxSearch.ForeColor = Color.Gray;
            }
        }

        private void TbxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSearch.Text))
            {
                tbxSearch.Text = "Search";
                tbxSearch.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
