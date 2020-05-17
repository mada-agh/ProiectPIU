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
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
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
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(484, 126);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(294, 259);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Cititori și imprumuturi";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 553);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.mtCarti);
            this.Name = "MainMenu";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Meniu Biblioteca";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCarti;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}