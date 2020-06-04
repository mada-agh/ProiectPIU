namespace Biblioteca_Form
{
    partial class FormaImprumutaCarte
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
            this.mlblInfo = new MetroFramework.Controls.MetroLabel();
            this.mtImprumuta = new MetroFramework.Controls.MetroTile();
            this.mtxtPrenume = new MetroFramework.Controls.MetroTextBox();
            this.mtxtNume = new MetroFramework.Controls.MetroTextBox();
            this.mlblPrenume = new MetroFramework.Controls.MetroLabel();
            this.mlblNume = new MetroFramework.Controls.MetroLabel();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mlblInfo
            // 
            this.mlblInfo.AutoSize = true;
            this.mlblInfo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblInfo.Location = new System.Drawing.Point(81, 181);
            this.mlblInfo.Name = "mlblInfo";
            this.mlblInfo.Size = new System.Drawing.Size(0, 0);
            this.mlblInfo.Style = MetroFramework.MetroColorStyle.Brown;
            this.mlblInfo.TabIndex = 59;
            this.mlblInfo.UseStyleColors = true;
            // 
            // mtImprumuta
            // 
            this.mtImprumuta.ActiveControl = null;
            this.mtImprumuta.Location = new System.Drawing.Point(81, 232);
            this.mtImprumuta.Name = "mtImprumuta";
            this.mtImprumuta.Size = new System.Drawing.Size(375, 74);
            this.mtImprumuta.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtImprumuta.TabIndex = 58;
            this.mtImprumuta.Text = "Împrumută";
            this.mtImprumuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtImprumuta.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtImprumuta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtImprumuta.UseSelectable = true;
            this.mtImprumuta.Click += new System.EventHandler(this.mtImprumuta_Click);
            // 
            // mtxtPrenume
            // 
            // 
            // 
            // 
            this.mtxtPrenume.CustomButton.Image = null;
            this.mtxtPrenume.CustomButton.Location = new System.Drawing.Point(213, 2);
            this.mtxtPrenume.CustomButton.Name = "";
            this.mtxtPrenume.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtxtPrenume.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPrenume.CustomButton.TabIndex = 1;
            this.mtxtPrenume.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPrenume.CustomButton.UseSelectable = true;
            this.mtxtPrenume.CustomButton.Visible = false;
            this.mtxtPrenume.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxtPrenume.Lines = new string[0];
            this.mtxtPrenume.Location = new System.Drawing.Point(215, 130);
            this.mtxtPrenume.MaxLength = 32767;
            this.mtxtPrenume.Name = "mtxtPrenume";
            this.mtxtPrenume.PasswordChar = '\0';
            this.mtxtPrenume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPrenume.SelectedText = "";
            this.mtxtPrenume.SelectionLength = 0;
            this.mtxtPrenume.SelectionStart = 0;
            this.mtxtPrenume.ShortcutsEnabled = true;
            this.mtxtPrenume.Size = new System.Drawing.Size(241, 30);
            this.mtxtPrenume.TabIndex = 57;
            this.mtxtPrenume.UseSelectable = true;
            this.mtxtPrenume.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPrenume.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtNume
            // 
            // 
            // 
            // 
            this.mtxtNume.CustomButton.Image = null;
            this.mtxtNume.CustomButton.Location = new System.Drawing.Point(213, 2);
            this.mtxtNume.CustomButton.Name = "";
            this.mtxtNume.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtxtNume.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtNume.CustomButton.TabIndex = 1;
            this.mtxtNume.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtNume.CustomButton.UseSelectable = true;
            this.mtxtNume.CustomButton.Visible = false;
            this.mtxtNume.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxtNume.Lines = new string[0];
            this.mtxtNume.Location = new System.Drawing.Point(215, 91);
            this.mtxtNume.MaxLength = 32767;
            this.mtxtNume.Name = "mtxtNume";
            this.mtxtNume.PasswordChar = '\0';
            this.mtxtNume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtNume.SelectedText = "";
            this.mtxtNume.SelectionLength = 0;
            this.mtxtNume.SelectionStart = 0;
            this.mtxtNume.ShortcutsEnabled = true;
            this.mtxtNume.Size = new System.Drawing.Size(241, 30);
            this.mtxtNume.TabIndex = 56;
            this.mtxtNume.UseSelectable = true;
            this.mtxtNume.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtNume.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblPrenume
            // 
            this.mlblPrenume.AutoSize = true;
            this.mlblPrenume.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblPrenume.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblPrenume.ForeColor = System.Drawing.Color.Gold;
            this.mlblPrenume.Location = new System.Drawing.Point(81, 130);
            this.mlblPrenume.Name = "mlblPrenume";
            this.mlblPrenume.Size = new System.Drawing.Size(88, 25);
            this.mlblPrenume.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mlblPrenume.TabIndex = 55;
            this.mlblPrenume.Text = "Prenume";
            this.mlblPrenume.UseCustomForeColor = true;
            this.mlblPrenume.UseStyleColors = true;
            // 
            // mlblNume
            // 
            this.mlblNume.AutoSize = true;
            this.mlblNume.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblNume.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblNume.ForeColor = System.Drawing.Color.Gold;
            this.mlblNume.Location = new System.Drawing.Point(81, 91);
            this.mlblNume.Name = "mlblNume";
            this.mlblNume.Size = new System.Drawing.Size(63, 25);
            this.mlblNume.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mlblNume.TabIndex = 54;
            this.mlblNume.Text = "Nume";
            this.mlblNume.UseCustomForeColor = true;
            this.mlblNume.UseStyleColors = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(310, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 60;
            this.lblID.Visible = false;
            // 
            // FormaImprumutaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 364);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.mlblInfo);
            this.Controls.Add(this.mtImprumuta);
            this.Controls.Add(this.mtxtPrenume);
            this.Controls.Add(this.mtxtNume);
            this.Controls.Add(this.mlblPrenume);
            this.Controls.Add(this.mlblNume);
            this.Name = "FormaImprumutaCarte";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Împrumută cartea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlblInfo;
        private MetroFramework.Controls.MetroTile mtImprumuta;
        private MetroFramework.Controls.MetroTextBox mtxtPrenume;
        private MetroFramework.Controls.MetroTextBox mtxtNume;
        private MetroFramework.Controls.MetroLabel mlblPrenume;
        private MetroFramework.Controls.MetroLabel mlblNume;
        private System.Windows.Forms.Label lblID;
    }
}