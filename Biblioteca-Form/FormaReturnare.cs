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
    public partial class FormaReturnare : MetroFramework.Forms.MetroForm
    {
        IStocareData1 adminCarti;
        IStocareData2 adminCititori;
        public FormaReturnare(int codCititor)
        {
            InitializeComponent();
            lblID.Text = codCititor.ToString();
            adminCarti = StocareFactory.GetAdministratorStocare1();
            adminCititori = StocareFactory.GetAdministratorStocare2();
            AfiseazaLista();
        }

        private void mtReturneaza_Click(object sender, EventArgs e)
        {
            Cititor cititor = adminCititori.GetCititorByIndex(Int32.Parse(lblID.Text));
            for (int i = 0; i <= cititor.NrCarti; i++)
            {
                Carte carte = adminCarti.GetCarteByIndex(cititor.imprumutID[i]);
                if (carte.NumeComplet.Equals(lstCarti.SelectedItem.ToString()))
                {
                    cititor.Returnare(carte);
                    adminCarti.UpdateCarte(carte);
                    adminCititori.UpdateCititor(cititor);
                    break;
                }
            }
            AfiseazaLista();
        }
        private void AfiseazaLista()
        {
            lstCarti.Items.Clear();
            Cititor cititor = adminCititori.GetCititorByIndex(Int32.Parse(lblID.Text));
            if (cititor.NrCarti == 0)
                this.Close();
            for(int i=0; i<cititor.NrCarti; i++)
            {
                Carte carte = adminCarti.GetCarteByIndex(cititor.imprumutID[i]);
                if (carte != null)
                {
                    lstCarti.Items.Add(carte.NumeComplet);
                }
            }
        }
    }
}
