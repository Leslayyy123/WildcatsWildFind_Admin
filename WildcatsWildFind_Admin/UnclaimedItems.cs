namespace WildcatsWildFind_Admin
{
    public partial class UnclaimedItems : Form
    {
        public UnclaimedItems()
        {
            InitializeComponent();

            tbxSearch.Text = "Search";
            tbxSearch.ForeColor = Color.Gray;

            tbxSearch.Enter += TbxSearch_Enter;
            tbxSearch.Leave += TbxSearch_Leave;
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


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
