namespace Biblioteca_Form
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtAdauga = new MetroFramework.Controls.MetroTile();
            this.mtModifica = new MetroFramework.Controls.MetroTile();
            this.mtCautare = new MetroFramework.Controls.MetroTile();
            this.mtCartiDisponibile = new MetroFramework.Controls.MetroTile();
            this.mtCautaDataActualizarii = new MetroFramework.Controls.MetroTile();
            this.metroGridCarti = new MetroFramework.Controls.MetroGrid();
            this.mtResetLista = new MetroFramework.Controls.MetroTile();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.mtImprumuta = new MetroFramework.Controls.MetroTile();
            this.mtSterge = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCarti)).BeginInit();
            this.SuspendLayout();
            // 
            // mtAdauga
            // 
            this.mtAdauga.ActiveControl = null;
            this.mtAdauga.Location = new System.Drawing.Point(23, 79);
            this.mtAdauga.Name = "mtAdauga";
            this.mtAdauga.Size = new System.Drawing.Size(271, 59);
            this.mtAdauga.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtAdauga.TabIndex = 17;
            this.mtAdauga.Text = "Adaugă carte";
            this.mtAdauga.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAdauga.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtAdauga.UseSelectable = true;
            this.mtAdauga.Click += new System.EventHandler(this.mtAdauga_Click);
            // 
            // mtModifica
            // 
            this.mtModifica.ActiveControl = null;
            this.mtModifica.Location = new System.Drawing.Point(23, 144);
            this.mtModifica.Name = "mtModifica";
            this.mtModifica.Size = new System.Drawing.Size(271, 59);
            this.mtModifica.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtModifica.TabIndex = 18;
            this.mtModifica.Text = "Modifică carte";
            this.mtModifica.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtModifica.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtModifica.UseSelectable = true;
            this.mtModifica.Click += new System.EventHandler(this.mtModifica_Click);
            // 
            // mtCautare
            // 
            this.mtCautare.ActiveControl = null;
            this.mtCautare.Location = new System.Drawing.Point(23, 209);
            this.mtCautare.Name = "mtCautare";
            this.mtCautare.Size = new System.Drawing.Size(271, 59);
            this.mtCautare.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtCautare.TabIndex = 19;
            this.mtCautare.Text = "Caută carte";
            this.mtCautare.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCautare.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtCautare.UseSelectable = true;
            this.mtCautare.Click += new System.EventHandler(this.mtCautare_Click);
            // 
            // mtCartiDisponibile
            // 
            this.mtCartiDisponibile.ActiveControl = null;
            this.mtCartiDisponibile.Location = new System.Drawing.Point(23, 274);
            this.mtCartiDisponibile.Name = "mtCartiDisponibile";
            this.mtCartiDisponibile.Size = new System.Drawing.Size(271, 59);
            this.mtCartiDisponibile.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtCartiDisponibile.TabIndex = 20;
            this.mtCartiDisponibile.Text = "Cărți disponibile";
            this.mtCartiDisponibile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCartiDisponibile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtCartiDisponibile.UseSelectable = true;
            this.mtCartiDisponibile.Click += new System.EventHandler(this.mtCartiDisponibile_Click);
            // 
            // mtCautaDataActualizarii
            // 
            this.mtCautaDataActualizarii.ActiveControl = null;
            this.mtCautaDataActualizarii.Location = new System.Drawing.Point(23, 339);
            this.mtCautaDataActualizarii.Name = "mtCautaDataActualizarii";
            this.mtCautaDataActualizarii.Size = new System.Drawing.Size(271, 59);
            this.mtCautaDataActualizarii.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtCautaDataActualizarii.TabIndex = 21;
            this.mtCautaDataActualizarii.Text = "Caută data actualizării";
            this.mtCautaDataActualizarii.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCautaDataActualizarii.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtCautaDataActualizarii.UseSelectable = true;
            this.mtCautaDataActualizarii.Click += new System.EventHandler(this.mtCautaDataActualizarii_Click);
            // 
            // metroGridCarti
            // 
            this.metroGridCarti.AllowUserToResizeRows = false;
            this.metroGridCarti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCarti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridCarti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridCarti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCarti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridCarti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridCarti.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridCarti.EnableHeadersVisualStyles = false;
            this.metroGridCarti.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridCarti.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCarti.Location = new System.Drawing.Point(306, 85);
            this.metroGridCarti.Name = "metroGridCarti";
            this.metroGridCarti.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCarti.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridCarti.RowHeadersWidth = 51;
            this.metroGridCarti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridCarti.RowTemplate.Height = 24;
            this.metroGridCarti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridCarti.Size = new System.Drawing.Size(1184, 508);
            this.metroGridCarti.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroGridCarti.TabIndex = 22;
            // 
            // mtResetLista
            // 
            this.mtResetLista.ActiveControl = null;
            this.mtResetLista.Location = new System.Drawing.Point(23, 404);
            this.mtResetLista.Name = "mtResetLista";
            this.mtResetLista.Size = new System.Drawing.Size(271, 59);
            this.mtResetLista.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtResetLista.TabIndex = 23;
            this.mtResetLista.Text = "Actualizează lista";
            this.mtResetLista.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtResetLista.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtResetLista.UseSelectable = true;
            this.mtResetLista.UseStyleColors = true;
            this.mtResetLista.Click += new System.EventHandler(this.mtResetLista_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1349, 611);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(141, 36);
            this.metroButton1.TabIndex = 24;
            this.metroButton1.Text = "Înapoi la meniu";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // mtImprumuta
            // 
            this.mtImprumuta.ActiveControl = null;
            this.mtImprumuta.Location = new System.Drawing.Point(23, 469);
            this.mtImprumuta.Name = "mtImprumuta";
            this.mtImprumuta.Size = new System.Drawing.Size(271, 59);
            this.mtImprumuta.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtImprumuta.TabIndex = 25;
            this.mtImprumuta.Text = "Împrumută cartea";
            this.mtImprumuta.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtImprumuta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtImprumuta.UseSelectable = true;
            this.mtImprumuta.UseStyleColors = true;
            this.mtImprumuta.Click += new System.EventHandler(this.mtImprumuta_Click);
            // 
            // mtSterge
            // 
            this.mtSterge.ActiveControl = null;
            this.mtSterge.Location = new System.Drawing.Point(23, 534);
            this.mtSterge.Name = "mtSterge";
            this.mtSterge.Size = new System.Drawing.Size(271, 59);
            this.mtSterge.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtSterge.TabIndex = 26;
            this.mtSterge.Text = "Șterge cartea";
            this.mtSterge.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSterge.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtSterge.UseSelectable = true;
            this.mtSterge.UseStyleColors = true;
            this.mtSterge.Click += new System.EventHandler(this.mtSterge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1513, 670);
            this.Controls.Add(this.mtSterge);
            this.Controls.Add(this.mtImprumuta);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mtResetLista);
            this.Controls.Add(this.metroGridCarti);
            this.Controls.Add(this.mtCautaDataActualizarii);
            this.Controls.Add(this.mtCartiDisponibile);
            this.Controls.Add(this.mtCautare);
            this.Controls.Add(this.mtModifica);
            this.Controls.Add(this.mtAdauga);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Administrare cărți";
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCarti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtAdauga;
        private MetroFramework.Controls.MetroTile mtModifica;
        private MetroFramework.Controls.MetroTile mtCautare;
        private MetroFramework.Controls.MetroTile mtCartiDisponibile;
        private MetroFramework.Controls.MetroTile mtCautaDataActualizarii;
        private MetroFramework.Controls.MetroGrid metroGridCarti;
        private MetroFramework.Controls.MetroTile mtResetLista;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile mtImprumuta;
        private MetroFramework.Controls.MetroTile mtSterge;
    }
}

