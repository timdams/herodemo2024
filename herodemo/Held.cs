using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herodemo
{
    internal class Held
    {

        //TODO constructor ????


        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public int Aanval { get; set; }
        public int Verdediging { get; set; }

        public int Lopen { get; set; }
        public int IntelligentieMax { get; set; }
        public int LichaamMax { get; set; }

        private int lichaamActueel;

        public int LichaamActueel
        {
            get { return lichaamActueel; }
            set
            {
                if (value >= 0 && value <= LichaamMax)
                    lichaamActueel = value;
            }
        }

        private int intelligentieActueel;
        public int IntelligentieActueel
        {
            get { return intelligentieActueel; }
            set
            {
                if (value >= 0 && value <= IntelligentieMax)
                    intelligentieActueel = value;
            }
        }

        public void ToonInfo()
        {
            Console.WriteLine($"{Naam}: L{Lopen} A{Aanval} V{Verdediging} L{LichaamActueel}/{LichaamMax} I{IntelligentieActueel}/{IntelligentieMax}");
        }


    }
}
