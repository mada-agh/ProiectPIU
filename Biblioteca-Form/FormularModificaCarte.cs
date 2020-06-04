//Agheorghiesei Madalina, grupa 3123A
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate1;

namespace Biblioteca_Form
{
    public partial class FormularModificaCarte : MetroFramework.Forms.MetroForm
    {
        //Form1 formularCarte;
        IStocareData1 adminCarti;
        List<string> genuriSelectate = new List<string>();
        public FormularModificaCarte(int codCarte)
        {
            InitializeComponent();
            lblID.Text = codCarte.ToString();
            adminCarti = StocareFactory.GetAdministratorStocare1();
            Carte.NextID= adminCarti.NrCarti();
            SetareControale();
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
                Carte s = new Carte(mtxtTitlu.Text, mtxtAutor.Text, mtxtEditura.Text, Int32.Parse(dudNrExemplare.Text));
                s.Cod = Int32.Parse(lblID.Text);
                //verificare radioButton selectat
                s.Limba = GetSelectedLimba();
                //set Discipline
                s.Gen = new List<string>();
                s.Gen.AddRange(genuriSelectate);

                if (adminCarti.UpdateCarte(s) == true)
                {
                    this.Close();
                }
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
        private void SetareControale()
        {
            Carte s = adminCarti.GetCarteByIndex(Int32.Parse(lblID.Text));
            if (s != null)
            {
                mtxtTitlu.Text = s.Titlu;
                mtxtAutor.Text = s.Autor;
                mtxtEditura.Text = s.Editura;

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

                dudNrExemplare.Text = s.NumarExemplare.ToString();
            }
        }

        private void mtModifica_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();

            CodEroare codValidare = Validare();

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else
            {
                Carte s = new Carte(mtxtTitlu.Text, mtxtAutor.Text, mtxtEditura.Text, Int32.Parse(dudNrExemplare.Text));
                s.Cod = Int32.Parse(lblID.Text);

                //verificare radioButton selectat
                s.Limba = GetSelectedLimba();
                //set Discipline
                s.Gen = new List<string>();
                s.Gen.AddRange(genuriSelectate);

                if (adminCarti.UpdateCarte(s) == true)
                {
                    this.Close();
                }
            }
        }
    }
}
