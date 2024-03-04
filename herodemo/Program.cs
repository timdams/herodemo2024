using System.Net.WebSockets;

namespace herodemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mummie eenVijand = new Mummie();


            Held elf = new Held();
            elf.LichaamMax = 6;
            elf.Aanval = 2;
            for (int i = 0; i < 5; i++)
            {
                eenVijand = new Mummie();
                elf.ValAan(eenVijand);

                if (eenVijand.Lichaam == 0)
                    Console.WriteLine("Gewonnen");
                else
                    Console.WriteLine("Verloren");

            }


            //Dobbelsteen d1 = new Dobbelsteen();
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(d1.Rol());
            //}
        }
    }
}
