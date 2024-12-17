using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WildcatsWildFind_Admin
{
    public partial class RetrievalControl : UserControl
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Leslie\OneDrive - Cebu Institute of Technology University\Desktop\WildFind.mdb;Persist Security Info=False;";

        public event EventHandler AcceptButtonClicked;
        private string adminUser;

        public RetrievalControl(string username)
        {
            InitializeComponent();
            adminUser = username;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                // Get inputs from the form
                string studentName = lblName.Text.Trim();  // Input for Student Name
                string itemName = lblItem.Text.Trim();     // Input for Item Name
                string dateFound = lblDateLost.Text.Trim(); // Input for Date Found
                string to = lblEmail.Text.Trim();          // Recipient Email

                // Step 1: Delete the matching row from the RequestRetrieval table
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = @"
                DELETE FROM RequestRetrieval 
                WHERE studentName = @studentName 
                  AND itemName = @itemName 
                  AND dateLost = @dateFound";

                    using (OleDbCommand cmd = new OleDbCommand(deleteQuery, connection))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@studentName", studentName);
                        cmd.Parameters.AddWithValue("@itemName", itemName);
                        cmd.Parameters.AddWithValue("@dateFound", dateFound);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Step 3: Send the email notification
                            SendEmailNotification(studentName, itemName, dateFound, to);

                            // Log the action as 'Approved'
                            LogAction(adminUser, itemName, "Approved");
                               
                        }
                        else
                        {
                            MessageBox.Show("No matching record found to delete.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            // Log the action as 'Denied'
                            LogAction(adminUser, itemName, "Denied");
                        }
                    }
                }

                AcceptButtonClicked?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendEmailNotification(string studentName, string itemName, string dateFound, string to)
        {
            try
            {
                // Email subject and HTML-formatted body
                string subject = "Good News! Your Lost Item Has Been Found";
                string body = $@"
                            <html>
                            <body style='font-family: Arial, sans-serif; line-height: 1.6; color: #333;'>
                            <p style='font-size: 16px;'>Dear <b>{studentName.ToUpper()}</b>,</p>
 
                            <p style='font-size: 14px;'>We are pleased to inform you that an item matching your retrieval request has been located.</p>
 
                            <p style='font-size: 14px; margin-top: 20px;'><b>ITEM DETAILS:</b></p>
                            <ul style='margin-left: 20px;'>
                            <li><b>ITEM NAME/DESCRIPTION:</b> {itemName}</li>
                            <li><b>DATE FOUND:</b> {dateFound}</li>
                            </ul>
 
                            <p style='margin-top: 20px;'>
                                Please proceed to the <b>LOST AND FOUND OFFICE</b> to claim your item. 
                                Make sure to bring a valid <b>STUDENT ID</b> for verification purposes.
                            </p>
 
                            <p style='margin-top: 20px;'>
                            <b>OFFICE LOCATION:</b> Near Library<br>
                            <b>OFFICE HOURS:</b> 8:00 AM - 5:00 PM
                            </p>
 
                            <p style='margin-top: 20px;'>
                                If you have any concerns, please contact us at <b>WILDFIND@GMAIL.COM</b>.
                            </p>
 
                            <p style='margin-top: 30px;'>
                                Thank you, and we hope this resolves your issue!
                            </p>
 
                            <p style='margin-top: 20px; font-weight: bold;'>
                                Sincerely,<br>
                                CEBU INSTITUTE OF TECHNOLOGY - UNIVERSITY<br>
                                <span style='font-style: italic;'>Lost and Found Office</span>
                            </p>
                            </body>
                            </html>";

                // Email credentials and SMTP configuration
                string fromEmail = "jaspherlawrence.siloy@cit.edu";
                string password = "Jasper_jb0918654321";
                string smtpHost = "smtp-mail.outlook.com";
                int smtpPort = 587;

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(fromEmail);
                    mail.To.Add(to);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpHost, smtpPort))
                    {
                        smtp.Credentials = new NetworkCredential(fromEmail, password);
                        smtp.EnableSsl = true;

                        smtp.Send(mail);
                        MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Email Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LogAction(string adminUsername, string itemName, string action)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                INSERT INTO AdminLog (adminName, adminAction, adminItem, adminDate)
                VALUES (@adminName, @adminAction, @adminItem, @adminDate)";

                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, connection))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@adminName", adminUsername);
                        cmd.Parameters.AddWithValue("@adminAction", action);
                        cmd.Parameters.AddWithValue("@adminItem", itemName);
                        cmd.Parameters.AddWithValue("@adminDate", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging action: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the item details from the form
                string studentName = lblName.Text.Trim();  // Student Name
                string itemName = lblItem.Text.Trim();     // Item Name
                string dateFound = lblDateLost.Text.Trim(); // Date Found

                // Step 1: Delete the item from the RequestRetrieval table
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Delete the retrieval request based on the student, item, and date found
                    string deleteQuery = @"
                DELETE FROM RequestRetrieval
                WHERE StudentName = @studentName
                  AND ItemName = @itemName
                  AND DateFound = @dateFound";

                    using (OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, connection))
                    {
                        // Add parameters to avoid SQL injection
                        deleteCmd.Parameters.AddWithValue("@studentName", studentName);
                        deleteCmd.Parameters.AddWithValue("@itemName", itemName);
                        deleteCmd.Parameters.AddWithValue("@dateFound", dateFound);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item successfully deleted from the retrieval requests.", "Action Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Optionally, log the action into AdminLog (if needed)
                            LogAction(adminUser, itemName, "Denied");
                        }
                        else
                        {
                            MessageBox.Show("No matching request found to delete.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
