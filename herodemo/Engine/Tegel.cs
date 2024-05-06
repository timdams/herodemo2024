using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herodemo.Engine
{
    internal class Tegel:System.Object
    {
        private Schat schat;

        public void ToonSchat()
        {
            if (schat != null)
            {
                Console.WriteLine(schat);
            }
            else
            {
                Console.WriteLine("Geen schat te vinden");
            }
        }

        public void VoegSchatToe(Schat deSchat)
        {
            if (schat == null)
            {
                schat = deSchat;
            }
            else
            {
                Console.WriteLine("Gaat niet. Deze tegel heeft al een schat.");
            }
        }

        public void VerwijderSchat()
        {
            schat = null;
        }

        public Schat ZoekSchat()
        {
            Schat tijdelijk = schat;
            VerwijderSchat();
            return tijdelijk;
        }



    }
}
