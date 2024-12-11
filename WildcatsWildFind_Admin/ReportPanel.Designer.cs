namespace WildcatsWildFind_Admin
{
    partial class ReportPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BackColor = Color.Transparent;
            guna2TextBox1.BorderColor = Color.FromArgb(229, 171, 0);
            guna2TextBox1.BorderRadius = 30;
            customizableEdges3.BottomLeft = false;
            customizableEdges3.TopRight = false;
            guna2TextBox1.CustomizableEdges = customizableEdges3;
            guna2TextBox1.DefaultText = "REPORT FOUND ITEM";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = Color.FromArgb(229, 171, 0);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2TextBox1.ForeColor = Color.Maroon;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(363, 27);
            guna2TextBox1.Margin = new Padding(5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.BorderRadius = 30;
            guna2TextBox1.ShadowDecoration.Color = Color.Gray;
            customizableEdges4.BottomLeft = false;
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox1.ShadowDecoration.Depth = 15;
            guna2TextBox1.ShadowDecoration.Enabled = true;
            guna2TextBox1.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            guna2TextBox1.Size = new Size(416, 64);
            guna2TextBox1.TabIndex = 1;
            guna2TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // ReportPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
//            BackgroundImage = Properties.Resources.Admin___Report_Found_Item__Tarunga_lang_huhu___1_;
            ClientSize = new Size(1138, 914);
            Controls.Add(guna2TextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportPanel";
            Text = "ReportPanel";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}