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
        Germana = 3,
        Italiana = 4,
        Rusa = 5,
        Spaniola = 6,
        Ucraineana = 7,
        Japoneza = 8,
        Chineza = 9,
        Coreeana = 10
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
