//Agheorghiesei Madalina, grupa 3123A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public enum LimbaCarte
    {
        Nedefinit=0,
        Romana = 1,
        Engleza = 2,
        Franceza = 3,
        Germana = 4,
        Italiana = 5,
        Rusa = 6,
        Spaniola = 7,
        Ucraineana = 8,
        Japoneza = 9,
        Chineza = 10,
        Coreeana = 11
    };
    [Flags]
    public enum GenCarte
    {
        Nedefinit=0,
        Copii = 1,
        Criminalistic = 2,
        Dragoste = 4,
        Umoristic = 8,
        Groaza = 16,
        Religie = 32,
        Fantezie = 64,
        Fictiune = 128,
        Folclor = 256,
        Poetica = 512,
        Istoric = 1024,
        Mitologie = 2048,
        Psihologie = 4096,
        Aventura = 8192,
        Biografie = 16384
    }
}
