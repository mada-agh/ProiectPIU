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
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditura = new System.Windows.Forms.Label();
            this.lblNrExemplare = new System.Windows.Forms.Label();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditura = new System.Windows.Forms.TextBox();
            this.txtNrExemplare = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblAdauga = new System.Windows.Forms.Label();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.rtbAfisare = new System.Windows.Forms.RichTextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.lblCauta = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.lblModifica = new System.Windows.Forms.Label();
            this.btnCartiDisponibile = new System.Windows.Forms.Button();
            this.lblCartiDisponibile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitlu.Location = new System.Drawing.Point(12, 19);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(40, 18);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Titlu";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAutor.Location = new System.Drawing.Point(12, 52);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(48, 18);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor";
            // 
            // lblEditura
            // 
            this.lblEditura.AutoSize = true;
            this.lblEditura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEditura.Location = new System.Drawing.Point(12, 85);
            this.lblEditura.Name = "lblEditura";
            this.lblEditura.Size = new System.Drawing.Size(61, 18);
            this.lblEditura.TabIndex = 2;
            this.lblEditura.Text = "Editura";
            // 
            // lblNrExemplare
            // 
            this.lblNrExemplare.AutoSize = true;
            this.lblNrExemplare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrExemplare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNrExemplare.Location = new System.Drawing.Point(12, 121);
            this.lblNrExemplare.Name = "lblNrExemplare";
            this.lblNrExemplare.Size = new System.Drawing.Size(163, 18);
            this.lblNrExemplare.TabIndex = 3;
            this.lblNrExemplare.Text = "Număr de exemplare";
            // 
            // txtTitlu
            // 
            this.txtTitlu.Location = new System.Drawing.Point(217, 19);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(207, 22);
            this.txtTitlu.TabIndex = 4;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(217, 52);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(207, 22);
            this.txtAutor.TabIndex = 5;
            // 
            // txtEditura
            // 
            this.txtEditura.Location = new System.Drawing.Point(217, 85);
            this.txtEditura.Name = "txtEditura";
            this.txtEditura.Size = new System.Drawing.Size(207, 22);
            this.txtEditura.TabIndex = 6;
            // 
            // txtNrExemplare
            // 
            this.txtNrExemplare.Location = new System.Drawing.Point(217, 121);
            this.txtNrExemplare.Name = "txtNrExemplare";
            this.txtNrExemplare.Size = new System.Drawing.Size(32, 22);
            this.txtNrExemplare.TabIndex = 7;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.Silver;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdauga.Location = new System.Drawing.Point(15, 176);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(91, 31);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lblAdauga
            // 
            this.lblAdauga.AutoSize = true;
            this.lblAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdauga.ForeColor = System.Drawing.Color.White;
            this.lblAdauga.Location = new System.Drawing.Point(214, 180);
            this.lblAdauga.Name = "lblAdauga";
            this.lblAdauga.Size = new System.Drawing.Size(0, 18);
            this.lblAdauga.TabIndex = 9;
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.Silver;
            this.btnAfisare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisare.Location = new System.Drawing.Point(15, 230);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(91, 32);
            this.btnAfisare.TabIndex = 10;
            this.btnAfisare.Text = "Afișează";
            this.btnAfisare.UseVisualStyleBackColor = false;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // rtbAfisare
            // 
            this.rtbAfisare.Location = new System.Drawing.Point(217, 230);
            this.rtbAfisare.Name = "rtbAfisare";
            this.rtbAfisare.Size = new System.Drawing.Size(353, 96);
            this.rtbAfisare.TabIndex = 11;
            this.rtbAfisare.Text = "";
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.Silver;
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(15, 347);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 32);
            this.btnCauta.TabIndex = 12;
            this.btnCauta.Text = "Caută";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // lblCauta
            // 
            this.lblCauta.AutoSize = true;
            this.lblCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauta.ForeColor = System.Drawing.Color.White;
            this.lblCauta.Location = new System.Drawing.Point(214, 354);
            this.lblCauta.Name = "lblCauta";
            this.lblCauta.Size = new System.Drawing.Size(0, 18);
            this.lblCauta.TabIndex = 13;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.Silver;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(15, 436);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(91, 32);
            this.btnModifica.TabIndex = 14;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // lblModifica
            // 
            this.lblModifica.AutoSize = true;
            this.lblModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifica.ForeColor = System.Drawing.Color.White;
            this.lblModifica.Location = new System.Drawing.Point(214, 444);
            this.lblModifica.Name = "lblModifica";
            this.lblModifica.Size = new System.Drawing.Size(0, 18);
            this.lblModifica.TabIndex = 15;
            // 
            // btnCartiDisponibile
            // 
            this.btnCartiDisponibile.BackColor = System.Drawing.Color.Silver;
            this.btnCartiDisponibile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartiDisponibile.Location = new System.Drawing.Point(15, 493);
            this.btnCartiDisponibile.Name = "btnCartiDisponibile";
            this.btnCartiDisponibile.Size = new System.Drawing.Size(144, 30);
            this.btnCartiDisponibile.TabIndex = 16;
            this.btnCartiDisponibile.Text = "Cărți disponibile";
            this.btnCartiDisponibile.UseVisualStyleBackColor = false;
            this.btnCartiDisponibile.Click += new System.EventHandler(this.btnCartiDisponibile_Click);
            // 
            // lblCartiDisponibile
            // 
            this.lblCartiDisponibile.AutoSize = true;
            this.lblCartiDisponibile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartiDisponibile.ForeColor = System.Drawing.Color.White;
            this.lblCartiDisponibile.Location = new System.Drawing.Point(214, 500);
            this.lblCartiDisponibile.Name = "lblCartiDisponibile";
            this.lblCartiDisponibile.Size = new System.Drawing.Size(0, 18);
            this.lblCartiDisponibile.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.lblCartiDisponibile);
            this.Controls.Add(this.btnCartiDisponibile);
            this.Controls.Add(this.lblModifica);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.lblCauta);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.rtbAfisare);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.lblAdauga);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.txtNrExemplare);
            this.Controls.Add(this.txtEditura);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.lblNrExemplare);
            this.Controls.Add(this.lblEditura);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Name = "Form1";
            this.Text = "Biblioteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditura;
        private System.Windows.Forms.Label lblNrExemplare;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditura;
        private System.Windows.Forms.TextBox txtNrExemplare;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblAdauga;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.RichTextBox rtbAfisare;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label lblCauta;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label lblModifica;
        private System.Windows.Forms.Button btnCartiDisponibile;
        private System.Windows.Forms.Label lblCartiDisponibile;
    }
}

