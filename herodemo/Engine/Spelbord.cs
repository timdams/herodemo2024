using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace herodemo.Engine
{
    internal class Spelbord
    {
        public Spelbord()
        {
            MaakSpelbord();
        }

        Tegel[,] bord = new Tegel[5, 5];

        public void MaakSpelbord() //todo meegeven hoe spelbord eruit moet zijn
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    bord[i, j] = new Tegel();
                }
            }

            bord[3, 4] = new TeleportTegel();
            bord[1, 2] = new ValTegel();
            bord[1, 3] = new ValTegel();


            //override 
        }

        public void TekenBord()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.SetCursorPosition(i, j);
                                  
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    if (bord[i,j] is ValTegel)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        var tempTegel = bord[i, j] as ValTegel;
                        Console.Write(tempTegel.ValSchade);
                    }
                    else if (bord[i,j] is TeleportTegel)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" ");
                    }
                    else //indien gewone Tegel
                    { 
                        Console.Write(" ");
                    }                    
                    Console.ResetColor();
                }
            }
        }
    }
}
