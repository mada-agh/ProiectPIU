using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Carte
    {
        private const int MAI_MARE = 1;
        private const int MAI_MIC = 1;
        private const int EGAL = 0;
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const int TITLU = 0;
        private const int AUTOR = 1;
        private const int EDITURA = 2;
        private const int COD = 3;
        private const int N_EXEMPLARE = 4;
        private const int N_IMPRUMUTATE = 5;
        private const int LIMBA = 6;
        private const int GEN = 7;
        

        public static int NextID { get; set; } = 0;
        public int Cod { get; set; }
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public string Editura { get; set; }
        public int NumarExemplare { get; set; }
        public int NumarImprumutate { get; set; }
        public string NumeComplet { get { return Titlu + " - " + Autor; } }
        public LimbaCarte Limba { get; set; }
        public List<string> Gen { get; set; }
        public int CartiDisponibile { get { return NumarExemplare - NumarImprumutate; } }
        public string GenToString {
            get { 
                string sGenuri = string.Empty;

                foreach (string tip in Gen)
                {
                    if (sGenuri != string.Empty)
                    {
                        sGenuri += SEPARATOR_SECUNDAR_FISIER;
                    }
                    sGenuri += tip;
                }

                return sGenuri;
            } }
        

        public Carte(string _titlu = "", string _autor = "", string _editura = "", int nrex = 1)
        {
            Titlu = _titlu;
            Autor = _autor;
            Editura = _editura;
            Cod = ++NextID;
            NumarExemplare = nrex;
            NumarImprumutate = 0;
        }
        public Carte(string date)
        {
            //string[] infoCarte = date.Split(new string[] { ", " }, StringSplitOptions.None);
            string[] infoCarte = date.Split(SEPARATOR_PRINCIPAL_FISIER);
            Titlu = infoCarte[TITLU];
            Autor = infoCarte[AUTOR];
            Editura = infoCarte[EDITURA];
            Cod = Convert.ToInt32(infoCarte[COD]);
            NextID = Cod;
            NumarExemplare = Convert.ToInt32(infoCarte[N_EXEMPLARE]);
            NumarImprumutate = Convert.ToInt32(infoCarte[N_IMPRUMUTATE]);
            Limba = (LimbaCarte)Enum.Parse(typeof(LimbaCarte), infoCarte[LIMBA]);
            Gen = new List<string>();
            //adauga mai multe elemente in lista de genuri
            Gen.AddRange(infoCarte[GEN].Split(SEPARATOR_SECUNDAR_FISIER));
        }
        public string ConversieLaSir()
        {
            return "#"+Cod.ToString()+" - "+Titlu + " - " + Autor + " - " + Editura +"\nLimbă: "+Limba+"\nGen: "+GenToString+"\nNumăr de exemplare: "+NumarExemplare.ToString()+"\n";
        }
        public int Compara(Carte c)
        {
            if (this.Cod > c.Cod)
                return MAI_MARE;
            else if (this.Cod == c.Cod)
            {
                if (this.Titlu.CompareTo(c.Titlu) == MAI_MARE)
                    return MAI_MARE;
                else if (this.Titlu.CompareTo(c.Titlu) == EGAL)
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
                SEPARATOR_PRINCIPAL_FISIER, (Titlu ?? "NECUNOSCUT"), (Autor ?? " NECUNOSCUT "), (Editura ?? " NECUNOSCUT "), Cod.ToString(), NumarExemplare.ToString(), NumarImprumutate.ToString(),Limba, GenToString);

            return s;
        }
    }
}
