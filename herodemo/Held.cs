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


        public void ValAan(Mummie vijand) //Todo wat met andere type monsters? En andere gelden ? (friendly fire?)
        {
            Dobbelsteen d1 = new Dobbelsteen();

            int aantalSkelet = 0;
            int aantalSchildVijand = 0;

            //aanval keren rollen door held
            for (int i = 0; i < Aanval; i++)
            {
                if (d1.Rol() == DobbelWaarden.Skelet)
                    aantalSkelet++;
            }

            //verdediging keren rollen door monster

            for (int i = 0; i < vijand.Verdediging; i++)
            {
                if (d1.Rol() == DobbelWaarden.MonsterSchild)
                    aantalSchildVijand++;
            }
            Console.WriteLine(aantalSkelet);
            Console.WriteLine(  aantalSchildVijand);
            //vergelijken en monster doden indien aantalSkelet > aantalSchildVijand
            if (aantalSkelet> aantalSchildVijand)
            {
                vijand.KrijgSchade(aantalSkelet-aantalSchildVijand) ;
            }
        }

    }
}
