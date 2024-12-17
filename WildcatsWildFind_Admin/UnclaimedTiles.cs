using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WildcatsWildFind_Admin
{
    public partial class UnclaimedTiles : Form
    {
        private string _itemName;
        private byte[] _itemPhoto;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\WildcatsWildFind_Admin\WildcatsWildFind_Admin\Database\WildFind.mdb;Persist Security Info=False;";

        // Variables for dragging the form
        private bool isMouseDown = false;
        private Point lastLocation;

        public UnclaimedTiles(string itemName, byte[] itemPhoto)
        {
            InitializeComponent();
            _itemName = itemName;
            _itemPhoto = itemPhoto;

            LoadItemDetails();
            InitializeDragEvents();
        }

        // Method to allow dragging of the form
        private void RetrievalTiles_MouseDown(object sender, MouseEventArgs e)
        {
            // Set the flag when the mouse button is pressed
            isMouseDown = true;
            // Capture the current mouse position
            lastLocation = e.Location;
        }

        private void RetrievalTiles_MouseMove(object sender, MouseEventArgs e)
        {
            // Move the form when the mouse is moved and the flag is set
            if (isMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y
                );
                this.Update();
            }
        }

        private void RetrievalTiles_MouseUp(object sender, MouseEventArgs e)
        {
            // Reset the flag when the mouse button is released
            isMouseDown = false;
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
                        command.Parameters.AddWithValue("@itemName", _itemName);

                        using (var reader = command.ExecuteReader())
                        {
                            bool isMatchFound = false;

                            while (reader.Read())
                            {
                                byte[] dbPhoto = reader["photo"] != DBNull.Value ? (byte[])reader["photo"] : null;

                                if (dbPhoto != null && ByteArraysMatch(_itemPhoto, dbPhoto))
                                {
                                    // Populate form details if a match is found
                                    itemLabel.Text = _itemName;
                                    lblName.Text = reader["fullName"].ToString();
                                    lblDateLost.Text = Convert.ToDateTime(reader["dateFound"]).ToString("MM/dd/yyyy");
                                    lblDesc.Text = reader["itemDescription"].ToString();

                                    using (var ms = new MemoryStream(dbPhoto))
                                    {
                                        pbxItem.Image = Image.FromStream(ms);
                                    }

                                    isMatchFound = true;
                                    break;
                                }
                            }

                            if (!isMatchFound)
                            {
                                MessageBox.Show("No matching item found for the provided OLE Object.", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        // Compare two byte arrays
        private bool ByteArraysMatch(byte[] array1, byte[] array2)
        {
            if (array1 == null || array2 == null || array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }
            return true;
        }

        // Add event handlers to the form
        private void InitializeDragEvents()
        {
            this.MouseDown += new MouseEventHandler(RetrievalTiles_MouseDown);
            this.MouseMove += new MouseEventHandler(RetrievalTiles_MouseMove);
            this.MouseUp += new MouseEventHandler(RetrievalTiles_MouseUp);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
