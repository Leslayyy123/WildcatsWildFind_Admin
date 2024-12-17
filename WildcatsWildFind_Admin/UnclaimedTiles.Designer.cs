namespace WildcatsWildFind_Admin
{
    partial class UnclaimedTiles
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pbxItem = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblName = new Label();
            label6 = new Label();
            lblDateLost = new Label();
            label8 = new Label();
            lblDesc = new Label();
            lblClose = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            itemLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxItem).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbxItem
            // 
            pbxItem.Location = new Point(-1, -1);
            pbxItem.Name = "pbxItem";
            pbxItem.Size = new Size(289, 155);
            pbxItem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxItem.TabIndex = 0;
            pbxItem.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 168);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 1;
            label1.Text = "INFO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 211);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ControlDark;
            lblName.Location = new Point(72, 213);
            lblName.Name = "lblName";
            lblName.Size = new Size(57, 18);
            lblName.TabIndex = 3;
            lblName.Text = "Full Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 239);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 6;
            label6.Text = "Date Lost:";
            // 
            // lblDateLost
            // 
            lblDateLost.AutoSize = true;
            lblDateLost.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateLost.ForeColor = SystemColors.ControlDark;
            lblDateLost.Location = new Point(94, 241);
            lblDateLost.Name = "lblDateLost";
            lblDateLost.Size = new Size(54, 18);
            lblDateLost.TabIndex = 7;
            lblDateLost.Text = "Date Lost";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 292);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 8;
            label8.Text = "Description:";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Bahnschrift Condensed", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.ForeColor = SystemColors.ControlDark;
            lblDesc.Location = new Point(72, 312);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(202, 80);
            lblDesc.TabIndex = 9;
            lblDesc.Text = "and completing requests efficiently, ensuring \r\ntimely communication andupdates. With cus\r\ntomizable featuresand robust support, You\r\nrRequest y.\r\n\r\n";
            // 
            // lblClose
            // 
            lblClose.BackColor = Color.Transparent;
            lblClose.BorderRadius = 15;
            lblClose.CustomizableEdges = customizableEdges1;
            lblClose.DisabledState.BorderColor = Color.DarkGray;
            lblClose.DisabledState.CustomBorderColor = Color.DarkGray;
            lblClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lblClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lblClose.FillColor = Color.Maroon;
            lblClose.Font = new Font("Segoe UI", 9F);
            lblClose.ForeColor = Color.White;
            lblClose.Location = new Point(138, 392);
            lblClose.Name = "lblClose";
            lblClose.ShadowDecoration.BorderRadius = 15;
            lblClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            lblClose.ShadowDecoration.Depth = 20;
            lblClose.ShadowDecoration.Enabled = true;
            lblClose.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            lblClose.Size = new Size(120, 31);
            lblClose.TabIndex = 10;
            lblClose.Text = "Close";
            lblClose.Click += lblClose_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 10;
            guna2Panel1.Controls.Add(itemLabel);
            customizableEdges3.BottomRight = false;
            customizableEdges3.TopLeft = false;
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.FillColor = Color.FromArgb(240, 181, 4);
            guna2Panel1.Location = new Point(2, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(113, 25);
            guna2Panel1.TabIndex = 11;
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemLabel.Location = new Point(22, 1);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(56, 20);
            itemLabel.TabIndex = 12;
            itemLabel.Text = "Laptop";
            // 
            // UnclaimedTiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 435);
            Controls.Add(guna2Panel1);
            Controls.Add(lblClose);
            Controls.Add(lblDesc);
            Controls.Add(label8);
            Controls.Add(lblDateLost);
            Controls.Add(label6);
            Controls.Add(lblName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbxItem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UnclaimedTiles";
            Text = "RetrievalTiles";
            ((System.ComponentModel.ISupportInitialize)pbxItem).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxItem;
        private Label label1;
        private Label label2;
        private Label lblName;
        private Label label6;
        private Label lblDateLost;
        private Label label8;
        private Label lblDesc;
        private Guna.UI2.WinForms.Guna2Button lblClose;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label itemLabel;
    }
}