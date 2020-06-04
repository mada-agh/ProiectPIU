//Agheorghiesei Madalina, grupa 3123A
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate2;

namespace Biblioteca_Form
{
    public partial class FormaCautaCititor : MetroFramework.Forms.MetroForm
    {
        IStocareData2 adminCititori;
        public FormaCautaCititor()
        {
            InitializeComponent();
            adminCititori = StocareFactory.GetAdministratorStocare2();
        }

        private void mtCauta_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();
            MarcheazaControaleCuDateIncorecte(Validare());

            Cititor cititor = adminCititori.GetCititor(mtxtNume.Text, mtxtPrenume.Text);
            if (cititor != null)
            {
                mlblInfo.Text = cititor.ConversieLaSir();
                lblID.Text = cititor.Cod.ToString();
                mtReturneaza.Visible = true;
                mtImprumut.Visible = true;
            }
            else
            {
                mlblInfo.Text = "Nu s-a găsit cititorul!";
                mtImprumut.Visible = false;
                mtReturneaza.Visible = false;
            }
        }

        private void mtImprumut_Click(object sender, EventArgs e)
        {
            Cititor c = adminCititori.GetCititorByIndex(Int32.Parse(lblID.Text));
            if (c.NrMaxCarti() == true)
            {
                MessageBox.Show("Cititorul a ajuns la numărul maxim de cărți împrumutate!");
            }
            else
            {
                FormaImprumuta frm = new FormaImprumuta(Int32.Parse(lblID.Text));
                frm.ShowDialog();
            }
        }

        private void mtReturneaza_Click(object sender, EventArgs e)
        {
            Cititor c = adminCititori.GetCititorByIndex(Int32.Parse(lblID.Text));
            if (c.NrCarti == 0)
            {
                MessageBox.Show("Cititorul nu are cărți împrumutate!");
            }
            else
            {
                FormaReturnare frm = new FormaReturnare(Int32.Parse(lblID.Text));
                frm.ShowDialog();
            }
        }
        private void ResetCuloareEtichete()
        {
            mlblNume.ForeColor = Color.Gold;
            mlblPrenume.ForeColor = Color.Gold;
        }
        public CodEroare Validare()
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (mtxtNume.Text == string.Empty)
            {
                rezultatValidare |= CodEroare.NUME_INCORECT;
            }
            if (mtxtPrenume.Text == string.Empty)
            {
                rezultatValidare |= CodEroare.PRENUME_INCORECT;
            }
            return rezultatValidare;
        }
        public void MarcheazaControaleCuDateIncorecte(CodEroare validare)
        {
            if ((validare & CodEroare.NUME_INCORECT) == CodEroare.NUME_INCORECT)
            {
                mlblNume.ForeColor = Color.Red;
            }
            if ((validare & CodEroare.PRENUME_INCORECT) == CodEroare.PRENUME_INCORECT)
            {
                mlblPrenume.ForeColor = Color.Red;
            }
        }
    }
}
