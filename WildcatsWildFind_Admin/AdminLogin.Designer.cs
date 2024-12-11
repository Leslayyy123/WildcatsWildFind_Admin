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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            btnUsername = new Guna.UI2.WinForms.Guna2Button();
            btnPassword = new Guna.UI2.WinForms.Guna2Button();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            lblOnly = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblForgotPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            cmbx1 = new Controls.cmbx();
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
            // guna2TextBox3
            // 
            guna2TextBox3.BackColor = Color.Transparent;
            guna2TextBox3.BorderRadius = 15;
            guna2TextBox3.CustomizableEdges = customizableEdges7;
            guna2TextBox3.DefaultText = "";
            guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.FillColor = Color.FromArgb(241, 234, 234);
            guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Font = new Font("Segoe UI", 9F);
            guna2TextBox3.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Location = new Point(232, 327);
            guna2TextBox3.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox3.Name = "guna2TextBox3";
            guna2TextBox3.PasswordChar = '\0';
            guna2TextBox3.PlaceholderText = "";
            guna2TextBox3.SelectedText = "";
            guna2TextBox3.ShadowDecoration.BorderRadius = 15;
            guna2TextBox3.ShadowDecoration.Color = Color.DimGray;
            guna2TextBox3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2TextBox3.ShadowDecoration.Depth = 15;
            guna2TextBox3.ShadowDecoration.Enabled = true;
            guna2TextBox3.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            guna2TextBox3.Size = new Size(258, 61);
            guna2TextBox3.TabIndex = 5;
            // 
            // cmbx1
            // 
            cmbx1.BackColor = Color.FromArgb(241, 234, 234);
            cmbx1.BorderColor = Color.MediumSeaGreen;
            cmbx1.BorderSize = 0;
            cmbx1.DropDownStyle = ComboBoxStyle.DropDown;
            cmbx1.Font = new Font("Segoe UI", 10F);
            cmbx1.ForeColor = Color.DimGray;
            cmbx1.IconColor = Color.Maroon;
            cmbx1.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbx1.ListTextColor = Color.DimGray;
            cmbx1.Location = new Point(276, 342);
            cmbx1.MinimumSize = new Size(200, 30);
            cmbx1.Name = "cmbx1";
            cmbx1.Size = new Size(200, 30);
            cmbx1.TabIndex = 6;
            cmbx1.Texts = "";
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 1024);
            Controls.Add(cmbx1);
            Controls.Add(guna2TextBox3);
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
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Controls.cmbx cmbx1;
    }
}
