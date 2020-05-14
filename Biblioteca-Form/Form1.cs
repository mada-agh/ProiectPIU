using System;
using System.Drawing;
using System.Windows.Forms;
using NivelAccesDate1;
using LibrarieModele;
using System.Collections.Generic;

namespace Biblioteca_Form
{
    public partial class Form1 : Form
    {
        IStocareData1 adminCarti;
        List<string> genuriSelectate = new List<string>();
        public Form1()
        {
            InitializeComponent();
            adminCarti = StocareFactory.GetAdministratorStocare1();
            Carte.NextID = adminCarti.NrCarti();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();
            CodEroare validare = Validare();

            if (validare == CodEroare.CORECT)

            {
                Carte c = new Carte(txtTitlu.Text, txtAutor.Text, txtEditura.Text, Convert.ToInt32(cmbNrExemplare.Text));
                c.Limba = GetSelectedLimba();
                c.Gen = new List<string>();
                c.Gen.AddRange(genuriSelectate);
                lblInfo.Text = "Cartea a fost adăugată";
                adminCarti.AddCarte(c);
            }
            else
            {
                MarcheazaControaleCuDateIncorecte(validare);
            }
            ResetareControale();
        }
        public CodEroare Validare()
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (txtTitlu.Text == string.Empty)
            {
                rezultatValidare |= CodEroare.TITLU_INCORECT;
            }
            if (txtAutor.Text == string.Empty)
            {
                rezultatValidare |= CodEroare.AUTOR_INCORECT;
            }
            if (txtEditura.Text == string.Empty)
            {
                rezultatValidare |= CodEroare.EDITURA_INCORECTA;
            }
            if (cmbNrExemplare.Text == string.Empty || Int32.TryParse(cmbNrExemplare.Text, out int rez) == false)
            {
                rezultatValidare|= CodEroare.EXEMPLARE_INCORECT;
            }
            if (GetSelectedLimba() == LimbaCarte.Nedefinit)
                rezultatValidare |= CodEroare.LIMBA_NESELECTATA;
            return rezultatValidare;
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            lstAfisare.Items.Clear();
            var antetTabel = String.Format("{0,-5}{1,-40}{2,20}\n", "Id", "Titlu și Autor", "Număr exemplare");
            lstAfisare.Items.Add(antetTabel);

            List<Carte> carti = adminCarti.GetCarti();
            foreach (Carte s in carti)
            {
                var linieTabel = String.Format("{0,-5}{1,-40}{2,20}\n", s.Cod, s.NumeComplet, s.NumarExemplare.ToString());
                lstAfisare.Items.Add(linieTabel);
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            Carte carte = adminCarti.GetCarte(txtTitlu.Text, txtAutor.Text);
            if (carte != null)
                lblInfo.Text = carte.ConversieLaSir();
            else
                lblInfo.Text = "Nu s-a găsit cartea";
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            FormularModificaCarte frm = new FormularModificaCarte(lblID.Text);
            frm.ShowDialog();
        }

        private void btnCartiDisponibile_Click(object sender, EventArgs e)
        {
            Carte carte = adminCarti.GetCarte(txtTitlu.Text, txtAutor.Text);
            if (carte != null)
            {
                lblInfo.Text = carte.CartiDisponibile.ToString();
            }
            else
                lblInfo.Text = "Nu s-a găsit această carte";
        }
        public void ResetCuloareEtichete()
        {
            lblTitlu.ForeColor = SystemColors.ButtonFace;
            lblAutor.ForeColor = SystemColors.ButtonFace;
            lblEditura.ForeColor = SystemColors.ButtonFace;
            lblNrExemplare.ForeColor = SystemColors.ButtonFace;
            gpbLimba.ForeColor = SystemColors.ButtonFace;
        }
        private LimbaCarte GetSelectedLimba()
        {
            if (rbRomana.Checked)
                return LimbaCarte.Romana;
            if (rbEngleza.Checked)
                return LimbaCarte.Engleza;
            if (rbFranceza.Checked)
                return LimbaCarte.Franceza;
            if (rbGermana.Checked)
                return LimbaCarte.Germana;
            if (rbItaliana.Checked)
                return LimbaCarte.Italiana;
            if (rbRusa.Checked)
                return LimbaCarte.Rusa;
            return LimbaCarte.Nedefinit;
        }
        public void MarcheazaControaleCuDateIncorecte(CodEroare validare)
        {
            if ((validare & CodEroare.TITLU_INCORECT) == CodEroare.TITLU_INCORECT)
            {
                lblTitlu.ForeColor = Color.Red;
            }
            if ((validare & CodEroare.AUTOR_INCORECT) == CodEroare.AUTOR_INCORECT)
            {
                lblAutor.ForeColor = Color.Red;
            }
            if ((validare & CodEroare.EDITURA_INCORECTA) == CodEroare.EDITURA_INCORECTA)
            {
                lblEditura.ForeColor = Color.Red;
            }
            if ((validare & CodEroare.LIMBA_NESELECTATA) == CodEroare.LIMBA_NESELECTATA)
            {
                gpbLimba.ForeColor = Color.Red;
                rbEngleza.ForeColor = SystemColors.ButtonFace;
                rbFranceza.ForeColor = SystemColors.ButtonFace;
                rbRomana.ForeColor = SystemColors.ButtonFace;
                rbGermana.ForeColor = SystemColors.ButtonFace;
                rbRusa.ForeColor = SystemColors.ButtonFace;
                rbItaliana.ForeColor = SystemColors.ButtonFace;
            }
        }

        private void ckbGen_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;
            string genSelectat = checkBoxControl.Text;
            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                genuriSelectate.Add(genSelectat);
            else
                genuriSelectate.Remove(genSelectat);
        }
        private void ResetareControale()
        {
            txtAutor.Text = txtTitlu.Text = txtEditura.Text = cmbNrExemplare.Text = string.Empty;
            rbEngleza.Checked = false;
            rbFranceza.Checked = false;
            rbGermana.Checked = false;
            rbItaliana.Checked = false;
            rbRomana.Checked = false;
            rbRusa.Checked = false;
            ckbCopii.Checked = false;
            ckbCriminalistic.Checked = false;
            ckbDragoste.Checked = false;
            ckbFantezie.Checked = false;
            ckbFictiune.Checked = false;
            ckbFolclor.Checked = false;
            ckbGroaza.Checked = false;
            ckbIstoric.Checked = false;
            ckbMitologie.Checked = false;
            ckbPoetica.Checked = false;
            ckbReligie.Checked = false;
            ckbUmoristic.Checked = false;
            genuriSelectate.Clear();
            lblInfo.Text = string.Empty;
            lblID.Text = string.Empty;
        }

        private void lstAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetareControale();
            Carte s = adminCarti.GetCarteByIndex(lstAfisare.SelectedIndex - 1);

            if (s != null)
            {
                lblID.Text = s.Cod.ToString();

                txtTitlu.Text = s.Titlu;
                txtAutor.Text = s.Autor;
                txtEditura.Text = s.Editura;

                foreach (var lim in gpbLimba.Controls)
                {
                    if (lim is RadioButton)
                    {
                        var limBox = lim as RadioButton;
                        if (limBox.Text == s.Limba.ToString())
                        {
                            limBox.Checked = true;
                        }
                    }
                }

                foreach (var genul in gpbGenul.Controls)
                {
                    if (genul is CheckBox)
                    {
                        var genBox = genul as CheckBox;
                        foreach (String dis in s.Gen)
                            if (genBox.Text.Equals(dis))
                                genBox.Checked = true;
                    }
                }

                cmbNrExemplare.Text = s.NumarExemplare.ToString();
            }
        }
    }
}
