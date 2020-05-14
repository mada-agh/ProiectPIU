using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;
using System.Collections;

namespace NivelAccesDate1
{
    public interface IStocareData1
    {
        void AddCarte(Carte s);
        List<Carte> GetCarti();
        bool UpdateCarte(Carte carte);
        int NrCarti();
        Carte GetCarte(string titlu, string autor);
        Carte GetCarteByIndex(int index);
    }
}
