//Agheorghiesei Madalina, grupa 3123A
using System;
using NivelAccesDate1;
using LibrarieModele;
using System.Collections.Generic;
using System.Linq;


namespace Biblioteca_Form
{
    public partial class FormaDataActualizarii : MetroFramework.Forms.MetroForm
    {
        IStocareData1 adminCarti;
        public static List<Carte> incadrate{ get; set; }
        public FormaDataActualizarii()
        {
            InitializeComponent();
            adminCarti = StocareFactory.GetAdministratorStocare1();
            Carte.NextID = adminCarti.NrCarti();
            incadrate = new List<Carte>();
        }

        private void mtOK_Click(object sender, EventArgs e)
        {
            List<Carte> carti = adminCarti.GetCarti();
            foreach(Carte c in carti)
            {
                if ((c.dataActualizare.CompareTo(mdtInceput.Value) >= 0) && (c.dataActualizare.CompareTo(mdtSfarsit.Value) <= 0))
                    incadrate.Add(c);
            }
            this.Close();
        }
    }
}
