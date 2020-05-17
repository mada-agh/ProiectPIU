using System;
using LibrarieModele;
using NivelAccesDate1;

namespace Biblioteca_Form
{
    public partial class FormaCartiDisponibile : MetroFramework.Forms.MetroForm
    {
        IStocareData1 adminCarti;
        public FormaCartiDisponibile(int CodCarte)
        {
            InitializeComponent();
            adminCarti = StocareFactory.GetAdministratorStocare1();
            Carte c = adminCarti.GetCarteByIndex(CodCarte);
            mlblCartiDisponible.Text = c.CartiDisponibile.ToString();
        }

        private void mtOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
