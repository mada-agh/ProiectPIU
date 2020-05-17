namespace Biblioteca_Form
{
    partial class FormaCartiDisponibile
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
            this.mlblCartiDisponible = new MetroFramework.Controls.MetroLabel();
            this.mtOK = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mlblCartiDisponible
            // 
            this.mlblCartiDisponible.AutoSize = true;
            this.mlblCartiDisponible.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblCartiDisponible.Location = new System.Drawing.Point(126, 79);
            this.mlblCartiDisponible.Name = "mlblCartiDisponible";
            this.mlblCartiDisponible.Size = new System.Drawing.Size(0, 0);
            this.mlblCartiDisponible.TabIndex = 0;
            this.mlblCartiDisponible.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // mtOK
            // 
            this.mtOK.ActiveControl = null;
            this.mtOK.Location = new System.Drawing.Point(90, 131);
            this.mtOK.Name = "mtOK";
            this.mtOK.Size = new System.Drawing.Size(104, 40);
            this.mtOK.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtOK.TabIndex = 1;
            this.mtOK.Text = "OK";
            this.mtOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtOK.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtOK.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtOK.UseSelectable = true;
            this.mtOK.UseStyleColors = true;
            this.mtOK.Click += new System.EventHandler(this.mtOK_Click);
            // 
            // FormaCartiDisponibile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 187);
            this.Controls.Add(this.mtOK);
            this.Controls.Add(this.mlblCartiDisponible);
            this.Name = "FormaCartiDisponibile";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Cărți disponibile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlblCartiDisponible;
        private MetroFramework.Controls.MetroTile mtOK;
    }
}