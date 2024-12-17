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
                using (var connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Query to get the count of items in the RequestRetrieval table
                    string query = "SELECT COUNT(*) FROM RequestRetrieval";

                    using (var command = new OleDbCommand(query, connection))
                    {
                        int itemCount = Convert.ToInt32(command.ExecuteScalar()); // ExecuteScalar returns the first column of the first row

                        int formX = 40; // Initial X position for the form
                        int formY = 10; // Initial Y position for the form

                        // Create the specified number of tiles based on itemCount
                        for (int i = 0; i < itemCount; i++)
                        {
                            // Create an instance of the RetrievalTile form
                            RetrievalControl retrievalTile = new RetrievalControl();

                            // Set the tile location relative to the panel (use coordinates inside the container)
                            retrievalTile.Location = new Point(formX, formY);

                            // Add the tile to the panel (retrievalContainer is the name of the Panel control)
                            retrievalContainer.Controls.Add(retrievalTile);

                            // Adjust the Y position for the next tile
                            formX += retrievalTile.Width + 30; // Move Y position for the next form
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Example event handler where you call DisplayRetrievalTiles when needed (e.g., form load or button click)
        private void RetrievalRequests_Load(object sender, EventArgs e)
        {
            DisplayRetrievalTiles(); // Call the method to display the tiles in the panel
        }
    }
}
