namespace Projekt
{
    partial class Start
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
            this.tabeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.samochódToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wypożyczenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wypożyczenieSamochoduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabeleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabeleToolStripMenuItem
            // 
            this.tabeleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klientToolStripMenuItem,
            this.samochódToolStripMenuItem,
            this.wypożyczenieToolStripMenuItem,
            this.adresToolStripMenuItem,
            this.wypożyczenieSamochoduToolStripMenuItem});
            this.tabeleToolStripMenuItem.Name = "tabeleToolStripMenuItem";
            this.tabeleToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tabeleToolStripMenuItem.Text = "Tabele";
            this.tabeleToolStripMenuItem.Click += new System.EventHandler(this.tabeleToolStripMenuItem_Click);
            // 
            // klientToolStripMenuItem
            // 
            this.klientToolStripMenuItem.Name = "klientToolStripMenuItem";
            this.klientToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.klientToolStripMenuItem.Text = "Klient";
            this.klientToolStripMenuItem.Click += new System.EventHandler(this.klientToolStripMenuItem_Click);
            // 
            // samochódToolStripMenuItem
            // 
            this.samochódToolStripMenuItem.Name = "samochódToolStripMenuItem";
            this.samochódToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.samochódToolStripMenuItem.Text = "Samochód";
            this.samochódToolStripMenuItem.Click += new System.EventHandler(this.samochódToolStripMenuItem_Click);
            // 
            // wypożyczenieToolStripMenuItem
            // 
            this.wypożyczenieToolStripMenuItem.Name = "wypożyczenieToolStripMenuItem";
            this.wypożyczenieToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.wypożyczenieToolStripMenuItem.Text = "Wypożyczenie";
            this.wypożyczenieToolStripMenuItem.Click += new System.EventHandler(this.wypożyczenieToolStripMenuItem_Click);
            // 
            // adresToolStripMenuItem
            // 
            this.adresToolStripMenuItem.Name = "adresToolStripMenuItem";
            this.adresToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.adresToolStripMenuItem.Text = "Adres";
            this.adresToolStripMenuItem.Click += new System.EventHandler(this.adresToolStripMenuItem_Click);
            // 
            // wypożyczenieSamochoduToolStripMenuItem
            // 
            this.wypożyczenieSamochoduToolStripMenuItem.Name = "wypożyczenieSamochoduToolStripMenuItem";
            this.wypożyczenieSamochoduToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.wypożyczenieSamochoduToolStripMenuItem.Text = "Wypożyczenie samochodu";
            this.wypożyczenieSamochoduToolStripMenuItem.Click += new System.EventHandler(this.wypożyczenieSamochoduToolStripMenuItem_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt.Properties.Resources._51366768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Start";
            this.Text = "Projekt";
            this.Load += new System.EventHandler(this.Start_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tabeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem samochódToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wypożyczenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wypożyczenieSamochoduToolStripMenuItem;
    }
}

