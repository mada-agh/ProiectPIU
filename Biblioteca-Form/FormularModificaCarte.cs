using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate1;

namespace Biblioteca_Form
{
    public partial class FormularModificaCarte : Form
    {
        //Form1 formularCarte;
        IStocareData1 adminCarti;
        List<string> genuriSelectate = new List<string>();
        public FormularModificaCarte(string codCarte)
        {
            InitializeComponent();
            lblID.Text = codCarte;
            adminCarti = StocareFactory.GetAdministratorStocare1();
            Carte.NextID = adminCarti.NrCarti();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();

            CodEroare codValidare = Validare();

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else
            {
                Carte s = new Carte(txtTitlu.Text, txtAutor.Text, txtEditura.Text, Int32.Parse(cmbNrExemplare.Text));
                s.Cod = Int32.Parse(lblID.Text);

                //verificare radioButton selectat
                s.Limba = GetSelectedLimba();
                //set Discipline
                s.Gen = new List<string>();
                s.Gen.AddRange(genuriSelectate);

                adminCarti.UpdateCarte(s);

                //resetarea controalelor pentru a introduce datele unui student nou
                this.Close();
            }
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
        public void ResetCuloareEtichete()
        {
            lblTitlu.ForeColor = SystemColors.ButtonFace;
            lblAutor.ForeColor = SystemColors.ButtonFace;
            lblEditura.ForeColor = SystemColors.ButtonFace;
            lblNrExemplare.ForeColor = SystemColors.ButtonFace;
            gpbLimba.ForeColor = SystemColors.ButtonFace;
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
                rezultatValidare |= CodEroare.EXEMPLARE_INCORECT;
            }
            if (GetSelectedLimba() == LimbaCarte.Nedefinit)
                rezultatValidare |= CodEroare.LIMBA_NESELECTATA;
            return rezultatValidare;
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
    }
}
