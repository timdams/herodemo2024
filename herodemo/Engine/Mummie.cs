using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herodemo.Engine
{
    internal class Mummie : SpelPersonage
    {
        //public string Naam { get; } = "Mummie";
        //public int Lopen { get; } = 4;
        //public int Aanval { get; } = 3;
        //public int Verdediging { get; } = 0;
        //public int Lichaam { get; private set; } = 1;
        //public int Intelligentie { get; } = 0;
        public Mummie():base("Mummie",4,3,4,1,0)
        {
           
        }


    }
}
