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
    public partial class HistoryPanel : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\WildcatsWildFind_Admin\WildcatsWildFind_Admin\Database\WildFind.mdb;Persist Security Info=False;";
        public HistoryPanel()
        {
            InitializeComponent();

            tbxSearch.Text = "Search";
            tbxSearch.ForeColor = Color.Gray;

            tbxSearch.Enter += TbxSearch_Enter;
            tbxSearch.Leave += TbxSearch_Leave;
            LoadHistoryItems();
        }

        private void TbxSearch_Enter(object sender, EventArgs e)
        {

            if (tbxSearch.Text == "Search")
            {
                tbxSearch.Text = "";
                tbxSearch.ForeColor = Color.Gray;
            }
        }

        private void TbxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSearch.Text))
            {
                tbxSearch.Text = "Search";
                tbxSearch.ForeColor = Color.Gray;
            }
        }

        private void LoadHistoryItems()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM ReportedItems";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    int yOffset = 10;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        AddHistoryTile(row, yOffset);
                        yOffset += 150;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading history items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddHistoryTile(DataRow row, int yOffset)
        {
            // New Panel
            var itemPanel = new Guna2Panel
            {
                BackColor = Color.Transparent,
                BorderRadius = 10,
                BorderThickness = 1,
                BorderColor = Color.Gray,
                FillColor = Color.WhiteSmoke,
                Size = new Size(1049, 132),
                Location = new Point(25, yOffset),

            };

            itemPanel.ShadowDecoration.Parent = itemPanel;
            itemPanel.ShadowDecoration.Color = Color.Black;
            itemPanel.ShadowDecoration.Depth = 30;
            itemPanel.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            itemPanel.ShadowDecoration.Enabled = true;
            itemPanel.ShadowDecoration.BorderRadius = 15;

            splitsplit.Panel2.Controls.Add(itemPanel);

            string status = row["Status"].ToString();
            string statusText = !string.IsNullOrEmpty(status) ? status.Substring(0, 1) : "N/A";

            Color statusColor = status switch
            {
                "Claimed" or "C" => Color.Black,    
                "Unclaimed" or "U" => Color.Maroon,   
                "Pending" or "P" => Color.Gold,   
                _ => Color.Gray, 
            };

            var statusLabel = new Label
            {
                Text = statusText,
                ForeColor = statusColor,   
                Font = new Font("Californian FB", 48, FontStyle.Bold),
                Location = new Point(30, 12),
                Size = new Size(87, 91)
            };

            itemPanel.Controls.Add(statusLabel);
            statusLabel.SendToBack();

            var statusLabels = new Label
            {
                Text = row["Status"].ToString(),
                ForeColor = Color.DarkGray,
                Font = new Font("Segoe UI Semibold", 9, FontStyle.Italic),
                Location = new Point(38, 95),
                Size = new Size(66, 20)
            };
            itemPanel.Controls.Add(statusLabels);
            statusLabels.BringToFront();

            // divider panel
            var dividerPanel = new Guna2Panel
            {
                BackColor = Color.Gray,
                Location = new Point(146, 15),
                Size = new Size(2, 100)
            };
            itemPanel.Controls.Add(dividerPanel);

            // divider panel
            var dividerPanel2 = new Guna2Panel
            {
                BackColor = Color.Gray,
                Location = new Point(348, 15),
                Size = new Size(2, 100)
            };
            itemPanel.Controls.Add(dividerPanel2);

            // student name
            var studName = new Label
            {
                Text = row["fullName"].ToString(),
                ForeColor = Color.Black,
                Font = new Font("Dubai", 12),
                Location = new Point(163, 11),
                Size = new Size(132, 34)
            };
            itemPanel.Controls.Add(studName);

            // student ID
            var studID = new Label
            {
                Text = row["studentID"].ToString(),
                ForeColor = Color.Black,
                Font = new Font("Century Gothic", 8),
                Location = new Point(165, 45),
                AutoSize = true
            };
            itemPanel.Controls.Add(studID);

            // reference number
            var refNum = new Label
            {
                Text = row["ID"].ToString(),
                ForeColor = Color.DarkGray,
                Font = new Font("Segoe UI Semibold", 14),
                Location = new Point(163, 77),
                AutoSize = true
            };
            itemPanel.Controls.Add(refNum);

            // item name
            var itemName = new Label
            {
                Text = row["itemName"].ToString(),
                ForeColor = Color.Black,
                Font = new Font("Dubai", 16),
                Location = new Point(368, 3),
                AutoSize = true
            };
            itemPanel.Controls.Add(itemName);


            // item description
            var itemDescription = new Label
            {
                Text = row["itemDescription"].ToString(),
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 9),
                Location = new Point(374, 45),
                AutoSize = true
            };
            itemPanel.Controls.Add(itemDescription);

            // item category label
            var itemCat = new Label
            {
                Text = "Item Category:",
                ForeColor = Color.Black,
                Font = new Font("Dubai", 9),
                Location = new Point(374, 83),
                AutoSize = true
            };
            itemPanel.Controls.Add(itemCat);

            // item category value
            var itemCate = new Label
            {
                Text = row["itemType"].ToString(),
                ForeColor = Color.Black,
                Font = new Font("Dubai", 9),
                Location = new Point(470, 83),
                AutoSize = true
            };
            itemPanel.Controls.Add(itemCate);

            // date found label
            var dateFound = new Label
            {
                Text = "Date Found",
                ForeColor = Color.Black,
                Font = new Font("Dubai", 9),
                Location = new Point(564, 83),
                AutoSize = true
            };
            itemPanel.Controls.Add(dateFound);

            // date found value
            var datesFound = new Label
            {
                Text = Convert.ToDateTime(row["dateFound"]).ToString("MM/dd/yyyy"),
                ForeColor = Color.Black,
                Font = new Font("Dubai", 7),
                Location = new Point(675, 85),
                AutoSize = true
            };
            itemPanel.Controls.Add(datesFound);

            // loc found label
            var locationFound = new Label
            {
                Text = "Location Found:",
                ForeColor = Color.Black,
                Font = new Font("Dubai", 9),
                Location = new Point(564, 102),
                AutoSize = true
            };
            itemPanel.Controls.Add(locationFound);


            // loc found value
            var locationsFound = new Label
            {
                Text = row["locationFound"].ToString(),
                ForeColor = Color.Black,
                Font = new Font("Dubai", 7),
                Location = new Point(675, 106),
                AutoSize = true
            };
            itemPanel.Controls.Add(locationsFound);

            // picturebox
            var imageBox = new Guna2PictureBox
            {
                Size = new Size(226, 132),
                Location = new Point(820, 0),
                BorderStyle = BorderStyle.None,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Right,
                BorderRadius = 10, 
                BackColor = Color.Transparent, 
            };

            if (row["photo"] != DBNull.Value)
            {
                byte[] imageBytes = (byte[])row["photo"];

                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    try
                    {
                        imageBox.Image = Image.FromStream(ms);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            itemPanel.Controls.Add(imageBox);
            imageBox.BringToFront();

        }

    }
}
