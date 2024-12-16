namespace WildcatsWildFind_Admin
{
    partial class AdminLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            lblOnly = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblForgotPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtboxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtboxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            ShowPass = new Guna.UI2.WinForms.Guna2Button();
            HidePass = new Guna.UI2.WinForms.Guna2Button();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            btnMaximize = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Animated = true;
            btnLogin.BorderRadius = 10;
            btnLogin.CustomizableEdges = customizableEdges1;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.Maroon;
            btnLogin.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(585, 690);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogin.Size = new Size(287, 62);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.Click += btnLogin_Click;
            // 
            // lblOnly
            // 
            lblOnly.BackColor = Color.Transparent;
            lblOnly.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOnly.Location = new Point(585, 841);
            lblOnly.Name = "lblOnly";
            lblOnly.Size = new Size(303, 27);
            lblOnly.TabIndex = 3;
            lblOnly.Text = "Only authorized personnel can access.";
            lblOnly.Click += guna2HtmlLabel1_Click;
            // 
            // lblForgotPass
            // 
            lblForgotPass.BackColor = Color.Transparent;
            lblForgotPass.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForgotPass.ForeColor = Color.Maroon;
            lblForgotPass.Location = new Point(660, 894);
            lblForgotPass.Name = "lblForgotPass";
            lblForgotPass.Size = new Size(146, 27);
            lblForgotPass.TabIndex = 4;
            lblForgotPass.Text = "Forgot Password?";
            lblForgotPass.Click += lblForgotPass_Click;
            // 
            // txtboxUsername
            // 
            txtboxUsername.BackColor = Color.Transparent;
            txtboxUsername.BorderColor = Color.Maroon;
            txtboxUsername.BorderRadius = 20;
            txtboxUsername.BorderThickness = 2;
            txtboxUsername.CustomizableEdges = customizableEdges3;
            txtboxUsername.DefaultText = "Username";
            txtboxUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtboxUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtboxUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtboxUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtboxUsername.FocusedState.BorderColor = Color.Maroon;
            txtboxUsername.Font = new Font("Segoe UI", 10.2F);
            txtboxUsername.ForeColor = Color.Black;
            txtboxUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtboxUsername.Location = new Point(477, 407);
            txtboxUsername.Margin = new Padding(3, 5, 3, 5);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.PasswordChar = '\0';
            txtboxUsername.PlaceholderText = "";
            txtboxUsername.SelectedText = "";
            txtboxUsername.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtboxUsername.Size = new Size(498, 76);
            txtboxUsername.TabIndex = 5;
            txtboxUsername.TextOffset = new Point(35, 0);
            txtboxUsername.TextChanged += txtboxUsername_TextChanged;
            // 
            // txtboxPassword
            // 
            txtboxPassword.BackColor = Color.Transparent;
            txtboxPassword.BorderColor = Color.Maroon;
            txtboxPassword.BorderRadius = 20;
            txtboxPassword.BorderThickness = 2;
            txtboxPassword.CustomizableEdges = customizableEdges5;
            txtboxPassword.DefaultText = "Password";
            txtboxPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtboxPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtboxPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtboxPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtboxPassword.FocusedState.BorderColor = Color.Maroon;
            txtboxPassword.Font = new Font("Segoe UI", 10.2F);
            txtboxPassword.ForeColor = Color.Black;
            txtboxPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtboxPassword.Location = new Point(477, 534);
            txtboxPassword.Margin = new Padding(3, 5, 3, 5);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.PasswordChar = '\0';
            txtboxPassword.PlaceholderText = "";
            txtboxPassword.SelectedText = "";
            txtboxPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtboxPassword.Size = new Size(498, 76);
            txtboxPassword.TabIndex = 6;
            txtboxPassword.TextOffset = new Point(35, 0);
            txtboxPassword.TextChanged += txtboxPassword_TextChanged;
            // 
            // ShowPass
            // 
            ShowPass.BackColor = Color.White;
            ShowPass.BackgroundImage = Properties.Resources.eye;
            ShowPass.BackgroundImageLayout = ImageLayout.Zoom;
            ShowPass.CustomizableEdges = customizableEdges7;
            ShowPass.DisabledState.BorderColor = Color.DarkGray;
            ShowPass.DisabledState.CustomBorderColor = Color.DarkGray;
            ShowPass.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ShowPass.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ShowPass.FillColor = Color.Transparent;
            ShowPass.Font = new Font("Segoe UI", 9F);
            ShowPass.ForeColor = Color.White;
            ShowPass.Location = new Point(926, 557);
            ShowPass.Name = "ShowPass";
            ShowPass.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ShowPass.Size = new Size(34, 34);
            ShowPass.TabIndex = 7;
            ShowPass.Click += ShowPass_Click;
            // 
            // HidePass
            // 
            HidePass.BackColor = Color.White;
            HidePass.BackgroundImage = Properties.Resources.eye__1_;
            HidePass.BackgroundImageLayout = ImageLayout.Zoom;
            HidePass.CustomizableEdges = customizableEdges9;
            HidePass.DisabledState.BorderColor = Color.DarkGray;
            HidePass.DisabledState.CustomBorderColor = Color.DarkGray;
            HidePass.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            HidePass.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            HidePass.FillColor = Color.Transparent;
            HidePass.FocusedColor = Color.Transparent;
            HidePass.Font = new Font("Segoe UI", 9F);
            HidePass.ForeColor = Color.White;
            HidePass.HoverState.FillColor = Color.Transparent;
            HidePass.Location = new Point(926, 557);
            HidePass.Name = "HidePass";
            HidePass.ShadowDecoration.CustomizableEdges = customizableEdges10;
            HidePass.Size = new Size(34, 34);
            HidePass.TabIndex = 8;
            HidePass.Click += HidePass_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = Properties.Resources.close__4_;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.CustomizableEdges = customizableEdges11;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Transparent;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1406, 4);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnExit.Size = new Size(31, 26);
            btnExit.TabIndex = 9;
            btnExit.Click += btnExit_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundImage = Properties.Resources.minimize_sign;
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.CustomizableEdges = customizableEdges13;
            btnMinimize.DisabledState.BorderColor = Color.DarkGray;
            btnMinimize.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMinimize.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMinimize.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMinimize.FillColor = Color.Transparent;
            btnMinimize.Font = new Font("Segoe UI", 9F);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1331, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnMinimize.Size = new Size(23, 26);
            btnMinimize.TabIndex = 10;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.BackgroundImage = Properties.Resources.maximize__2_;
            btnMaximize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaximize.CustomizableEdges = customizableEdges15;
            btnMaximize.DisabledState.BorderColor = Color.DarkGray;
            btnMaximize.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMaximize.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMaximize.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMaximize.FillColor = Color.Transparent;
            btnMaximize.Font = new Font("Segoe UI", 9F);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1375, 4);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnMaximize.Size = new Size(23, 26);
            btnMaximize.TabIndex = 11;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 1024);
            Controls.Add(btnMaximize);
            Controls.Add(btnMinimize);
            Controls.Add(btnExit);
            Controls.Add(HidePass);
            Controls.Add(ShowPass);
            Controls.Add(lblForgotPass);
            Controls.Add(lblOnly);
            Controls.Add(btnLogin);
            Controls.Add(txtboxUsername);
            Controls.Add(txtboxPassword);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOnly;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblForgotPass;
        private Guna.UI2.WinForms.Guna2TextBox txtboxUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtboxPassword;
        private Guna.UI2.WinForms.Guna2Button ShowPass;
        private Guna.UI2.WinForms.Guna2Button HidePass;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnMaximize;
    }
}
