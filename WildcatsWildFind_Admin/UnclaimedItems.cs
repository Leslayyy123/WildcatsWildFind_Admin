using Guna.UI2.WinForms;
using System;
using System.Data.OleDb;

namespace WildcatsWildFind_Admin
{
    public partial class UnclaimedItems : Form
    {
        private const int MaxItemsPerPage = 4; // Maximum items per page per category
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Leslie\OneDrive - Cebu Institute of Technology University\Desktop\WildFind.mdb;Persist Security Info=False;";
        private Dictionary<string, List<(string itemName, int itemID, Image image)>> categorizedItems;        // Stores items grouped by category
        private Dictionary<string, int> currentPagePerCategory; // Tracks current page for each category

        public UnclaimedItems()
        {
            InitializeComponent();
            LoadUnclaimedItemsFromDatabase();
            LoadItems();

            tbxSearch.Text = "Search";
            tbxSearch.ForeColor = Color.Gray;

            tbxSearch.Enter += TbxSearch_Enter;
            tbxSearch.Leave += TbxSearch_Leave;
            tbxSearch.KeyDown += TbxSearch_KeyDown;
        }
        private void TbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                LoadItems(tbxSearch.Text); // Filter items when Enter is pressed
            }
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

        private void LoadUnclaimedItemsFromDatabase()
        {
            categorizedItems = new Dictionary<string, List<(string itemName, int itemId, Image image)>>(); // Include itemId
            currentPagePerCategory = new Dictionary<string, int>();

            try
            {
                using (var connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID, itemName, itemType, photo FROM ReportedItems WHERE Status = 'Unclaimed'";

                    using (var command = new OleDbCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int itemId = Convert.ToInt32(reader["ID"]); // Retrieve the ID
                            string itemName = reader["itemName"].ToString();
                            string category = reader["itemType"].ToString();
                            Image image = null;

                            // Convert OLE Object to Image
                            if (reader["photo"] != DBNull.Value)
                            {
                                byte[] imageData = (byte[])reader["photo"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    image = Image.FromStream(ms);
                                }
                            }

                            if (!categorizedItems.ContainsKey(category))
                            {
                                categorizedItems[category] = new List<(string, int, Image)>();
                                currentPagePerCategory[category] = 0;
                            }

                            categorizedItems[category].Add((itemName, itemId, image)); // Store ID along with name and image
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadItems(string searchTerm = "")
        {
            UnclaimedContainer.Controls.Clear(); // Clear previous items

            int yOffset = 20; // Vertical spacing between categories

            foreach (var category in categorizedItems.Keys)
            {
                var categoryPanel = new Guna2Panel
                {
                    BackColor = Color.WhiteSmoke,
                    FillColor = Color.Transparent,
                    Size = new Size(1020, 289),
                    Location = new Point(10, yOffset),
                };

                var categoryLabel = new Label
                {
                    Text = category,
                    Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold),
                    Location = new Point(20, 10),
                    AutoSize = true,
                };

                categoryPanel.Controls.Add(categoryLabel);

                int xOffset = 100;
                int currentPage = currentPagePerCategory[category];
                var items = categorizedItems[category];

                // Filter items based on the search term
                var filteredItems = items.Where(i => i.itemName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                // If there are no items for this category, don't display it
                if (filteredItems.Count == 0)
                {
                    continue;
                }

                int startIndex = currentPage * MaxItemsPerPage;
                int endIndex = Math.Min(startIndex + MaxItemsPerPage, filteredItems.Count);

                for (int i = startIndex; i < endIndex; i++)
                {
                    var itemsPanel = new Guna2Panel
                    {
                        BackColor = Color.Transparent,
                        FillColor = Color.Maroon,
                        BorderRadius = 40,
                        Size = new Size(200, 176),
                        Location = new Point(xOffset, 50),
                    };

                    itemsPanel.ShadowDecoration.Parent = itemsPanel;
                    itemsPanel.ShadowDecoration.Color = Color.Black;
                    itemsPanel.ShadowDecoration.Depth = 10;
                    itemsPanel.ShadowDecoration.Shadow = new Padding(-10, 0, 8, 10);
                    itemsPanel.ShadowDecoration.Enabled = true;
                    itemsPanel.ShadowDecoration.BorderRadius = 30;

                    categoryPanel.Controls.Add(itemsPanel);
                    xOffset += itemsPanel.Width + 20;

                    var descPanel = new Guna2Panel
                    {
                        BackColor = Color.Transparent,
                        FillColor = Color.White,
                        Dock = DockStyle.Bottom,
                        AutoRoundedCorners = true,
                        Size = new Size(207, 38),
                    };
                    itemsPanel.Controls.Add(descPanel);

                    var itemLabel = new Label
                    {
                        Text = filteredItems[i].itemName,
                        Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold),
                        ForeColor = Color.Black,
                        AutoSize = true,
                        Location = new Point(10, 4),
                    };
                    descPanel.Controls.Add(itemLabel);

                    Image image = filteredItems[i].image;

                    var pictureBox = new PictureBox
                    {
                        Image = image,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(200, 200),
                        Dock = DockStyle.Fill,
                    };

                    itemsPanel.Controls.Add(pictureBox);

                    var viewButton = new Guna2Button
                    {
                        Text = "View",
                        Font = new Font("Segoe UI Semibold", 6, FontStyle.Bold),
                        BackColor = Color.Transparent,
                        FillColor = Color.Maroon,
                        ForeColor = Color.White,
                        Size = new Size(60, 30),
                        AutoRoundedCorners = true,
                        Location = new Point(130, 4),
                    };

                    int currentIndex = i;
                    viewButton.Click += (s, e) =>
                    {
                        int selectedItemId = filteredItems[currentIndex].itemID;
                        string selectedItemName = filteredItems[currentIndex].itemName;

                        byte[] selectedPhoto = null;

                        using (var connection = new OleDbConnection(connectionString))
                        {
                            connection.Open();
                            string query = "SELECT photo FROM ReportedItems WHERE ID = @ID AND itemName = @itemName";

                            using (var command = new OleDbCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ID", selectedItemId);
                                command.Parameters.AddWithValue("@itemName", selectedItemName);
                                using (var reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        selectedPhoto = reader["photo"] != DBNull.Value ? (byte[])reader["photo"] : null;
                                    }
                                }
                            }
                        }

                        if (selectedPhoto != null)
                        {
                            UnclaimedTiles detailsForm = new UnclaimedTiles(selectedItemName, selectedPhoto);
                            detailsForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Photo for the selected item could not be retrieved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };

                    descPanel.Controls.Add(viewButton);
                }

                AddNavigationButtons(category, categoryPanel);

                UnclaimedContainer.Controls.Add(categoryPanel);
                yOffset += categoryPanel.Height + 20;
                UnclaimedContainer.AutoScrollMinSize = new Size(0, 0);
            }
        }


        private void AddNavigationButtons(string category, Guna2Panel categoryPanel)
        {
            // Previous Button
            var prevButton = new Guna2CircleButton
            {
                BackColor = Color.Transparent,
                Size = new Size(45, 42),
                Location = new Point(20, (categoryPanel.Height / 2) - 20), // Adjusted location to be inside the panel
                FillColor = Color.White,
                Text = "<",
            };

            prevButton.Click += (s, e) =>
            {
                if (currentPagePerCategory[category] > 0)
                {
                    currentPagePerCategory[category]--;
                    LoadItems();
                }
            };

            prevButton.ShadowDecoration.Parent = prevButton;
            prevButton.ShadowDecoration.Enabled = true;
            prevButton.ShadowDecoration.Depth = 30;
            prevButton.ShadowDecoration.BorderRadius = 6;
            prevButton.ShadowDecoration.Color = Color.Black;
            prevButton.ShadowDecoration.Shadow = new Padding(0, 0, 5, 5);

            // Next Button
            var nextButton = new Guna2CircleButton
            {
                BackColor = Color.Transparent,
                Size = new Size(45, 42),
                Location = new Point(categoryPanel.Width - 70, (categoryPanel.Height / 2) - 20), // Adjusted to fit inside
                FillColor = Color.White,
                Text = ">",
            };

            nextButton.Click += (s, e) =>
            {
                int totalPages = (int)Math.Ceiling(categorizedItems[category].Count / (double)MaxItemsPerPage);
                if (currentPagePerCategory[category] < totalPages - 1)
                {
                    currentPagePerCategory[category]++;
                    LoadItems();
                }
            };

            nextButton.ShadowDecoration.Parent = nextButton;
            nextButton.ShadowDecoration.Enabled = true;
            nextButton.ShadowDecoration.Depth = 30;
            nextButton.ShadowDecoration.BorderRadius = 6;
            nextButton.ShadowDecoration.Color = Color.Black;
            nextButton.ShadowDecoration.Shadow = new Padding(0, 0, 5, 5);

            // Add Buttons to Panel
            categoryPanel.Controls.Add(prevButton);
            categoryPanel.Controls.Add(nextButton);

            // Force buttons to show even with fewer items
            prevButton.Visible = true;
            nextButton.Visible = true;
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadItems(tbxSearch.Text);
        }
    }
}
