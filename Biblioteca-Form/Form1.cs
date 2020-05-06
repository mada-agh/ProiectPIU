using System;
using System.Drawing;
using System.Windows.Forms;
using NivelAccesDate1;
using LibrarieModele;
using System.Collections;

namespace Biblioteca_Form
{
    public partial class Form1 : Form
    {
        IStocareData1 adminCarti;
        GenCarte genuriSelectate;
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
                Carte c = new Carte(txtTitlu.Text, txtAutor.Text, txtEditura.Text, Convert.ToInt32(txtNrExemplare.Text));
                c.Limba = GetSelectedLimba();
                c.Gen = genuriSelectate;
                lblInfo.Text = "Cartea a fost adăugată";
                adminCarti.AddCarte(c);
            }
            else
            {
                MarcheazaControaleCuDateIncorecte(validare);
            }
            ResetareControale();
        }
        private CodEroare Validare()
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
            if (txtNrExemplare.Text == string.Empty || Int32.TryParse(txtNrExemplare.Text, out int rez) == false)
            {
                rezultatValidare|= CodEroare.EXEMPLARE_INCORECT;
            }
            if (GetSelectedLimba() == LimbaCarte.Nedefinit)
                rezultatValidare |= CodEroare.LIMBA_NESELECTATA;
            return rezultatValidare;
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            rtbAfisare.Text=string.Empty;
            ArrayList carti = adminCarti.GetCarti();
            foreach (Carte s in carti)
            {
                rtbAfisare.Text += s.ConversieLaSir();
                rtbAfisare.Text += "\n";
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
            Carte carte = adminCarti.GetCarte(txtTitlu.Text, txtAutor.Text);
            if (carte != null)
            {
                int n;
                bool rez = Int32.TryParse(txtNrExemplare.Text, out n);
                if (rez == true)
                {
                    carte.NumarExemplare = n;
                    if (adminCarti.UpdateCarte(carte) == true)
                        lblInfo.Text = "S-a modificat cu succes!";
                    else
                        lblInfo.Text = "Nu s-a putut actualiza";
                }
                else
                    lblInfo.Text = "Nu ați introdus un număr valid";
            }
            else
                lblInfo.Text = "Nu s-a găsit această carte";
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
        private void ResetCuloareEtichete()
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
        private void MarcheazaControaleCuDateIncorecte(CodEroare validare)
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
            }
        }

        private void ckbGen_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;
            if (checkBoxControl.Checked == true)
                genuriSelectate |= (GenCarte)Enum.Parse(typeof(GenCarte),checkBoxControl.Text);
            else
                genuriSelectate &= ~(GenCarte)Enum.Parse(typeof(GenCarte), checkBoxControl.Text);
        }
        private void ResetareControale()
        {
            txtAutor.Text = txtTitlu.Text = txtEditura.Text = txtNrExemplare.Text = string.Empty;
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
            genuriSelectate = genuriSelectate & ~genuriSelectate;
            lblInfo.Text = string.Empty;
        }
    }
}
