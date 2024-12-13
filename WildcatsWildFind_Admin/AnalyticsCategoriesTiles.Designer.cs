namespace WildcatsWildFind_Admin
{
    partial class AnalyticsCategoriesTiles
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
            panel1 = new Panel();
            label1 = new Label();
            guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(8, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 18);
            label1.TabIndex = 1;
            label1.Text = "Category Name";
            // 
            // guna2ProgressBar1
            // 
            guna2ProgressBar1.BorderRadius = 10;
            guna2ProgressBar1.CustomizableEdges = customizableEdges1;
            guna2ProgressBar1.Location = new Point(6, 32);
            guna2ProgressBar1.Name = "guna2ProgressBar1";
            guna2ProgressBar1.ProgressColor = Color.Maroon;
            guna2ProgressBar1.ProgressColor2 = Color.FromArgb(255, 255, 128);
            guna2ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ProgressBar1.Size = new Size(252, 25);
            guna2ProgressBar1.TabIndex = 2;
            guna2ProgressBar1.Text = "guna2ProgressBar1";
            guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // AnalyticsCategoriesTiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 71);
            Controls.Add(guna2ProgressBar1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnalyticsCategoriesTiles";
            Text = "AnalyticsCategoriesTiles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
    }
}