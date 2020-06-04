//Agheorghiesei Madalina, grupa 3123A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Cititor
    {
        private const int MAI_MARE = 1;
        private const int MAI_MIC = 1;
        private const int EGAL = 0;
        private const int MAX_CARTI_IMPRUMUT = 10;
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ',';
        private const int COD = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int COD_CNP = 3;
        private const int NR_TELEFON = 4;
        private const int ADRESA = 5;
        private const int NR_CARTI = 6;
        private const int NR_IMPRUMUT_ID = 7;

        public int[] imprumutID; //codul cartilor imprumutate
        public static int NextID { get; set; } = 0;
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string NrTelefon { get; set; }
        public string Adresa { get; set; }
        public int NrCarti { get; set; }
        public int Cod { get; set; }
        public string NumeComplet { get { return Nume + " " + Prenume; } }
        public Cititor(string _nume = "", string _prenume = "", string _cnp="", string _nrtel="", string _adresa="")
        {
            Nume = _nume;
            Prenume = _prenume;
            CNP = _cnp;
            NrTelefon = _nrtel;
            Adresa = _adresa;
            NrCarti = 0;
            Cod = ++NextID;
            imprumutID = new int[MAX_CARTI_IMPRUMUT];
        }
        public Cititor(string dateCititor)
        {
            //string[] infoCititor = dateCititor.Split(new string[] { ", " }, StringSplitOptions.None);
            string[] infoCititor = dateCititor.Split(SEPARATOR_PRINCIPAL_FISIER);
            Cod = Int32.Parse(infoCititor[COD]);
            NextID = Cod;
            Nume = infoCititor[NUME];
            Prenume = infoCititor[PRENUME];
            CNP = infoCititor[COD_CNP];
            NrTelefon = infoCititor[NR_TELEFON];
            Adresa = infoCititor[ADRESA];
            NrCarti = Int32.Parse(infoCititor[NR_CARTI]);
            imprumutID = new int[MAX_CARTI_IMPRUMUT];
            string[] IDcarti = infoCititor[NR_IMPRUMUT_ID].Split(SEPARATOR_SECUNDAR_FISIER);
            for(int i=0; i<NrCarti; i++)
                imprumutID[i] = Int32.Parse(IDcarti[i]);
        }
        public bool NrMaxCarti()
        {
            if (MAX_CARTI_IMPRUMUT == NrCarti)
                return true;
            return false;
        }
        public string ConversieLaSir()
        {
            return "#"+Cod.ToString()+" "+Nume + " " + Prenume + " - " + NrCarti.ToString() + " carti";
        }
        public int Compara(Cititor c)
        {
            if (this.Nume.CompareTo(c.Nume) == MAI_MARE)
                return MAI_MARE;
            else if (this.Nume.CompareTo(c.Nume) == EGAL)
            {
                if (this.Prenume.CompareTo(c.Prenume) == MAI_MARE)
                    return MAI_MARE;
                else if (this.Prenume.CompareTo(c.Prenume) == EGAL)
                    return EGAL;
                else
                    return MAI_MIC;
            }
            else
                return MAI_MIC;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}",
                SEPARATOR_PRINCIPAL_FISIER, Cod.ToString(), (Nume ?? "NECUNOSCUT"), (Prenume ?? " NECUNOSCUT "), (CNP ?? "NECUNOSCUT"), (NrTelefon ?? "NECUNOSCUT"), (Adresa ?? "NECUNOSCUT"),NrCarti.ToString(), ConversieLaSir_ImprumutID());

            return s;
        }
        public string ConversieLaSir_ImprumutID()
        {
            string[] strImp=new string[NrCarti];
            for(int i=0; i<NrCarti; i++)
                strImp[i] = imprumutID[i].ToString();
            return string.Join(SEPARATOR_SECUNDAR_FISIER.ToString(), strImp);
        }
        public bool NouImprumut(Carte c)
        {
            if (!NrMaxCarti())
            {
                imprumutID[NrCarti++] = c.Cod;
                c.NumarImprumutate++;
                return true;
            }
            return false;
        }
        public void Returnare(Carte c)
        {
            for(int i=0; i<NrCarti; i++)
            {
                if (imprumutID[i] == c.Cod)
                {
                    for(int j=i; j<NrCarti-1; j++)
                        imprumutID[j] = imprumutID[j+1];
                    NrCarti--;
                    c.NumarImprumutate--;
                    return;
                }
            }
        }
    }
}
