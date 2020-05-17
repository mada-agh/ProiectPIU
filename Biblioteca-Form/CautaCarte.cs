using System;
using LibrarieModele;
using NivelAccesDate1;

namespace Biblioteca_Form
{
    public partial class CautaCarte : MetroFramework.Forms.MetroForm
    {
        IStocareData1 adminCarti;
        public CautaCarte()
        {
            InitializeComponent();
            adminCarti = StocareFactory.GetAdministratorStocare1();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Carte carte = adminCarti.GetCarte(mtxtTitlu.Text, mtxtAutor.Text);
            if (carte != null)
                metroLabel3.Text = carte.ConversieLaSir();
            else
                metroLabel3.Text = "Nu s-a găsit cartea";
        }

        private void mtCartiDisponibile_Click(object sender, EventArgs e)
        {
            Carte carte = adminCarti.GetCarte(mtxtTitlu.Text, mtxtAutor.Text);
            if (carte != null)
                metroLabel3.Text = carte.CartiDisponibile.ToString();
            else
                metroLabel3.Text = "Nu s-a găsit cartea";
        }
    }
}
