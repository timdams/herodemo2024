using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herodemo.Engine
{
    internal class TeleportTegel : Tegel
    {
        public void TeleporteerHeld(Held heldIn, Tegel bestemming)
        {

        }        
    }
    internal class ValTegel : Tegel
    {
        public int ValSchade { get; set; } = 5;
    }
}
