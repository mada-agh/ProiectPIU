namespace Biblioteca_Form
{
    partial class FormaImprumuta
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
            this.mtxtAutor = new MetroFramework.Controls.MetroTextBox();
            this.mtxtTitlu = new MetroFramework.Controls.MetroTextBox();
            this.mlblAutor = new MetroFramework.Controls.MetroLabel();
            this.mlblTitlu = new MetroFramework.Controls.MetroLabel();
            this.mtImprumuta = new MetroFramework.Controls.MetroTile();
            this.mlblInfo = new MetroFramework.Controls.MetroLabel();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxtAutor
            // 
            // 
            // 
            // 
            this.mtxtAutor.CustomButton.Image = null;
            this.mtxtAutor.CustomButton.Location = new System.Drawing.Point(213, 2);
            this.mtxtAutor.CustomButton.Name = "";
            this.mtxtAutor.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtxtAutor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtAutor.CustomButton.TabIndex = 1;
            this.mtxtAutor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtAutor.CustomButton.UseSelectable = true;
            this.mtxtAutor.CustomButton.Visible = false;
            this.mtxtAutor.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxtAutor.Lines = new string[0];
            this.mtxtAutor.Location = new System.Drawing.Point(119, 113);
            this.mtxtAutor.MaxLength = 32767;
            this.mtxtAutor.Name = "mtxtAutor";
            this.mtxtAutor.PasswordChar = '\0';
            this.mtxtAutor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtAutor.SelectedText = "";
            this.mtxtAutor.SelectionLength = 0;
            this.mtxtAutor.SelectionStart = 0;
            this.mtxtAutor.ShortcutsEnabled = true;
            this.mtxtAutor.Size = new System.Drawing.Size(241, 30);
            this.mtxtAutor.TabIndex = 57;
            this.mtxtAutor.UseSelectable = true;
            this.mtxtAutor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtAutor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtTitlu
            // 
            // 
            // 
            // 
            this.mtxtTitlu.CustomButton.Image = null;
            this.mtxtTitlu.CustomButton.Location = new System.Drawing.Point(213, 2);
            this.mtxtTitlu.CustomButton.Name = "";
            this.mtxtTitlu.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtxtTitlu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtTitlu.CustomButton.TabIndex = 1;
            this.mtxtTitlu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtTitlu.CustomButton.UseSelectable = true;
            this.mtxtTitlu.CustomButton.Visible = false;
            this.mtxtTitlu.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxtTitlu.Lines = new string[0];
            this.mtxtTitlu.Location = new System.Drawing.Point(119, 72);
            this.mtxtTitlu.MaxLength = 32767;
            this.mtxtTitlu.Name = "mtxtTitlu";
            this.mtxtTitlu.PasswordChar = '\0';
            this.mtxtTitlu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTitlu.SelectedText = "";
            this.mtxtTitlu.SelectionLength = 0;
            this.mtxtTitlu.SelectionStart = 0;
            this.mtxtTitlu.ShortcutsEnabled = true;
            this.mtxtTitlu.Size = new System.Drawing.Size(241, 30);
            this.mtxtTitlu.TabIndex = 56;
            this.mtxtTitlu.UseSelectable = true;
            this.mtxtTitlu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtTitlu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblAutor
            // 
            this.mlblAutor.AutoSize = true;
            this.mlblAutor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblAutor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblAutor.ForeColor = System.Drawing.Color.Gold;
            this.mlblAutor.Location = new System.Drawing.Point(23, 113);
            this.mlblAutor.Name = "mlblAutor";
            this.mlblAutor.Size = new System.Drawing.Size(59, 25);
            this.mlblAutor.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mlblAutor.TabIndex = 55;
            this.mlblAutor.Text = "Autor";
            this.mlblAutor.UseCustomForeColor = true;
            this.mlblAutor.UseStyleColors = true;
            // 
            // mlblTitlu
            // 
            this.mlblTitlu.AutoSize = true;
            this.mlblTitlu.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblTitlu.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblTitlu.ForeColor = System.Drawing.Color.Gold;
            this.mlblTitlu.Location = new System.Drawing.Point(23, 72);
            this.mlblTitlu.Name = "mlblTitlu";
            this.mlblTitlu.Size = new System.Drawing.Size(49, 25);
            this.mlblTitlu.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mlblTitlu.TabIndex = 54;
            this.mlblTitlu.Text = "Titlu";
            this.mlblTitlu.UseCustomForeColor = true;
            this.mlblTitlu.UseStyleColors = true;
            // 
            // mtImprumuta
            // 
            this.mtImprumuta.ActiveControl = null;
            this.mtImprumuta.Location = new System.Drawing.Point(23, 222);
            this.mtImprumuta.Name = "mtImprumuta";
            this.mtImprumuta.Size = new System.Drawing.Size(337, 62);
            this.mtImprumuta.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtImprumuta.TabIndex = 58;
            this.mtImprumuta.Text = "Împrumută";
            this.mtImprumuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtImprumuta.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtImprumuta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtImprumuta.UseSelectable = true;
            this.mtImprumuta.Click += new System.EventHandler(this.mtImprumuta_Click);
            // 
            // mlblInfo
            // 
            this.mlblInfo.AutoSize = true;
            this.mlblInfo.Location = new System.Drawing.Point(23, 167);
            this.mlblInfo.Name = "mlblInfo";
            this.mlblInfo.Size = new System.Drawing.Size(0, 0);
            this.mlblInfo.TabIndex = 59;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(263, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 60;
            this.lblID.Visible = false;
            // 
            // FormaImprumuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 320);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.mlblInfo);
            this.Controls.Add(this.mtImprumuta);
            this.Controls.Add(this.mtxtAutor);
            this.Controls.Add(this.mtxtTitlu);
            this.Controls.Add(this.mlblAutor);
            this.Controls.Add(this.mlblTitlu);
            this.Name = "FormaImprumuta";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Împrumută carte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtxtAutor;
        private MetroFramework.Controls.MetroTextBox mtxtTitlu;
        private MetroFramework.Controls.MetroLabel mlblAutor;
        private MetroFramework.Controls.MetroLabel mlblTitlu;
        private MetroFramework.Controls.MetroTile mtImprumuta;
        private MetroFramework.Controls.MetroLabel mlblInfo;
        private System.Windows.Forms.Label lblID;
    }
}