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
using NivelAccesDate1;
using NivelAccesDate2;

namespace Biblioteca_Form
{
    public partial class FormaImprumutaCarte : MetroFramework.Forms.MetroForm
    {
        IStocareData1 adminCarti;
        IStocareData2 adminCititori;
        public FormaImprumutaCarte(int codCarte)
        {
            InitializeComponent();
            adminCarti = StocareFactory.GetAdministratorStocare1();
            adminCititori = StocareFactory.GetAdministratorStocare2();
            lblID.Text = codCarte.ToString();
        }

        private void mtImprumuta_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();
            MarcheazaControaleCuDateIncorecte(Validare());

            Cititor cititor = adminCititori.GetCititor(mtxtNume.Text, mtxtPrenume.Text);
            if (cititor != null)
            {
                Carte carte = adminCarti.GetCarteByIndex(Int32.Parse(lblID.Text));
                if (cititor.NrMaxCarti() == true)
                {
                    mlblInfo.Text="Cititorul a ajuns la numărul maxim de cărți împrumutate!";
                }
                else
                {
                    
                    cititor.NouImprumut(carte);
                    adminCarti.UpdateCarte(carte);
                    adminCititori.UpdateCititor(cititor);
                    this.Close();
                }
            }
            else
            {
                mlblInfo.Text = "Nu s-a găsit cititorul!";
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
