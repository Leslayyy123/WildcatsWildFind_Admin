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
    public partial class RetrievalTiles : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Leslie\OneDrive - Cebu Institute of Technology University\Desktop\WildFind.mdb;Persist Security Info=False;";
        public RetrievalTiles()
        {
            InitializeComponent();
        }

        private void LoadItemDetails()
        {
            try
            {
                using (var connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Query to retrieve items with the same itemName
                    string query = "SELECT fullName, dateFound, itemDescription, photo FROM ReportedItems WHERE itemName = @itemName";

                    using (var command = new OleDbCommand(query, connection))
                    {

                        using (var reader = command.ExecuteReader())
                        {
                            bool isMatchFound = false;

                            while (reader.Read())
                            {
                                byte[] dbPhoto = reader["photo"] != DBNull.Value ? (byte[])reader["photo"] : null;

                                if (dbPhoto != null)
                                {
                                    // Populate form details if a match is found
                                    lblItem.Text = reader["itemName"].ToString();
                                    lblEmail.Text = reader["email"].ToString();
                                    lblName.Text = reader["fullName"].ToString();
                                    lblDateLost.Text = Convert.ToDateTime(reader["dateLost"]).ToString("MM/dd/yyyy");
                                    lblDesc.Text = reader["itemDescription"].ToString();

                                    using (var ms = new MemoryStream(dbPhoto))
                                    {
                                        pbxItem.Image = Image.FromStream(ms);
                                    }

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}
