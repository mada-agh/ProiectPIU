//Agheorghiesei Madalina, grupa 3123A
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate2;

namespace Biblioteca_Form
{
    public partial class FormaCititori : MetroFramework.Forms.MetroForm
    {
        IStocareData2 adminCititori;
        public FormaCititori()
        {
            InitializeComponent();
            adminCititori = StocareFactory.GetAdministratorStocare2();
            Cititor.NextID = adminCititori.NrCititori();
            List<Cititor> cititori = adminCititori.GetCititori();
            AfiseazaMetroGrid(cititori);
        }

        private void mtAdauga_Click(object sender, EventArgs e)
        {
            FormaAdaugaCititor frmAdauga = new FormaAdaugaCititor();
            frmAdauga.ShowDialog();
        }
        public void AfiseazaMetroGrid(List<Cititor> cititori)
        {
            metroGridCititori.DataSource = null;
            metroGridCititori.DataSource = cititori.Select(s => new { s.Cod, s.Nume, s.Prenume, s.CNP, s.NrTelefon, s.Adresa,s.NrCarti, Imprumuturi=string.Join(",", s.imprumutID) }).ToList();
        }

        private void mtResetLista_Click(object sender, EventArgs e)
        {
            List<Cititor> cititori = adminCititori.GetCititori();
            AfiseazaMetroGrid(cititori);
        }

        private void mtImprumut_Click(object sender, EventArgs e)
        {
            Cititor c = adminCititori.GetCititorByIndex(Convert.ToInt32(metroGridCititori.CurrentRow.Cells[0].Value));
            if (c.NrMaxCarti() == true)
            {
                MessageBox.Show("Cititorul a ajuns la numărul maxim de cărți împrumutate!");
            }
            else
            {
                FormaImprumuta frm = new FormaImprumuta(Convert.ToInt32(metroGridCititori.CurrentRow.Cells[0].Value));
                frm.ShowDialog();
            }
        }

        private void mtReturneaza_Click(object sender, EventArgs e)
        {
            Cititor c = adminCititori.GetCititorByIndex(Convert.ToInt32(metroGridCititori.CurrentRow.Cells[0].Value));
            if (c.NrCarti == 0)
            {
                MessageBox.Show("Cititorul nu are cărți împrumutate!");
            }
            else
            {
                FormaReturnare frm = new FormaReturnare(Convert.ToInt32(metroGridCititori.CurrentRow.Cells[0].Value));
                frm.ShowDialog();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
            frm.Show();
            this.Hide();
        }

        private void mtCautaCititor_Click(object sender, EventArgs e)
        {
            FormaCautaCititor frm = new FormaCautaCititor();
            frm.ShowDialog();
        }

        private void mtStergeCititor_Click(object sender, EventArgs e)
        {
            Cititor cititor = adminCititori.GetCititorByIndex(Convert.ToInt32(metroGridCititori.CurrentRow.Cells[0].Value));
            adminCititori.StergeCititor(cititor);
            List<Cititor> cititori = adminCititori.GetCititori();
            AfiseazaMetroGrid(cititori);
        }

        private void mtModifica_Click(object sender, EventArgs e)
        {
            FormaModificaCititor frm = new FormaModificaCititor(Convert.ToInt32(metroGridCititori.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            List<Cititor> cititori = adminCititori.GetCititori();
            AfiseazaMetroGrid(cititori);
        }
    }
}
