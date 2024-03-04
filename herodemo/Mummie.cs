using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herodemo
{
    internal class Mummie
    {
        public string Naam { get; } = "Mummie";
        public int Lopen { get; } = 4;
        public int Aanval { get; } = 3;
        public int Verdediging { get; } = 4;
        public int Lichaam { get; } = 1;
        public int Intelligentie { get; } = 0;

        public void ToonInfo()
        {
            Console.WriteLine($"{Naam}: L{Lopen} A{Aanval} V{Verdediging} L{Lichaam} I{Intelligentie}");
        }
    }
}
