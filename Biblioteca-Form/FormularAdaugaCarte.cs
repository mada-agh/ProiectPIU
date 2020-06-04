//Agheorghiesei Madalina, grupa 3123A
using System;
using System.Collections.Generic;
using System.Drawing;
using LibrarieModele;
using NivelAccesDate1;
using System.Windows.Forms;

namespace Biblioteca_Form
{
    public partial class FormularAdaugaCarte : MetroFramework.Forms.MetroForm
    {
        IStocareData1 adminCarti;
        List<string> genuriSelectate = new List<string>();
        public FormularAdaugaCarte()
        {
            InitializeComponent();
            adminCarti = StocareFactory.GetAdministratorStocare1();
            Carte.NextID = adminCarti.NrCarti();
        }

        private void mtAdauga_Click(object sender, EventArgs e)
        {
            CodEroare validare = Validare();

            if (validare == CodEroare.CORECT)

            {
                Carte c = new Carte(mtxtTitlu.Text, mtxtAutor.Text, mtxtEditura.Text, Convert.ToInt32(dudNrExemplare.Text));
                c.Limba = GetSelectedLimba();
                c.Gen = new List<string>();
                c.Gen.AddRange(genuriSelectate);
                adminCarti.AddCarte(c);
                this.Close();
            }
            else
            {
                MarcheazaControaleCuDateIncorecte(validare);
            }
        }
        public void ResetCuloareEtichete()
        {
            mlblTitlu.ForeColor = Color.Gold;
            mlblAutor.ForeColor = Color.Gold;
            mlblEditura.ForeColor = Color.Gold;
            mlblNrExemplare.ForeColor = Color.Gold;
            gpbLimba.ForeColor = Color.Gold;
        }
        public CodEroare Validare()
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (mtxtTitlu.Text == string.Empty)
            {
                rezultatValidare |= CodEroare.TITLU_INCORECT;
            }
            if (mtxtAutor.Text == string.Empty)
            {
                rezultatValidare |= CodEroare.AUTOR_INCORECT;
            }
            if (mtxtEditura.Text == string.Empty)
            {
                rezultatValidare |= CodEroare.EDITURA_INCORECTA;
            }
            if (dudNrExemplare.Text == string.Empty)
            {
                rezultatValidare |= CodEroare.EXEMPLARE_INCORECT;
            }
            if (GetSelectedLimba() == LimbaCarte.Nedefinit)
                rezultatValidare |= CodEroare.LIMBA_NESELECTATA;
            return rezultatValidare;
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
                mlblTitlu.ForeColor = Color.Red;
            }
            if ((validare & CodEroare.AUTOR_INCORECT) == CodEroare.AUTOR_INCORECT)
            {
                mlblAutor.ForeColor = Color.Red;
            }
            if ((validare & CodEroare.EDITURA_INCORECTA) == CodEroare.EDITURA_INCORECTA)
            {
                mlblEditura.ForeColor = Color.Red;
            }
            if ((validare & CodEroare.LIMBA_NESELECTATA) == CodEroare.LIMBA_NESELECTATA)
            {
                gpbLimba.ForeColor = Color.Red;
                rbEngleza.ForeColor = Color.Gold;
                rbFranceza.ForeColor = Color.Gold;
                rbRomana.ForeColor = Color.Gold;
                rbGermana.ForeColor = Color.Gold;
                rbRusa.ForeColor = Color.Gold;
                rbItaliana.ForeColor = Color.Gold;
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
    }
}
