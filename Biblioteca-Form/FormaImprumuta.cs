//Agheorghiesei Madalina, grupa 3123A
using NivelAccesDate1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate2;
using LibrarieModele;

namespace Biblioteca_Form
{
    public partial class FormaImprumuta : MetroFramework.Forms.MetroForm
    {
        IStocareData1 adminCarti;
        IStocareData2 adminCititori;
        public FormaImprumuta(int codCititor)
        {
            InitializeComponent();
            adminCarti = StocareFactory.GetAdministratorStocare1();
            adminCititori = StocareFactory.GetAdministratorStocare2();
            lblID.Text = codCititor.ToString();
        }

        private void mtImprumuta_Click(object sender, EventArgs e)
        {
            Carte carte = adminCarti.GetCarte(mtxtTitlu.Text, mtxtAutor.Text);
            if (carte != null)
            {
                if (carte.CartiDisponibile <= 0) 
                {
                    mlblInfo.Text = "Nu sunt carti disponibile!";
                }
                else
                {
                    Cititor cititor = adminCititori.GetCititorByIndex(Int32.Parse(lblID.Text));
                    cititor.NouImprumut(carte);
                    adminCarti.UpdateCarte(carte);
                    adminCititori.UpdateCititor(cititor);
                    this.Close();
                }
            }
            else
                mlblInfo.Text = "Nu s-a găsit cartea";
        }
    }
}
