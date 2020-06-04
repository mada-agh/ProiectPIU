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
using NivelAccesDate2;
using LibrarieModele;

namespace Biblioteca_Form
{
    public partial class FormaAdaugaCititor : MetroFramework.Forms.MetroForm
    {
        IStocareData2 adminCititori;
        public FormaAdaugaCititor()
        {
            InitializeComponent();
            adminCititori = StocareFactory.GetAdministratorStocare2();
            Cititor.NextID = adminCititori.NrCititori();
        }

        private void mtAdauga_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();
            CodEroare validare = Validare();

            if (validare == CodEroare.CORECT)

            {
                Cititor c = new Cititor(mtxtNume.Text, mtxtPrenume.Text, mtxtCNP.Text, mtxtNrTelefon.Text, mtxtAdresa.Text);
                adminCititori.AddCititor(c);
                this.Close();
            }
            else
            {
                MarcheazaControaleCuDateIncorecte(validare);
            }
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
            if (mtxtCNP.Text==string.Empty || mtxtCNP.Text.Length != 13 || VerificaCNP()==false)
            {
                rezultatValidare |= CodEroare.CNP_INCORECT;
            }
            if(mtxtNrTelefon.Text==string.Empty || mtxtNrTelefon.Text.Length != 10 || mtxtNrTelefon.Text[0]!='0')
            {
                rezultatValidare |= CodEroare.NR_TELEFON_INCORECT;
            }
            if (mtxtAdresa.Text == string.Empty)
            {
                rezultatValidare |= CodEroare.ADRESA_INCORECTA;
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
            if ((validare & CodEroare.CNP_INCORECT) == CodEroare.CNP_INCORECT)
            {
                mlblCNP.ForeColor = Color.Red;
            }
            if ((validare & CodEroare.NR_TELEFON_INCORECT) == CodEroare.NR_TELEFON_INCORECT)
            {
                mlblNrTelefon.ForeColor = Color.Red;
            }
            if ((validare & CodEroare.ADRESA_INCORECTA) == CodEroare.ADRESA_INCORECTA)
            {
                mlblAdresa.ForeColor = Color.Red;
            }
        }
        private void ResetCuloareEtichete()
        {
            mlblNume.ForeColor = Color.Gold;
            mlblPrenume.ForeColor = Color.Gold;
            mlblCNP.ForeColor = Color.Gold;
            mlblNrTelefon.ForeColor = Color.Gold;
            mlblAdresa.ForeColor = Color.Gold;
        }
        private bool VerificaCNP()
        {
            foreach (char c in mtxtCNP.Text)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
