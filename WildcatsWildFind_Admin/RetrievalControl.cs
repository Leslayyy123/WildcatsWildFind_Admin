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

namespace WildcatsWildFind_Admin
{
    public partial class RetrievalControl : UserControl
    {
        public RetrievalControl()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                // Get inputs from the form
                string studentName = lblName.Text.Trim();  // Input for Student Name
                string itemName = lblItem.Text.Trim();        // Input for Item Name
                string dateFound = lblDateLost.Text.Trim();      // Input for Date Found
                string to = lblEmail.Text.Trim();               // Recipient Email

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
                    mail.IsBodyHtml = true; // Ensure HTML rendering

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
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
