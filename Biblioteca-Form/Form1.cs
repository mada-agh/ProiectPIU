//Agheorghiesei Madalina, grupa 3123A
using System;
using System.Linq;
using NivelAccesDate1;
using LibrarieModele;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Biblioteca_Form
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        IStocareData1 adminCarti;
        List<string> genuriSelectate = new List<string>();
        public Form1()
        {
            InitializeComponent();
            adminCarti = StocareFactory.GetAdministratorStocare1();
            Carte.NextID = adminCarti.NrCarti();
            List<Carte> carti = adminCarti.GetCarti();
            AfiseazaMetroGrid(carti);
        }

        private void mtAdauga_Click(object sender, EventArgs e)
        {
            FormularAdaugaCarte frmAdauga = new FormularAdaugaCarte();
            frmAdauga.ShowDialog();
        } 
        public void AfiseazaMetroGrid(List<Carte> carti)
        {
            metroGridCarti.DataSource = null;
            metroGridCarti.DataSource = carti.Select(s => new { s.Cod, s.Titlu, s.Autor, s.Editura, Limba=s.Limba.ToString(),Genuri = string.Join(",", s.Gen), s.NumarExemplare, s.dataActualizare }).ToList();
        }

        private void mtModifica_Click(object sender, EventArgs e)
        {
            FormularModificaCarte frm = new FormularModificaCarte(Convert.ToInt32(metroGridCarti.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            List<Carte> carti = adminCarti.GetCarti();
            AfiseazaMetroGrid(carti);
        }

        private void mtCautare_Click(object sender, EventArgs e)
        {
            CautaCarte frm = new CautaCarte();
            frm.ShowDialog();
        }

        private void mtCartiDisponibile_Click(object sender, EventArgs e)
        {
            FormaCartiDisponibile frm = new FormaCartiDisponibile(Convert.ToInt32(metroGridCarti.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void mtCautaDataActualizarii_Click(object sender, EventArgs e)
        {
            FormaDataActualizarii frm = new FormaDataActualizarii();
            frm.ShowDialog();
            AfiseazaMetroGrid(FormaDataActualizarii.incadrate);
        }

        private void mtResetLista_Click(object sender, EventArgs e)
        {
            List<Carte> carti = adminCarti.GetCarti();
            AfiseazaMetroGrid(carti);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
            frm.Show();
            this.Hide();
        }

        private void mtImprumuta_Click(object sender, EventArgs e)
        {
            Carte carte = adminCarti.GetCarteByIndex(Convert.ToInt32(metroGridCarti.CurrentRow.Cells[0].Value));
            if (carte.CartiDisponibile <= 0)
            {
                MessageBox.Show("Nu sunt cărți disponibile la moment!");
            }
            else
            {
                FormaImprumutaCarte frm = new FormaImprumutaCarte(Convert.ToInt32(metroGridCarti.CurrentRow.Cells[0].Value));
                frm.ShowDialog();
            }
        }

        private void mtSterge_Click(object sender, EventArgs e)
        {
            Carte carte = adminCarti.GetCarteByIndex(Convert.ToInt32(metroGridCarti.CurrentRow.Cells[0].Value));
            adminCarti.StergeCarte(carte);
            List<Carte> carti = adminCarti.GetCarti();
            AfiseazaMetroGrid(carti);
        }
    }
}
