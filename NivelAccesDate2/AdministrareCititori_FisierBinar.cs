//Agheorghiesei Madalina, grupa 3123A
using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate2
{
    public class AdministrareCititori_FisierBinar : IStocareData2
    {
        string NumeFisier { get; set; }
        public AdministrareCititori_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddCititor(Cititor s)
        {
            throw new Exception("Optiunea AddCititor nu este implementata");
        }

        public List<Cititor> GetCititori()
        {
            throw new Exception("Optiunea GetCititori nu este implementata");
        }

        public Cititor GetCititor(string nume, string prenume)
        {
            throw new Exception("Optiunea GetCititor nu este implementata");
        }
        public bool UpdateCititor(Cititor cititor)
        {
            throw new Exception("Optiunea UpdateCititor nu este implementata");
        }
        public int NrCititori()
        {
            throw new Exception("Optiunea NrCititori nu este implementata");
        }
        public Cititor GetCititorByIndex(int index)
        {
            throw new Exception("Optiunea GetCititorByIndex nu este implementata");
        }
        public bool StergeCititor(Cititor cititor)
        {
            throw new Exception("Optiunea StergeCititor nu este implementata");
        }
    }
}
