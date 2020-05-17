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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtAdauga = new MetroFramework.Controls.MetroTile();
            this.mtModifica = new MetroFramework.Controls.MetroTile();
            this.mtCautare = new MetroFramework.Controls.MetroTile();
            this.mtCartiDisponibile = new MetroFramework.Controls.MetroTile();
            this.mtCautaDataActualizarii = new MetroFramework.Controls.MetroTile();
            this.metroGridCarti = new MetroFramework.Controls.MetroGrid();
            this.mtResetLista = new MetroFramework.Controls.MetroTile();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCarti)).BeginInit();
            this.SuspendLayout();
            // 
            // mtAdauga
            // 
            this.mtAdauga.ActiveControl = null;
            this.mtAdauga.Location = new System.Drawing.Point(23, 79);
            this.mtAdauga.Name = "mtAdauga";
            this.mtAdauga.Size = new System.Drawing.Size(197, 59);
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
            this.mtModifica.Location = new System.Drawing.Point(226, 79);
            this.mtModifica.Name = "mtModifica";
            this.mtModifica.Size = new System.Drawing.Size(190, 59);
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
            this.mtCautare.Location = new System.Drawing.Point(422, 79);
            this.mtCautare.Name = "mtCautare";
            this.mtCautare.Size = new System.Drawing.Size(191, 59);
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
            this.mtCartiDisponibile.Location = new System.Drawing.Point(619, 79);
            this.mtCartiDisponibile.Name = "mtCartiDisponibile";
            this.mtCartiDisponibile.Size = new System.Drawing.Size(202, 59);
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
            this.mtCautaDataActualizarii.Location = new System.Drawing.Point(827, 79);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCarti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGridCarti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridCarti.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGridCarti.EnableHeadersVisualStyles = false;
            this.metroGridCarti.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridCarti.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCarti.Location = new System.Drawing.Point(61, 159);
            this.metroGridCarti.Name = "metroGridCarti";
            this.metroGridCarti.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCarti.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGridCarti.RowHeadersWidth = 51;
            this.metroGridCarti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridCarti.RowTemplate.Height = 24;
            this.metroGridCarti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridCarti.Size = new System.Drawing.Size(1184, 443);
            this.metroGridCarti.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroGridCarti.TabIndex = 22;
            // 
            // mtResetLista
            // 
            this.mtResetLista.ActiveControl = null;
            this.mtResetLista.Location = new System.Drawing.Point(1104, 79);
            this.mtResetLista.Name = "mtResetLista";
            this.mtResetLista.Size = new System.Drawing.Size(183, 59);
            this.mtResetLista.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtResetLista.TabIndex = 23;
            this.mtResetLista.Text = "Resetează lista";
            this.mtResetLista.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtResetLista.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtResetLista.UseSelectable = true;
            this.mtResetLista.UseStyleColors = true;
            this.mtResetLista.Click += new System.EventHandler(this.mtResetLista_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1104, 620);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(141, 36);
            this.metroButton1.TabIndex = 24;
            this.metroButton1.Text = "Înapoi la meniu";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1311, 670);
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
    }
}

