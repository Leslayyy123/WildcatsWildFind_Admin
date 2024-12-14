using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildcatsWildFind_Admin
{
    public partial class ReportPanel : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\WildcatsWildFind_Admin\WildcatsWildFind_Admin\Database\WildFind.mdb;Persist Security Info=False;";
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

            tbxDate.Text = "Date";
            tbxDate.ForeColor = Color.White;
            tbxDate.Enter += TbxDate_Enter;
            tbxDate.Leave += TbxDate_Leave;

            tbxItemName.Text = "Item Name";
            tbxItemName.ForeColor = Color.White;
            tbxItemName.Enter += TbxItemName_Enter;
            tbxItemName.Leave += TbxItemName_Leave;

            cmbxCat.SelectedIndex = -1;
            cmbxCat.DropDownStyle = ComboBoxStyle.DropDownList;

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

        private void btnRep_Click(object sender, EventArgs e)
        {
            if (tbxID.Text == "ID" || string.IsNullOrWhiteSpace(tbxID.Text) ||
               tbxName.Text == "Full Name" || string.IsNullOrWhiteSpace(tbxName.Text) ||
               tbxLoc.Text == "Location" || string.IsNullOrWhiteSpace(tbxLoc.Text) ||
               tbxDate.Text == "Date" || string.IsNullOrWhiteSpace(tbxDate.Text) ||
               tbxItemName.Text == "Item Name" || string.IsNullOrWhiteSpace(tbxItemName.Text) ||
               tbxItemDesc.Text == "Item Description" || string.IsNullOrWhiteSpace(tbxItemDesc.Text) || 
               pbxItem.Image == null)
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbxCat.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] photoBytes = null;
            if (pbxItem.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pbxItem.Image.Save(ms, pbxItem.Image.RawFormat);
                    photoBytes = ms.ToArray();
                }
            }

            string query = @"INSERT INTO ReportedItems (studentID, fullName, itemName, dateFound, itemDescription, itemType, locationFound, status, photo) 
                     VALUES (@studentID, @fullName, @itemName, @dateFound, @itemDescription, @itemType, @locationFound, @status, @photo)";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", tbxID.Text);
                        command.Parameters.AddWithValue("@fullName", tbxName.Text);
                        command.Parameters.AddWithValue("@locationFound", tbxLoc.Text);
                        command.Parameters.AddWithValue("@dateFound", tbxDate.Text);
                        command.Parameters.AddWithValue("@itemName", tbxItemName.Text);
                        command.Parameters.AddWithValue("@itemType", cmbxCat.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@itemDescription", tbxItemDesc.Text);
                        command.Parameters.AddWithValue("@status", "Unclaimed");
                        command.Parameters.AddWithValue("@photo", photoBytes);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Report submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit the report. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            tbxID.Text = "ID";
            tbxID.ForeColor = Color.White;

            tbxName.Text = "Full Name";
            tbxName.ForeColor = Color.White;

            tbxLoc.Text = "Location";
            tbxLoc.ForeColor = Color.White;

            tbxDate.Text = "Date";
            tbxDate.ForeColor = Color.White;

            tbxItemName.Text = "Item Name";
            tbxItemName.ForeColor = Color.White;

            cmbxCat.SelectedIndex = 0;

            tbxItemDesc.Text = "Item Description";
            tbxItemDesc.ForeColor = Color.White;

            pbxItem.Image = null;
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

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbxItem.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}
