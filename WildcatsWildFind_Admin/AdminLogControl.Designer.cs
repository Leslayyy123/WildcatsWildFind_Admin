namespace WildcatsWildFind_Admin
{
    partial class AdminLogControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblItem = new Label();
            lblTime = new Label();
            lblName = new Label();
            btnAction = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(lblItem);
            guna2Panel1.Controls.Add(lblTime);
            guna2Panel1.Controls.Add(lblName);
            guna2Panel1.Controls.Add(btnAction);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(773, 53);
            guna2Panel1.TabIndex = 41;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItem.ForeColor = Color.Gray;
            lblItem.Location = new Point(458, 13);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(48, 21);
            lblItem.TabIndex = 39;
            lblItem.Text = "Item";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Gray;
            lblTime.Location = new Point(41, 13);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(159, 21);
            lblTime.TabIndex = 5;
            lblTime.Text = "12/16/24 10:00 AM";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Gray;
            lblName.Location = new Point(264, 13);
            lblName.Name = "lblName";
            lblName.Size = new Size(113, 21);
            lblName.TabIndex = 17;
            lblName.Text = "Jaspher Siloy";
            // 
            // btnAction
            // 
            btnAction.AutoRoundedCorners = true;
            btnAction.BackColor = Color.Transparent;
            btnAction.BorderRadius = 14;
            btnAction.CustomizableEdges = customizableEdges1;
            btnAction.DisabledState.BorderColor = Color.DarkGray;
            btnAction.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAction.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAction.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAction.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAction.FillColor = Color.FromArgb(84, 4, 4);
            btnAction.FillColor2 = Color.FromArgb(186, 9, 9);
            btnAction.Font = new Font("Segoe UI", 9F);
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(587, 10);
            btnAction.Name = "btnAction";
            btnAction.ShadowDecoration.BorderRadius = 20;
            btnAction.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAction.ShadowDecoration.Depth = 15;
            btnAction.ShadowDecoration.Enabled = true;
            btnAction.ShadowDecoration.Shadow = new Padding(0, 0, 10, 8);
            btnAction.Size = new Size(150, 31);
            btnAction.TabIndex = 36;
            btnAction.Text = "Approve";
            // 
            // AdminLogControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel1);
            Name = "AdminLogControl";
            Size = new Size(773, 53);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Label lblItem;
        public Label lblTime;
        public Label lblName;
        public Guna.UI2.WinForms.Guna2GradientButton btnAction;
    }
}
