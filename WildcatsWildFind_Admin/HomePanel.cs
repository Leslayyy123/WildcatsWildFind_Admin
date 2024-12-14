using Guna.UI2.WinForms;
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
    public partial class HomePanel : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\WildcatsWildFind_Admin\WildcatsWildFind_Admin\Database\WildFind.mdb;Persist Security Info=False;";

        public HomePanel()
        {
            InitializeComponent();
            UpdateCounts();
            AddProgressBarToSidebar();
        }

        private void UpdateCounts()
        {
            lblUncItem.Text = GetCountByStatus("Unclaimed").ToString();
            lblReportedCount.Text = GetCountByStatus("Reported").ToString();
            lblReturnedCount.Text = GetCountByStatus("Claimed").ToString();
            lblPendingCount.Text = GetCountByStatus("Pending").ToString();
        }

        private int GetCountByStatus(string status)
        {
            int count = 0;
            string query = "SELECT COUNT(*) FROM ReportedItems WHERE Status = @Status";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", status);

                        // Execute the query and get the count
                        count = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return count;
        }

        private void AddProgressBarToSidebar()
        {
            // Define categories manually or fetch from the database
            List<string> categories = new List<string> { "Electronics", "Clothing", "Personal", "School" };

            int yOffset = 20; // Starting Y position for the first progress bar

            foreach (var category in categories)
            {
                // Create a subtitle label for each category
                Label lblCategory = new Label();
                lblCategory.Text = category ?? "Unknown Category"; // Null check for category
                lblCategory.Font = new Font("Arial", 9, FontStyle.Regular);
                lblCategory.ForeColor = Color.Black;
                lblCategory.Location = new Point(27, yOffset); // Adjust Y position for each category
                lblCategory.AutoSize = true;

                // Guna2ProgressBar for each category
                Guna2ProgressBar gunaProgressBar = new Guna2ProgressBar();
                gunaProgressBar.Location = new Point(27, yOffset + 20); // Position below the label
                gunaProgressBar.Size = new Size(219, 20); // Adjust width as needed

                // Fetch progress dynamically, handle cases with no reported items
                int progress = GetProgressByCategory(category);
                gunaProgressBar.Value = progress == -1 ? 0 : progress; // Set value to 0% if no items or error
                gunaProgressBar.BorderRadius = 10; // Rounded corners
                gunaProgressBar.FillColor = Color.Yellow; // Background color if no items reported
                gunaProgressBar.ProgressColor = Color.Red; // Progress bar color

                // Claimed/Total Label for each category
                int claimed = GetClaimedByCategory(category);
                int total = GetTotalByCategory(category);
                string lblText = (claimed == 0 || total == 0) ? "0/0" : $"{claimed}/{total}";
                Label lblCount = new Label
                {
                    Text = lblText, // Update text to reflect 0/0 if no reported items
                    Font = new Font("Arial", 8, FontStyle.Regular),
                    Location = new Point(205, yOffset), // Right-aligned near the progress bar
                    AutoSize = true
                };

                // Add Controls to the existing sidebarPanel
                sidebarPanel.Controls.Add(lblCategory);
                sidebarPanel.Controls.Add(gunaProgressBar);
                sidebarPanel.Controls.Add(lblCount);

                // Draw the percentage text directly onto the progress bar
                gunaProgressBar.Paint += (s, e) =>
                {
                    using (Font font = new Font("Arial", 8, FontStyle.Bold))
                    {
                        // Default brush color (White)
                        Brush brush = new SolidBrush(Color.White);

                        // Change text color to black if the value is 0%
                        if (gunaProgressBar.Value == 0)
                        {
                            brush = new SolidBrush(Color.Black);
                        }

                        string percentageText = $"{gunaProgressBar.Value}%";
                        SizeF textSize = e.Graphics.MeasureString(percentageText, font);

                        // Calculate the X position based on the percentage value, with a condition for 0% or 100%
                        float textX;
                        if (gunaProgressBar.Value == 0 || gunaProgressBar.Value == 100)
                        {
                            // Center the text if the value is 0% or 100%
                            textX = (gunaProgressBar.Width - textSize.Width) / 2;
                        }
                        else
                        {
                            // Calculate the X position based on the progress value for intermediate percentages
                            float percentage = gunaProgressBar.Value;
                            textX = ((percentage / 100) * (gunaProgressBar.Width - textSize.Width)) - 20;
                        }

                        // Keep the Y position centered vertically
                        float textY = (gunaProgressBar.Height - textSize.Height) / 2;

                        // Draw the string at the calculated position
                        e.Graphics.DrawString(percentageText, font, brush, textX, textY);

                        // Dispose the brush after use
                        brush.Dispose();
                    }
                };



                // Update the Y position for the next category
                yOffset += 60; // Adjust space between progress bars
            }
        }

        private int GetProgressByCategory(string category)
        {
            if (string.IsNullOrEmpty(category)) return 0; // Return 0% if category is null or empty

            int progress = 0;
            string query = $@"
    SELECT (COUNT(*) * 100) / (SELECT COUNT(*) FROM ReportedItems WHERE itemType = @itemType) 
    FROM ReportedItems WHERE Status = 'Claimed' AND itemType = @itemType";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@itemType", category);
                        object result = command.ExecuteScalar();
                        // Handle DBNull or no results by returning 0
                        progress = (result == DBNull.Value || result == null) ? 0 : Convert.ToInt32(result);
                    }
                }
                catch (OleDbException oleDbEx)
                {
                    MessageBox.Show($"Database error23: {oleDbEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progress = 0; // Return 0% if an error occurs
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progress = 0; // Return 0% if a general error occurs
                }
            }

            return progress;
        }



        private int GetClaimedByCategory(string category)
        {
            // Example query to get the claimed count for the category
            int claimed = 0;
            string query = $"SELECT COUNT(*) FROM ReportedItems WHERE Status = 'Claimed' AND itemType = @itemType";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@itemType", category);
                        claimed = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error1: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return claimed;
        }

        private int GetTotalByCategory(string category)
        {
            // Example query to get the total count for the category
            int total = 0;
            string query = $"SELECT COUNT(*) FROM ReportedItems WHERE itemType = @itemType";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@itemType", category);
                        total = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return total;
        }


    }
}
