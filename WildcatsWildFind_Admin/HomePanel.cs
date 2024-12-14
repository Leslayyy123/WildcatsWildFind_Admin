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
    }
}
