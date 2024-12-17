using Guna.UI2.WinForms;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WildcatsWildFind_Admin
{
    public partial class RetrievalRequests : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\WildcatsWildFind_Admin\WildcatsWildFind_Admin\Database\WildFind.mdb;Persist Security Info=False;";
        
        public RetrievalRequests()
        {
            InitializeComponent();
            DisplayRetrievalTiles();
        }

        private void DisplayRetrievalTiles()
        {
            try
            {
                retrievalContainer.Controls.Clear(); // Clear existing tiles
                using (var connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch the actual data (replace column names as needed)
                    string query = "SELECT itemName, studentName, dateLost, email, itemDescription FROM RequestRetrieval";

                    using (var command = new OleDbCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            int formX = 20; // X position for the tile
                            int formY = 10; // Y position for the tile

                            while (reader.Read()) // Loop through the rows in the database
                            {
                                // Create an instance of RetrievalControl
                                RetrievalControl retrievalTile = new RetrievalControl();

                                // Assign database values to the labels in RetrievalControl
                                retrievalTile.lblItem.Text = reader["itemName"].ToString();
                                retrievalTile.lblName.Text = reader["studentName"].ToString();
                                retrievalTile.lblDateLost.Text =
                                    Convert.ToDateTime(reader["dateLost"]).ToString("MM/dd/yyyy");
                                retrievalTile.lblEmail.Text = reader["email"].ToString();
                                retrievalTile.lblDesc.Text = reader["itemDescription"].ToString();

                                // Position the tile inside the container
                                retrievalTile.Location = new Point(formX, formY);

                                // Add the tile to the container (Panel control)
                                retrievalContainer.Controls.Add(retrievalTile);

                                // Adjust Y position for the next tile (stacking vertically)
                                formX += retrievalTile.Width + 20;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RetrievalRequests_Load(object sender, EventArgs e)
        {
            DisplayRetrievalTiles(); 
        }
    }
}
