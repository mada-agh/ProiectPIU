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
            this.btnAfisare = new System.Windows.Forms.Button();
            this.rtbAfisare = new System.Windows.Forms.RichTextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCartiDisponibile = new System.Windows.Forms.Button();
            this.gpbLimba = new System.Windows.Forms.GroupBox();
            this.rbRusa = new System.Windows.Forms.RadioButton();
            this.rbFranceza = new System.Windows.Forms.RadioButton();
            this.rbItaliana = new System.Windows.Forms.RadioButton();
            this.rbEngleza = new System.Windows.Forms.RadioButton();
            this.rbGermana = new System.Windows.Forms.RadioButton();
            this.rbRomana = new System.Windows.Forms.RadioButton();
            this.gpbGenul = new System.Windows.Forms.GroupBox();
            this.ckbMitologie = new System.Windows.Forms.CheckBox();
            this.ckbIstoric = new System.Windows.Forms.CheckBox();
            this.ckbPoetica = new System.Windows.Forms.CheckBox();
            this.ckbFolclor = new System.Windows.Forms.CheckBox();
            this.ckbFictiune = new System.Windows.Forms.CheckBox();
            this.ckbFantezie = new System.Windows.Forms.CheckBox();
            this.ckbReligie = new System.Windows.Forms.CheckBox();
            this.ckbGroaza = new System.Windows.Forms.CheckBox();
            this.ckbUmoristic = new System.Windows.Forms.CheckBox();
            this.ckbDragoste = new System.Windows.Forms.CheckBox();
            this.ckbCriminalistic = new System.Windows.Forms.CheckBox();
            this.ckbCopii = new System.Windows.Forms.CheckBox();
            this.gpbLimba.SuspendLayout();
            this.gpbGenul.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitlu.Location = new System.Drawing.Point(10, 19);
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
            this.lblAutor.Location = new System.Drawing.Point(10, 51);
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
            this.lblEditura.Location = new System.Drawing.Point(10, 85);
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
            this.lblNrExemplare.Location = new System.Drawing.Point(10, 121);
            this.lblNrExemplare.Name = "lblNrExemplare";
            this.lblNrExemplare.Size = new System.Drawing.Size(163, 18);
            this.lblNrExemplare.TabIndex = 3;
            this.lblNrExemplare.Text = "Număr de exemplare";
            // 
            // txtTitlu
            // 
            this.txtTitlu.Location = new System.Drawing.Point(204, 18);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(244, 22);
            this.txtTitlu.TabIndex = 4;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(204, 51);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(244, 22);
            this.txtAutor.TabIndex = 5;
            // 
            // txtEditura
            // 
            this.txtEditura.Location = new System.Drawing.Point(204, 84);
            this.txtEditura.Name = "txtEditura";
            this.txtEditura.Size = new System.Drawing.Size(244, 22);
            this.txtEditura.TabIndex = 6;
            // 
            // txtNrExemplare
            // 
            this.txtNrExemplare.Location = new System.Drawing.Point(204, 120);
            this.txtNrExemplare.Name = "txtNrExemplare";
            this.txtNrExemplare.Size = new System.Drawing.Size(32, 22);
            this.txtNrExemplare.TabIndex = 7;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.Silver;
            this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdauga.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdauga.Location = new System.Drawing.Point(233, 399);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(215, 48);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.Silver;
            this.btnAfisare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAfisare.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisare.Location = new System.Drawing.Point(15, 399);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(212, 48);
            this.btnAfisare.TabIndex = 10;
            this.btnAfisare.Text = "Afișează";
            this.btnAfisare.UseVisualStyleBackColor = false;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // rtbAfisare
            // 
            this.rtbAfisare.Location = new System.Drawing.Point(473, 19);
            this.rtbAfisare.Name = "rtbAfisare";
            this.rtbAfisare.Size = new System.Drawing.Size(353, 332);
            this.rtbAfisare.TabIndex = 11;
            this.rtbAfisare.Text = "";
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.Silver;
            this.btnCauta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCauta.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(233, 453);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(215, 50);
            this.btnCauta.TabIndex = 12;
            this.btnCauta.Text = "Caută";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(507, 415);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 23);
            this.lblInfo.TabIndex = 13;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.Silver;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModifica.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(15, 453);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(212, 50);
            this.btnModifica.TabIndex = 14;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCartiDisponibile
            // 
            this.btnCartiDisponibile.BackColor = System.Drawing.Color.Silver;
            this.btnCartiDisponibile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCartiDisponibile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCartiDisponibile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCartiDisponibile.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartiDisponibile.Location = new System.Drawing.Point(130, 509);
            this.btnCartiDisponibile.Name = "btnCartiDisponibile";
            this.btnCartiDisponibile.Size = new System.Drawing.Size(198, 52);
            this.btnCartiDisponibile.TabIndex = 16;
            this.btnCartiDisponibile.Text = "Cărți disponibile";
            this.btnCartiDisponibile.UseVisualStyleBackColor = false;
            this.btnCartiDisponibile.Click += new System.EventHandler(this.btnCartiDisponibile_Click);
            // 
            // gpbLimba
            // 
            this.gpbLimba.Controls.Add(this.rbRusa);
            this.gpbLimba.Controls.Add(this.rbFranceza);
            this.gpbLimba.Controls.Add(this.rbItaliana);
            this.gpbLimba.Controls.Add(this.rbEngleza);
            this.gpbLimba.Controls.Add(this.rbGermana);
            this.gpbLimba.Controls.Add(this.rbRomana);
            this.gpbLimba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLimba.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbLimba.Location = new System.Drawing.Point(13, 148);
            this.gpbLimba.Name = "gpbLimba";
            this.gpbLimba.Size = new System.Drawing.Size(435, 92);
            this.gpbLimba.TabIndex = 19;
            this.gpbLimba.TabStop = false;
            this.gpbLimba.Text = "Limba";
            // 
            // rbRusa
            // 
            this.rbRusa.AutoSize = true;
            this.rbRusa.Location = new System.Drawing.Point(287, 53);
            this.rbRusa.Name = "rbRusa";
            this.rbRusa.Size = new System.Drawing.Size(68, 22);
            this.rbRusa.TabIndex = 20;
            this.rbRusa.TabStop = true;
            this.rbRusa.Text = "Rusă";
            this.rbRusa.UseVisualStyleBackColor = true;
            // 
            // rbFranceza
            // 
            this.rbFranceza.AutoSize = true;
            this.rbFranceza.Location = new System.Drawing.Point(287, 25);
            this.rbFranceza.Name = "rbFranceza";
            this.rbFranceza.Size = new System.Drawing.Size(99, 22);
            this.rbFranceza.TabIndex = 20;
            this.rbFranceza.TabStop = true;
            this.rbFranceza.Text = "Franceză";
            this.rbFranceza.UseVisualStyleBackColor = true;
            // 
            // rbItaliana
            // 
            this.rbItaliana.AutoSize = true;
            this.rbItaliana.Location = new System.Drawing.Point(146, 51);
            this.rbItaliana.Name = "rbItaliana";
            this.rbItaliana.Size = new System.Drawing.Size(82, 22);
            this.rbItaliana.TabIndex = 20;
            this.rbItaliana.TabStop = true;
            this.rbItaliana.Text = "Italiană";
            this.rbItaliana.UseVisualStyleBackColor = true;
            // 
            // rbEngleza
            // 
            this.rbEngleza.AutoSize = true;
            this.rbEngleza.Location = new System.Drawing.Point(146, 24);
            this.rbEngleza.Name = "rbEngleza";
            this.rbEngleza.Size = new System.Drawing.Size(89, 22);
            this.rbEngleza.TabIndex = 20;
            this.rbEngleza.TabStop = true;
            this.rbEngleza.Text = "Engleză";
            this.rbEngleza.UseVisualStyleBackColor = true;
            // 
            // rbGermana
            // 
            this.rbGermana.AutoSize = true;
            this.rbGermana.Location = new System.Drawing.Point(6, 51);
            this.rbGermana.Name = "rbGermana";
            this.rbGermana.Size = new System.Drawing.Size(98, 22);
            this.rbGermana.TabIndex = 20;
            this.rbGermana.TabStop = true;
            this.rbGermana.Text = "Germană";
            this.rbGermana.UseVisualStyleBackColor = true;
            // 
            // rbRomana
            // 
            this.rbRomana.AutoSize = true;
            this.rbRomana.Location = new System.Drawing.Point(6, 24);
            this.rbRomana.Name = "rbRomana";
            this.rbRomana.Size = new System.Drawing.Size(92, 22);
            this.rbRomana.TabIndex = 20;
            this.rbRomana.TabStop = true;
            this.rbRomana.Text = "Română";
            this.rbRomana.UseVisualStyleBackColor = true;
            // 
            // gpbGenul
            // 
            this.gpbGenul.Controls.Add(this.ckbMitologie);
            this.gpbGenul.Controls.Add(this.ckbIstoric);
            this.gpbGenul.Controls.Add(this.ckbPoetica);
            this.gpbGenul.Controls.Add(this.ckbFolclor);
            this.gpbGenul.Controls.Add(this.ckbFictiune);
            this.gpbGenul.Controls.Add(this.ckbFantezie);
            this.gpbGenul.Controls.Add(this.ckbReligie);
            this.gpbGenul.Controls.Add(this.ckbGroaza);
            this.gpbGenul.Controls.Add(this.ckbUmoristic);
            this.gpbGenul.Controls.Add(this.ckbDragoste);
            this.gpbGenul.Controls.Add(this.ckbCriminalistic);
            this.gpbGenul.Controls.Add(this.ckbCopii);
            this.gpbGenul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGenul.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbGenul.Location = new System.Drawing.Point(12, 246);
            this.gpbGenul.Name = "gpbGenul";
            this.gpbGenul.Size = new System.Drawing.Size(436, 147);
            this.gpbGenul.TabIndex = 20;
            this.gpbGenul.TabStop = false;
            this.gpbGenul.Text = "Genul";
            // 
            // ckbMitologie
            // 
            this.ckbMitologie.AutoSize = true;
            this.ckbMitologie.Location = new System.Drawing.Point(288, 111);
            this.ckbMitologie.Name = "ckbMitologie";
            this.ckbMitologie.Size = new System.Drawing.Size(99, 22);
            this.ckbMitologie.TabIndex = 21;
            this.ckbMitologie.Text = "Mitologie";
            this.ckbMitologie.UseVisualStyleBackColor = true;
            this.ckbMitologie.CheckedChanged += new System.EventHandler(this.ckbGen_CheckedChanged);
            // 
            // ckbIstoric
            // 
            this.ckbIstoric.AutoSize = true;
            this.ckbIstoric.Location = new System.Drawing.Point(147, 111);
            this.ckbIstoric.Name = "ckbIstoric";
            this.ckbIstoric.Size = new System.Drawing.Size(77, 22);
            this.ckbIstoric.TabIndex = 21;
            this.ckbIstoric.Text = "Istoric";
            this.ckbIstoric.UseVisualStyleBackColor = true;
            this.ckbIstoric.CheckedChanged += new System.EventHandler(this.ckbGen_CheckedChanged);
            // 
            // ckbPoetica
            // 
            this.ckbPoetica.AutoSize = true;
            this.ckbPoetica.Location = new System.Drawing.Point(7, 111);
            this.ckbPoetica.Name = "ckbPoetica";
            this.ckbPoetica.Size = new System.Drawing.Size(87, 22);
            this.ckbPoetica.TabIndex = 21;
            this.ckbPoetica.Text = "Poetica";
            this.ckbPoetica.UseVisualStyleBackColor = true;
            this.ckbPoetica.CheckedChanged += new System.EventHandler(this.ckbGen_CheckedChanged);
            // 
            // ckbFolclor
            // 
            this.ckbFolclor.AutoSize = true;
            this.ckbFolclor.Location = new System.Drawing.Point(288, 83);
            this.ckbFolclor.Name = "ckbFolclor";
            this.ckbFolclor.Size = new System.Drawing.Size(83, 22);
            this.ckbFolclor.TabIndex = 21;
            this.ckbFolclor.Text = "Folclor";
            this.ckbFolclor.UseVisualStyleBackColor = true;
            this.ckbFolclor.CheckedChanged += new System.EventHandler(this.ckbGen_CheckedChanged);
            // 
            // ckbFictiune
            // 
            this.ckbFictiune.AutoSize = true;
            this.ckbFictiune.Location = new System.Drawing.Point(147, 83);
            this.ckbFictiune.Name = "ckbFictiune";
            this.ckbFictiune.Size = new System.Drawing.Size(89, 22);
            this.ckbFictiune.TabIndex = 21;
            this.ckbFictiune.Text = "Fictiune";
            this.ckbFictiune.UseVisualStyleBackColor = true;
            this.ckbFictiune.CheckedChanged += new System.EventHandler(this.ckbGen_CheckedChanged);
            // 
            // ckbFantezie
            // 
            this.ckbFantezie.AutoSize = true;
            this.ckbFantezie.Location = new System.Drawing.Point(7, 83);
            this.ckbFantezie.Name = "ckbFantezie";
            this.ckbFantezie.Size = new System.Drawing.Size(94, 22);
            this.ckbFantezie.TabIndex = 21;
            this.ckbFantezie.Text = "Fantezie";
            this.ckbFantezie.UseVisualStyleBackColor = true;
            this.ckbFantezie.CheckedChanged += new System.EventHandler(this.ckbGen_CheckedChanged);
            // 
            // ckbReligie
            // 
            this.ckbReligie.AutoSize = true;
            this.ckbReligie.Location = new System.Drawing.Point(288, 55);
            this.ckbReligie.Name = "ckbReligie";
            this.ckbReligie.Size = new System.Drawing.Size(81, 22);
            this.ckbReligie.TabIndex = 21;
            this.ckbReligie.Text = "Religie";
            this.ckbReligie.UseVisualStyleBackColor = true;
            this.ckbReligie.CheckedChanged += new System.EventHandler(this.ckbGen_CheckedChanged);
            // 
            // ckbGroaza
            // 
            this.ckbGroaza.AutoSize = true;
            this.ckbGroaza.Location = new System.Drawing.Point(147, 55);
            this.ckbGroaza.Name = "ckbGroaza";
            this.ckbGroaza.Size = new System.Drawing.Size(86, 22);
            this.ckbGroaza.TabIndex = 21;
            this.ckbGroaza.Text = "Groaza";
            this.ckbGroaza.UseVisualStyleBackColor = true;
            this.ckbGroaza.CheckedChanged += new System.EventHandler(this.ckbGen_CheckedChanged);
            // 
            // ckbUmoristic
            // 
            this.ckbUmoristic.AutoSize = true;
            this.ckbUmoristic.Location = new System.Drawing.Point(7, 55);
            this.ckbUmoristic.Name = "ckbUmoristic";
            this.ckbUmoristic.Size = new System.Drawing.Size(103, 22);
            this.ckbUmoristic.TabIndex = 21;
            this.ckbUmoristic.Text = "Umoristic";
            this.ckbUmoristic.UseVisualStyleBackColor = true;
            this.ckbUmoristic.CheckedChanged += new System.EventHandler(this.ckbGen_CheckedChanged);
            // 
            // ckbDragoste
            // 
            this.ckbDragoste.AutoSize = true;
            this.ckbDragoste.Location = new System.Drawing.Point(288, 27);
            this.ckbDragoste.Name = "ckbDragoste";
            this.ckbDragoste.Size = new System.Drawing.Size(99, 22);
            this.ckbDragoste.TabIndex = 21;
            this.ckbDragoste.Text = "Dragoste";
            this.ckbDragoste.UseVisualStyleBackColor = true;
            this.ckbDragoste.CheckedChanged += new System.EventHandler(this.ckbGen_CheckedChanged);
            // 
            // ckbCriminalistic
            // 
            this.ckbCriminalistic.AutoSize = true;
            this.ckbCriminalistic.Location = new System.Drawing.Point(147, 27);
            this.ckbCriminalistic.Name = "ckbCriminalistic";
            this.ckbCriminalistic.Size = new System.Drawing.Size(123, 22);
            this.ckbCriminalistic.TabIndex = 21;
            this.ckbCriminalistic.Text = "Criminalistic";
            this.ckbCriminalistic.UseVisualStyleBackColor = true;
            this.ckbCriminalistic.CheckedChanged += new System.EventHandler(this.ckbGen_CheckedChanged);
            // 
            // ckbCopii
            // 
            this.ckbCopii.AutoSize = true;
            this.ckbCopii.Location = new System.Drawing.Point(7, 27);
            this.ckbCopii.Name = "ckbCopii";
            this.ckbCopii.Size = new System.Drawing.Size(69, 22);
            this.ckbCopii.TabIndex = 21;
            this.ckbCopii.Text = "Copii";
            this.ckbCopii.UseVisualStyleBackColor = true;
            this.ckbCopii.CheckedChanged += new System.EventHandler(this.ckbGen_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(953, 573);
            this.Controls.Add(this.gpbGenul);
            this.Controls.Add(this.gpbLimba);
            this.Controls.Add(this.btnCartiDisponibile);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.rtbAfisare);
            this.Controls.Add(this.btnAfisare);
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
            this.gpbLimba.ResumeLayout(false);
            this.gpbLimba.PerformLayout();
            this.gpbGenul.ResumeLayout(false);
            this.gpbGenul.PerformLayout();
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
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.RichTextBox rtbAfisare;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCartiDisponibile;
        private System.Windows.Forms.GroupBox gpbLimba;
        private System.Windows.Forms.RadioButton rbRusa;
        private System.Windows.Forms.RadioButton rbFranceza;
        private System.Windows.Forms.RadioButton rbItaliana;
        private System.Windows.Forms.RadioButton rbEngleza;
        private System.Windows.Forms.RadioButton rbGermana;
        private System.Windows.Forms.RadioButton rbRomana;
        private System.Windows.Forms.GroupBox gpbGenul;
        private System.Windows.Forms.CheckBox ckbMitologie;
        private System.Windows.Forms.CheckBox ckbIstoric;
        private System.Windows.Forms.CheckBox ckbPoetica;
        private System.Windows.Forms.CheckBox ckbFolclor;
        private System.Windows.Forms.CheckBox ckbFictiune;
        private System.Windows.Forms.CheckBox ckbFantezie;
        private System.Windows.Forms.CheckBox ckbReligie;
        private System.Windows.Forms.CheckBox ckbGroaza;
        private System.Windows.Forms.CheckBox ckbUmoristic;
        private System.Windows.Forms.CheckBox ckbDragoste;
        private System.Windows.Forms.CheckBox ckbCriminalistic;
        private System.Windows.Forms.CheckBox ckbCopii;
    }
}

