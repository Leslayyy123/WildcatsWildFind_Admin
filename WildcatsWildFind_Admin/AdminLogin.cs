using System.Data.OleDb;

namespace WildcatsWildFind_Admin
{
    public partial class AdminLogin : Form
    {
        OleDbConnection myConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\WildcatsWildFind_Admin\WildcatsWildFind_Admin\Database\WildFind.mdb;Persist Security Info=False;");
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
            string query = "SELECT COUNT(*) FROM AdminInfo WHERE adminUser = @adminUser AND password = @password";

            try
            {
                myConn.Open();
                using (OleDbCommand command = new OleDbCommand(query, myConn))
                {
                    command.Parameters.AddWithValue("@adminUser", txtboxUsername.Text);
                    command.Parameters.AddWithValue("@password", txtboxPassword.Text);

                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConn.Close();
            }
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

        private void lblForgotPass_Click(object sender, EventArgs e)
        {

        }
    }
}
