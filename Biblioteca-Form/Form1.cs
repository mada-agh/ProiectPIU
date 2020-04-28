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
        public Form1()
        {
            InitializeComponent();
            adminCarti = StocareFactory.GetAdministratorStocare1();
            Carte.NextID = adminCarti.NrCarti();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            CodEroare validare = Validare();

            txtTitlu.BackColor = Color.White;
            txtAutor.BackColor = Color.White;
            txtEditura.BackColor = Color.White;
            txtNrExemplare.BackColor = Color.White;

            if (validare == CodEroare.CORECT)

            {
                Carte c = new Carte(txtTitlu.Text, txtAutor.Text, txtEditura.Text, Convert.ToInt32(txtNrExemplare.Text));
                lblAdauga.Text = "Cartea a fost adăugată";
                adminCarti.AddCarte(c);
            }
            else
            {

                switch (validare)
                {
                    case CodEroare.TITLU_INCORECT:
                        txtTitlu.BackColor = Color.LightCoral;
                        break;
                    case CodEroare.AUTOR_INCORECT:
                        txtAutor.BackColor = Color.LightCoral;
                        break;
                    case CodEroare.EDITURA_INCORECTA:
                        txtEditura.BackColor = Color.LightCoral;
                        break;
                    case CodEroare.EXEMPLARE_INCORECT:
                        txtNrExemplare.BackColor = Color.LightCoral;
                        break;
                    default:
                        break;
                }

            }
        }
        private CodEroare Validare()
        {
            if (txtTitlu.Text == string.Empty)
            {
                return CodEroare.TITLU_INCORECT;
            }
            else if (txtAutor.Text == string.Empty)
            {
                return CodEroare.AUTOR_INCORECT;
            }
            else if (txtEditura.Text == string.Empty)
            {
                return CodEroare.EDITURA_INCORECTA;
            }
            else if (txtNrExemplare.Text == string.Empty || Int32.TryParse(txtNrExemplare.Text, out int rez) == false)
            {
                return CodEroare.EXEMPLARE_INCORECT;
            }


            return CodEroare.CORECT;
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
                lblCauta.Text = carte.ConversieLaSir();
            else
                lblCauta.Text = "Nu s-a găsit cartea";
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
                        lblModifica.Text = "S-a modificat cu succes!";
                    else
                        lblModifica.Text = "Nu s-a putut actualiza";
                }
                else
                    lblModifica.Text = "Nu ați introdus un număr valid";
            }
            else
                lblModifica.Text = "Nu s-a găsit această carte";
        }

        private void btnCartiDisponibile_Click(object sender, EventArgs e)
        {
            Carte carte = adminCarti.GetCarte(txtTitlu.Text, txtAutor.Text);
            if (carte != null)
            {
                lblCartiDisponibile.Text = carte.CartiDisponibile.ToString();
            }
            else
                lblModifica.Text = "Nu s-a găsit această carte";
        }
    }
}
