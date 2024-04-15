using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herodemo.Engine
{
    internal class SpelPersonage
    {
        public SpelPersonage(string naamIn, int lopenIn, int aanvalIn, int verdedigingIn, int lichaamIn, int intelligenteIn)
        {
            Console.WriteLine("spelconstructor gestart");
            Naam = naamIn;  //TIP:  vaak schrijven studenten verkeerdelijk: naamIn=Naam;
            Lopen = lopenIn;
            Aanval = aanvalIn;
            Verdediging = verdedigingIn;
            Lichaam = lichaamIn;
            Intelligentie = intelligenteIn;
        }



        public string Naam { get; protected set; }
        public int Lopen { get; protected set; }
        public int Aanval { get; protected set; } 
        public int Verdediging { get; protected set; } 
        public int Lichaam { get; protected set; } 
        public int Intelligentie { get; protected set; } 

        public void ToonInfo()
        {
            Console.WriteLine($"{Naam}: L{Lopen} A{Aanval} V{Verdediging} L{Lichaam} I{Intelligentie}");
        }

        public void KrijgSchade(int aantalSchade)
        {
            //Todo Lichaam fullprop van maken
            if (Lichaam != 0 && aantalSchade > 0)//als monster nog leeft
            {
                Lichaam = 0;
            }
            else
            {
                //Todo  throw new Exception("Ge moogt niet kloppen op lijken");
            }
        }
    }
}
