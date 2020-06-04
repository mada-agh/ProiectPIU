namespace Biblioteca_Form
{
    partial class FormaReturnare
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
            this.lstCarti = new System.Windows.Forms.ListBox();
            this.mtReturneaza = new MetroFramework.Controls.MetroTile();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCarti
            // 
            this.lstCarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCarti.FormattingEnabled = true;
            this.lstCarti.ItemHeight = 20;
            this.lstCarti.Location = new System.Drawing.Point(23, 72);
            this.lstCarti.Name = "lstCarti";
            this.lstCarti.Size = new System.Drawing.Size(336, 204);
            this.lstCarti.TabIndex = 0;
            // 
            // mtReturneaza
            // 
            this.mtReturneaza.ActiveControl = null;
            this.mtReturneaza.Location = new System.Drawing.Point(68, 296);
            this.mtReturneaza.Name = "mtReturneaza";
            this.mtReturneaza.Size = new System.Drawing.Size(223, 62);
            this.mtReturneaza.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtReturneaza.TabIndex = 59;
            this.mtReturneaza.Text = "Returnează";
            this.mtReturneaza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtReturneaza.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtReturneaza.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtReturneaza.UseSelectable = true;
            this.mtReturneaza.Click += new System.EventHandler(this.mtReturneaza_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(207, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 60;
            this.lblID.Visible = false;
            // 
            // FormaReturnare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 381);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.mtReturneaza);
            this.Controls.Add(this.lstCarti);
            this.Name = "FormaReturnare";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Returnare cărți";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCarti;
        private MetroFramework.Controls.MetroTile mtReturneaza;
        private System.Windows.Forms.Label lblID;
    }
}