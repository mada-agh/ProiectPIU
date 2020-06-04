//Agheorghiesei Madalina, grupa 3123A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelAccesDate2
{
    public interface IStocareData2
    {
        void AddCititor(Cititor s);
        List<Cititor> GetCititori();
        bool UpdateCititor(Cititor cititor);
        int NrCititori();
        Cititor GetCititor(string nume, string prenume);
        Cititor GetCititorByIndex(int index);
        bool StergeCititor(Cititor cititor);
    }
}
