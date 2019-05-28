namespace ISO27001Tools.GUI
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localAdminTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountProcessToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountProcessToolStripMenuItem
            // 
            this.accountProcessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localAdminTestToolStripMenuItem});
            this.accountProcessToolStripMenuItem.Name = "accountProcessToolStripMenuItem";
            this.accountProcessToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.accountProcessToolStripMenuItem.Text = "Account İşlemleri";
            // 
            // localAdminTestToolStripMenuItem
            // 
            this.localAdminTestToolStripMenuItem.Name = "localAdminTestToolStripMenuItem";
            this.localAdminTestToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.localAdminTestToolStripMenuItem.Text = "Local Admin Sorgusu";
            this.localAdminTestToolStripMenuItem.Click += new System.EventHandler(this.localAdminTestToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 777);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "ISO27001 Tools";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localAdminTestToolStripMenuItem;
    }
}

