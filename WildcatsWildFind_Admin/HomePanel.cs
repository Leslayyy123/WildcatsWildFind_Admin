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
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Leslie\OneDrive - Cebu Institute of Technology University\Desktop\WildFind.mdb;Persist Security Info=False;";

        public HomePanel()
        {
            InitializeComponent();
            UpdateCounts();
            AddProgressBarToSidebar();
            DisplayAdminLog();
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
            List<string> categories = new List<string> { "Electronics", "Clothing", "Personal", "School" };

            int yOffset = 20;

            foreach (var category in categories)
            {
                Label lblCategory = new Label();
                lblCategory.Text = category ?? "Unknown Category";
                lblCategory.Font = new Font("Arial", 9, FontStyle.Regular);
                lblCategory.ForeColor = Color.Black;
                lblCategory.Location = new Point(27, yOffset);
                lblCategory.AutoSize = true;

                Guna2ProgressBar gunaProgressBar = new Guna2ProgressBar();
                gunaProgressBar.Location = new Point(27, yOffset + 20);
                gunaProgressBar.Size = new Size(219, 20);

                int progress = GetProgressByCategory(category);
                gunaProgressBar.Value = progress == -1 ? 0 : progress;
                gunaProgressBar.BorderRadius = 10;
                gunaProgressBar.FillColor = Color.Yellow;
                gunaProgressBar.ProgressColor = Color.Red;

                int claimed = GetClaimedByCategory(category);
                int total = GetTotalByCategory(category);
                string lblText = (claimed == 0 || total == 0) ? "0/0" : $"{claimed}/{total}";
                Label lblCount = new Label
                {
                    Text = lblText,
                    Font = new Font("Arial", 8, FontStyle.Regular),
                    Location = new Point(205, yOffset),
                    AutoSize = true
                };
                sidebarPanel.Controls.Add(lblCategory);
                sidebarPanel.Controls.Add(gunaProgressBar);
                sidebarPanel.Controls.Add(lblCount);
                gunaProgressBar.Paint += (s, e) =>
                {
                    using (Font font = new Font("Arial", 8, FontStyle.Bold))
                    {
                        Brush brush = new SolidBrush(Color.White);
                        if (gunaProgressBar.Value == 0)
                        {
                            brush = new SolidBrush(Color.Black);
                        }

                        string percentageText = $"{gunaProgressBar.Value}%";
                        SizeF textSize = e.Graphics.MeasureString(percentageText, font);
                        float textX;
                        if (gunaProgressBar.Value == 0 || gunaProgressBar.Value == 100)
                        {
                            textX = (gunaProgressBar.Width - textSize.Width) / 2;
                        }
                        else
                        {
                            float percentage = gunaProgressBar.Value;
                            textX = ((percentage / 100) * (gunaProgressBar.Width - textSize.Width)) - 20;
                        }
                        float textY = (gunaProgressBar.Height - textSize.Height) / 2;
                        e.Graphics.DrawString(percentageText, font, brush, textX, textY);
                        brush.Dispose();
                    }
                };
                yOffset += 60;
            }
        }

        private int GetProgressByCategory(string category)
        {
            if (string.IsNullOrEmpty(category)) return 0;

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
                        progress = (result == DBNull.Value || result == null) ? 0 : Convert.ToInt32(result);
                    }
                }
                catch (OleDbException oleDbEx)
                {
                    MessageBox.Show($"Database error23: {oleDbEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progress = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progress = 0;
                }
            }

            return progress;
        }



        private int GetClaimedByCategory(string category)
        {
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void DisplayAdminLog()
        {
            try
            {
                using (var connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch the actual data
                    string query = "SELECT adminName, adminAction, adminDate, adminItem FROM AdminLog";

                    using (var command = new OleDbCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            int yPos = 0; // Y position for stacking controls vertically

                            while (reader.Read()) // Loop through the rows in the database
                            {
                                // Create an instance of AdminLogControl
                                AdminLogControl LogPanel = new AdminLogControl();

                                // Assign database values to the labels in AdminLogControl
                                LogPanel.lblName.Text = reader["adminName"].ToString();
                                LogPanel.lblTime.Text = Convert.ToDateTime(reader["adminDate"]).ToString("MM/dd/yyyy hh:mm tt");
                                LogPanel.btnAction.Text = reader["adminAction"].ToString();
                                LogPanel.lblItem.Text = reader["adminItem"].ToString();

                                // Set the position of the LogPanel control
                                LogPanel.Location = new Point(0, yPos); // X=0, Y=yPos
                                yPos += LogPanel.Height + 10; // Increment Y position for the next control (spacing = 10px)

                                // Add the control to the container (Panel control)
                                adminPanel.Controls.Add(LogPanel);
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

    }
}
