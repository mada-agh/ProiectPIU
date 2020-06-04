namespace Biblioteca_Form
{
    partial class FormaCautaCititor
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
            this.mtCauta = new MetroFramework.Controls.MetroTile();
            this.mtxtPrenume = new MetroFramework.Controls.MetroTextBox();
            this.mtxtNume = new MetroFramework.Controls.MetroTextBox();
            this.mlblPrenume = new MetroFramework.Controls.MetroLabel();
            this.mlblNume = new MetroFramework.Controls.MetroLabel();
            this.mtImprumut = new MetroFramework.Controls.MetroTile();
            this.mlblInfo = new MetroFramework.Controls.MetroLabel();
            this.mtReturneaza = new MetroFramework.Controls.MetroTile();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtCauta
            // 
            this.mtCauta.ActiveControl = null;
            this.mtCauta.Location = new System.Drawing.Point(45, 224);
            this.mtCauta.Name = "mtCauta";
            this.mtCauta.Size = new System.Drawing.Size(375, 74);
            this.mtCauta.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtCauta.TabIndex = 51;
            this.mtCauta.Text = "Caută";
            this.mtCauta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCauta.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCauta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCauta.UseSelectable = true;
            this.mtCauta.Click += new System.EventHandler(this.mtCauta_Click);
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
            this.mtxtPrenume.Location = new System.Drawing.Point(179, 122);
            this.mtxtPrenume.MaxLength = 32767;
            this.mtxtPrenume.Name = "mtxtPrenume";
            this.mtxtPrenume.PasswordChar = '\0';
            this.mtxtPrenume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPrenume.SelectedText = "";
            this.mtxtPrenume.SelectionLength = 0;
            this.mtxtPrenume.SelectionStart = 0;
            this.mtxtPrenume.ShortcutsEnabled = true;
            this.mtxtPrenume.Size = new System.Drawing.Size(241, 30);
            this.mtxtPrenume.TabIndex = 50;
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
            this.mtxtNume.Location = new System.Drawing.Point(179, 83);
            this.mtxtNume.MaxLength = 32767;
            this.mtxtNume.Name = "mtxtNume";
            this.mtxtNume.PasswordChar = '\0';
            this.mtxtNume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtNume.SelectedText = "";
            this.mtxtNume.SelectionLength = 0;
            this.mtxtNume.SelectionStart = 0;
            this.mtxtNume.ShortcutsEnabled = true;
            this.mtxtNume.Size = new System.Drawing.Size(241, 30);
            this.mtxtNume.TabIndex = 49;
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
            this.mlblPrenume.Location = new System.Drawing.Point(45, 122);
            this.mlblPrenume.Name = "mlblPrenume";
            this.mlblPrenume.Size = new System.Drawing.Size(88, 25);
            this.mlblPrenume.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mlblPrenume.TabIndex = 48;
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
            this.mlblNume.Location = new System.Drawing.Point(45, 83);
            this.mlblNume.Name = "mlblNume";
            this.mlblNume.Size = new System.Drawing.Size(63, 25);
            this.mlblNume.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mlblNume.TabIndex = 47;
            this.mlblNume.Text = "Nume";
            this.mlblNume.UseCustomForeColor = true;
            this.mlblNume.UseStyleColors = true;
            // 
            // mtImprumut
            // 
            this.mtImprumut.ActiveControl = null;
            this.mtImprumut.Location = new System.Drawing.Point(45, 304);
            this.mtImprumut.Name = "mtImprumut";
            this.mtImprumut.Size = new System.Drawing.Size(375, 74);
            this.mtImprumut.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtImprumut.TabIndex = 52;
            this.mtImprumut.Text = "Împrumută carte";
            this.mtImprumut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtImprumut.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtImprumut.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtImprumut.UseSelectable = true;
            this.mtImprumut.Visible = false;
            this.mtImprumut.Click += new System.EventHandler(this.mtImprumut_Click);
            // 
            // mlblInfo
            // 
            this.mlblInfo.AutoSize = true;
            this.mlblInfo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblInfo.Location = new System.Drawing.Point(45, 173);
            this.mlblInfo.Name = "mlblInfo";
            this.mlblInfo.Size = new System.Drawing.Size(0, 0);
            this.mlblInfo.Style = MetroFramework.MetroColorStyle.Brown;
            this.mlblInfo.TabIndex = 53;
            this.mlblInfo.UseStyleColors = true;
            // 
            // mtReturneaza
            // 
            this.mtReturneaza.ActiveControl = null;
            this.mtReturneaza.Location = new System.Drawing.Point(45, 384);
            this.mtReturneaza.Name = "mtReturneaza";
            this.mtReturneaza.Size = new System.Drawing.Size(375, 74);
            this.mtReturneaza.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtReturneaza.TabIndex = 54;
            this.mtReturneaza.Text = "Returnează carte";
            this.mtReturneaza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtReturneaza.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtReturneaza.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtReturneaza.UseSelectable = true;
            this.mtReturneaza.Visible = false;
            this.mtReturneaza.Click += new System.EventHandler(this.mtReturneaza_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(188, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 55;
            this.lblID.Visible = false;
            // 
            // FormaCautaCititor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 488);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.mtReturneaza);
            this.Controls.Add(this.mlblInfo);
            this.Controls.Add(this.mtImprumut);
            this.Controls.Add(this.mtCauta);
            this.Controls.Add(this.mtxtPrenume);
            this.Controls.Add(this.mtxtNume);
            this.Controls.Add(this.mlblPrenume);
            this.Controls.Add(this.mlblNume);
            this.Name = "FormaCautaCititor";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Caută cititor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCauta;
        private MetroFramework.Controls.MetroTextBox mtxtPrenume;
        private MetroFramework.Controls.MetroTextBox mtxtNume;
        private MetroFramework.Controls.MetroLabel mlblPrenume;
        private MetroFramework.Controls.MetroLabel mlblNume;
        private MetroFramework.Controls.MetroTile mtImprumut;
        private MetroFramework.Controls.MetroLabel mlblInfo;
        private MetroFramework.Controls.MetroTile mtReturneaza;
        private System.Windows.Forms.Label lblID;
    }
}