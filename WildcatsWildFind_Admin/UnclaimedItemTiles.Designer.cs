namespace WildcatsWildFind_Admin
{
    partial class UnclaimedItemTiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnclaimedItemTiles));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pbxItem = new PictureBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblDate = new Label();
            lblName = new Label();
            label2 = new Label();
            lblCat = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxItem).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbxItem
            // 
            pbxItem.BackgroundImage = (Image)resources.GetObject("pbxItem.BackgroundImage");
            pbxItem.Image = (Image)resources.GetObject("pbxItem.Image");
            pbxItem.Location = new Point(-1, -1);
            pbxItem.Name = "pbxItem";
            pbxItem.Size = new Size(336, 201);
            pbxItem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxItem.TabIndex = 0;
            pbxItem.TabStop = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.Controls.Add(lblDate);
            guna2Panel1.Controls.Add(lblName);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(lblCat);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.FillColor = Color.Maroon;
            guna2Panel1.Location = new Point(12, 125);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(323, 63);
            guna2Panel1.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.ControlLightLight;
            lblDate.Location = new Point(239, 36);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(74, 17);
            lblDate.TabIndex = 5;
            lblDate.Text = "12/12/2024";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ControlLightLight;
            lblName.Location = new Point(145, 8);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 23);
            lblName.TabIndex = 4;
            lblName.Text = "Iphone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(145, 36);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 3;
            label2.Text = "Date Reported:";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCat.ForeColor = SystemColors.ControlLightLight;
            lblCat.Location = new Point(18, 17);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(104, 25);
            lblCat.TabIndex = 2;
            lblCat.Text = "Electronics";
            // 
            // UnclaimedItemTiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 200);
            Controls.Add(guna2Panel1);
            Controls.Add(pbxItem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UnclaimedItemTiles";
            Text = "UnclaimedItemTiles";
            ((System.ComponentModel.ISupportInitialize)pbxItem).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxItem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblCat;
        private Label label2;
        private Label lblDate;
        private Label lblName;
    }
}