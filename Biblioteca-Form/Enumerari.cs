//Agheorghiesei Madalina, grupa 3123A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Form
{
    [Flags]
    public enum CodEroare
    {
        CORECT=0,
        TITLU_INCORECT=1,
        AUTOR_INCORECT=2,
        EDITURA_INCORECTA=4,
        EXEMPLARE_INCORECT=8,
        LIMBA_NESELECTATA=16,
        NUME_INCORECT=32,
        PRENUME_INCORECT=64,
        CNP_INCORECT=128,
        NR_TELEFON_INCORECT=256,
        ADRESA_INCORECTA=512
    }
}
