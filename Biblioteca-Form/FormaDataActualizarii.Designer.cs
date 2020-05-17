namespace Biblioteca_Form
{
    partial class FormaDataActualizarii
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mdtInceput = new MetroFramework.Controls.MetroDateTime();
            this.mdtSfarsit = new MetroFramework.Controls.MetroDateTime();
            this.mtOK = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(38, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Data de început";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(38, 140);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Data de sfârșit";
            // 
            // mdtInceput
            // 
            this.mdtInceput.Location = new System.Drawing.Point(227, 93);
            this.mdtInceput.MinimumSize = new System.Drawing.Size(0, 30);
            this.mdtInceput.Name = "mdtInceput";
            this.mdtInceput.Size = new System.Drawing.Size(249, 30);
            this.mdtInceput.TabIndex = 2;
            // 
            // mdtSfarsit
            // 
            this.mdtSfarsit.Location = new System.Drawing.Point(227, 140);
            this.mdtSfarsit.MinimumSize = new System.Drawing.Size(0, 30);
            this.mdtSfarsit.Name = "mdtSfarsit";
            this.mdtSfarsit.Size = new System.Drawing.Size(249, 30);
            this.mdtSfarsit.TabIndex = 3;
            // 
            // mtOK
            // 
            this.mtOK.ActiveControl = null;
            this.mtOK.Location = new System.Drawing.Point(216, 193);
            this.mtOK.Name = "mtOK";
            this.mtOK.Size = new System.Drawing.Size(104, 40);
            this.mtOK.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtOK.TabIndex = 4;
            this.mtOK.Text = "OK";
            this.mtOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtOK.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtOK.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtOK.UseSelectable = true;
            this.mtOK.UseStyleColors = true;
            this.mtOK.Click += new System.EventHandler(this.mtOK_Click);
            // 
            // FormaDataActualizarii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 265);
            this.Controls.Add(this.mtOK);
            this.Controls.Add(this.mdtSfarsit);
            this.Controls.Add(this.mdtInceput);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormaDataActualizarii";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Caută cărțile după data actualizării";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime mdtInceput;
        private MetroFramework.Controls.MetroDateTime mdtSfarsit;
        private MetroFramework.Controls.MetroTile mtOK;
    }
}