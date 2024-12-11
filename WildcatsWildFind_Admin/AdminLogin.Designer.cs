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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            btnUsername = new Guna.UI2.WinForms.Guna2Button();
            btnPassword = new Guna.UI2.WinForms.Guna2Button();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            lblOnly = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblForgotPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // btnUsername
            // 
            btnUsername.BackColor = Color.Transparent;
            btnUsername.BorderColor = Color.Maroon;
            btnUsername.BorderRadius = 20;
            btnUsername.BorderThickness = 2;
            btnUsername.CustomizableEdges = customizableEdges1;
            btnUsername.DisabledState.BorderColor = Color.DarkGray;
            btnUsername.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUsername.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUsername.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUsername.FillColor = Color.White;
            btnUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsername.ForeColor = Color.Black;
            btnUsername.Location = new Point(477, 407);
            btnUsername.Name = "btnUsername";
            btnUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnUsername.Size = new Size(498, 76);
            btnUsername.TabIndex = 0;
            btnUsername.Text = "       Username";
            btnUsername.TextAlign = HorizontalAlignment.Left;
            // 
            // btnPassword
            // 
            btnPassword.BackColor = Color.Transparent;
            btnPassword.BorderColor = Color.Maroon;
            btnPassword.BorderRadius = 20;
            btnPassword.BorderThickness = 2;
            btnPassword.CustomizableEdges = customizableEdges3;
            btnPassword.DisabledState.BorderColor = Color.DarkGray;
            btnPassword.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPassword.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPassword.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPassword.FillColor = Color.White;
            btnPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPassword.ForeColor = Color.Black;
            btnPassword.Location = new Point(477, 534);
            btnPassword.Name = "btnPassword";
            btnPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPassword.Size = new Size(498, 76);
            btnPassword.TabIndex = 1;
            btnPassword.Text = "       Password";
            btnPassword.TextAlign = HorizontalAlignment.Left;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 10;
            btnLogin.CustomizableEdges = customizableEdges5;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.Maroon;
            btnLogin.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(585, 690);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogin.Size = new Size(287, 62);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
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
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 1024);
            Controls.Add(lblForgotPass);
            Controls.Add(lblOnly);
            Controls.Add(btnLogin);
            Controls.Add(btnPassword);
            Controls.Add(btnUsername);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnUsername;
        private Guna.UI2.WinForms.Guna2Button btnPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOnly;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblForgotPass;
    }
}
