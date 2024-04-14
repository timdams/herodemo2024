using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herodemo
{
    internal class Kaart
    {
        private static string schaduwKaart= @"┌──┬───────┬──┐
│  │       │  │▓
├──┴───────┴──┤▓
│             │▓
├─────────────┤▓
│             │▓
│             │▓
│             │▓
│             │▓
│             │▓
│             │▓
└─────────────┘▓
 ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓";

        private static string geenSchaduwKaart=
            @"┌──┬───────┬──┐
│  │       │  │
├──┴───────┴──┤
│             │
├─────────────┤
│             │
│             │
│             │
│             │
│             │
│             │
└─────────────┘";

        public virtual void Teken(int x, int y, string titel, string beschrijving, string linksboven = "", string midden = "", string rechtsboven = "", ConsoleColor hoofdKleur = ConsoleColor.White, bool schaduw = true)
        {
            //Meer karakters op https://en.wikipedia.org/wiki/Box-drawing_characters
            string tekenKaart = Kaart.geenSchaduwKaart;
            if(!schaduw)
            { tekenKaart = Kaart.schaduwKaart; }

            Console.ForegroundColor = hoofdKleur;
            string[] lijnen = tekenKaart.Split(Environment.NewLine);
            for (int i = 0; i < lijnen.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(lijnen[i]);
            }

            //linksboven
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write(linksboven);
            Console.ForegroundColor = hoofdKleur;

            //rechtsboven
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x + 12, y + 1);
            Console.Write(rechtsboven);
            Console.ForegroundColor = hoofdKleur;

            //midden        
            Console.SetCursorPosition(x + 4, y + 1);
            Console.Write(midden.Substring(0,7)); //mag max 7 lang zijn
            Console.ForegroundColor = hoofdKleur;


            //titel
            Console.SetCursorPosition(x + 1, y + 3);
            if (titel.Length > 12)
                Console.Write(titel.Substring(0, 11));
            else Console.Write(titel);

            //beschrijving
            //mag max 5x12 karakters lang zijn (kan ook ascii art zijn ;)  )
            const int partSize = 12;
            const int MAX_BESCHRIJVING = partSize*5;
            string opgekuisteBeschrijving = beschrijving.Trim().Replace("\n",string.Empty).Replace(Environment.NewLine, string.Empty);

            if (beschrijving.Length > MAX_BESCHRIJVING)
                opgekuisteBeschrijving = opgekuisteBeschrijving.Substring(0, MAX_BESCHRIJVING);

            //bron: https://stackoverflow.com/questions/4133377/splitting-a-string-number-every-nth-character-number/38172121#38172121
            
            var splitBeschrijving= Enumerable.Range(0, (opgekuisteBeschrijving.Length + partSize - 1) / partSize).Select(i => opgekuisteBeschrijving.Substring(i * partSize, Math.Min(opgekuisteBeschrijving.Length - i * partSize, partSize))).ToArray();
            for (int i = 0; i < splitBeschrijving.Length; i++)
            {
                Console.SetCursorPosition(x + 1, y + 5 + i);
                Console.Write(splitBeschrijving[i]);
            }
        }
    }
}
