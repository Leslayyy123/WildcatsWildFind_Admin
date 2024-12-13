namespace WildcatsWildFind_Admin
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();

            txtboxUsername.Text = "Username";
            txtboxUsername.ForeColor = Color.Black;

            txtboxPassword.Text = "Password";
            txtboxPassword.ForeColor = Color.Black;

            txtboxUsername.Enter += TxtboxUsername_Enter;
            txtboxUsername.Leave += TxtboxUsername_Leave;

            txtboxPassword.Enter += TxtboxPassword_Enter;
            txtboxPassword.Leave += TxtboxPassword_Leave;

            ShowPass.Visible = true;
            HidePass.Visible = false;
        }

        private void TxtboxUsername_Enter(object sender, EventArgs e)
        {

            if (txtboxUsername.Text == "Username")
            {
                txtboxUsername.Text = "";
                txtboxUsername.ForeColor = Color.Black;
            }
        }

        private void TxtboxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxUsername.Text))
            {
                txtboxUsername.Text = "Username";
                txtboxUsername.ForeColor = Color.Black;
            }
        }

        private void TxtboxPassword_Enter(object sender, EventArgs e)
        {
            if (txtboxPassword.Text == "Password")
            {
                txtboxPassword.Text = "";
                txtboxPassword.ForeColor = Color.Black;
                txtboxPassword.UseSystemPasswordChar = true;
            }
        }

        private void TxtboxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxPassword.Text))
            {
                txtboxPassword.Text = "Password";
                txtboxPassword.ForeColor = Color.Black;
                txtboxPassword.UseSystemPasswordChar = false;
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide(); 
        }

        private void ShowPass_Click(object sender, EventArgs e)
        {
            txtboxPassword.UseSystemPasswordChar = false;
            ShowPass.Visible = false;
            HidePass.Visible = true;
        }

        private void HidePass_Click(object sender, EventArgs e)
        {
            txtboxPassword.UseSystemPasswordChar = true;
            ShowPass.Visible = true;
            HidePass.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal; 
            }
            else
            {
                this.WindowState = FormWindowState.Maximized; 
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
