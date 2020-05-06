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
        LIMBA_NESELECTATA=16
    }
}
