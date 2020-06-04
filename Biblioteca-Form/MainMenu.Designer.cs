namespace Biblioteca_Form
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.mtCarti = new MetroFramework.Controls.MetroTile();
            this.mtCititori = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtCarti
            // 
            this.mtCarti.ActiveControl = null;
            this.mtCarti.Location = new System.Drawing.Point(85, 126);
            this.mtCarti.Name = "mtCarti";
            this.mtCarti.Size = new System.Drawing.Size(294, 259);
            this.mtCarti.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtCarti.TabIndex = 0;
            this.mtCarti.Text = "Administrare cărți";
            this.mtCarti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCarti.TileImage = ((System.Drawing.Image)(resources.GetObject("mtCarti.TileImage")));
            this.mtCarti.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCarti.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCarti.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCarti.UseSelectable = true;
            this.mtCarti.UseTileImage = true;
            this.mtCarti.Click += new System.EventHandler(this.mtCarti_Click);
            // 
            // mtCititori
            // 
            this.mtCititori.ActiveControl = null;
            this.mtCititori.Location = new System.Drawing.Point(484, 126);
            this.mtCititori.Name = "mtCititori";
            this.mtCititori.Size = new System.Drawing.Size(294, 259);
            this.mtCititori.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtCititori.TabIndex = 1;
            this.mtCititori.Text = "Cititori și împrumuturi";
            this.mtCititori.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCititori.TileImage = ((System.Drawing.Image)(resources.GetObject("mtCititori.TileImage")));
            this.mtCititori.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCititori.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCititori.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCititori.UseSelectable = true;
            this.mtCititori.UseTileImage = true;
            this.mtCititori.Click += new System.EventHandler(this.mtCititori_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 553);
            this.Controls.Add(this.mtCititori);
            this.Controls.Add(this.mtCarti);
            this.Name = "MainMenu";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Meniu Biblioteca";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCarti;
        private MetroFramework.Controls.MetroTile mtCititori;
    }
}