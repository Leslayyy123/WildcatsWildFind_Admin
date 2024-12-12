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
    public partial class ReportPanel : Form
    {
        public ReportPanel()
        {
            InitializeComponent();

            tbxID.Text = "ID";
            tbxID.ForeColor = Color.White;

           
            tbxID.Enter += TbxID_Enter;
            tbxID.Leave += TbxID_Leave;

            tbxName.Text = "Full Name";
            tbxName.ForeColor = Color.White;


            tbxName.Enter += TbxName_Enter;
            tbxName.Leave += TbxName_Leave;

            tbxLoc.Text = "Location";
            tbxLoc.ForeColor = Color.White;
            tbxLoc.Enter += TbxLoc_Enter;
            tbxLoc.Leave += TbxLoc_Leave;

            // tbxDate
            tbxDate.Text = "Date";
            tbxDate.ForeColor = Color.White;
            tbxDate.Enter += TbxDate_Enter;
            tbxDate.Leave += TbxDate_Leave;

            // tbxItemName
            tbxItemName.Text = "Item Name";
            tbxItemName.ForeColor = Color.White;
            tbxItemName.Enter += TbxItemName_Enter;
            tbxItemName.Leave += TbxItemName_Leave;

            // tbxItemCat
            tbxItemCat.Text = "Item Category";
            tbxItemCat.ForeColor = Color.White;
            tbxItemCat.Enter += TbxItemCat_Enter;
            tbxItemCat.Leave += TbxItemCat_Leave;

            // tbxItemDesc
            tbxItemDesc.Text = "Item Description";
            tbxItemDesc.ForeColor = Color.White;
            tbxItemDesc.Enter += TbxItemDesc_Enter;
            tbxItemDesc.Leave += TbxItemDesc_Leave;
        }

        private void TbxID_Enter(object sender, EventArgs e)
        {

            if (tbxID.Text == "ID")
            {
                tbxID.Text = "";
                tbxID.ForeColor = Color.White;
            }
        }

        private void TbxID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxID.Text))
            {
                tbxID.Text = "ID";
                tbxID.ForeColor = Color.White;
            }
        }

        private void TbxName_Enter(object sender, EventArgs e)
        {

            if (tbxName.Text == "Full Name")
            {
                tbxName.Text = "";
                tbxName.ForeColor = Color.White;
            }
        }

        private void TbxName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxName.Text))
            {
                tbxName.Text = "Full Name";
                tbxName.ForeColor = Color.White;
            }
        }

        private void TbxLoc_Enter(object sender, EventArgs e)
        {
            if (tbxLoc.Text == "Location")
            {
                tbxLoc.Text = "";
                tbxLoc.ForeColor = Color.White;
            }
        }

        private void TbxLoc_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxLoc.Text))
            {
                tbxLoc.Text = "Location";
                tbxLoc.ForeColor = Color.White;
            }
        }

        private void TbxDate_Enter(object sender, EventArgs e)
        {
            if (tbxDate.Text == "Date")
            {
                tbxDate.Text = "";
                tbxDate.ForeColor = Color.White;
            }
        }

        private void TbxDate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxDate.Text))
            {
                tbxDate.Text = "Date";
                tbxDate.ForeColor = Color.White;
            }
        }

        private void TbxItemName_Enter(object sender, EventArgs e)
        {
            if (tbxItemName.Text == "Item Name")
            {
                tbxItemName.Text = "";
                tbxItemName.ForeColor = Color.White;
            }
        }

        private void TbxItemName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxItemName.Text))
            {
                tbxItemName.Text = "Item Name";
                tbxItemName.ForeColor = Color.White;
            }
        }

        private void TbxItemCat_Enter(object sender, EventArgs e)
        {
            if (tbxItemCat.Text == "Item Category")
            {
                tbxItemCat.Text = "";
                tbxItemCat.ForeColor = Color.White;
            }
        }

        private void TbxItemCat_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxItemCat.Text))
            {
                tbxItemCat.Text = "Item Category";
                tbxItemCat.ForeColor = Color.White;
            }
        }

        private void TbxItemDesc_Enter(object sender, EventArgs e)
        {
            if (tbxItemDesc.Text == "Item Description")
            {
                tbxItemDesc.Text = "";
                tbxItemDesc.ForeColor = Color.White;
            }
        }

        private void TbxItemDesc_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxItemDesc.Text))
            {
                tbxItemDesc.Text = "Item Description";
                tbxItemDesc.ForeColor = Color.White;
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxLoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxItemCat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxItemDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
