using System.Net.WebSockets;

namespace herodemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mummie eenVijand = new Mummie();
            Mummie eenAndereVijand = new Mummie();


            eenAndereVijand.ToonInfo();
            eenVijand.ToonInfo();

            Held elf = new Held();
            elf.LichaamMax = 6;
            elf.ToonInfo();
            elf.LichaamActueel = 5;
            elf.ToonInfo();

            for (int i = 0; i < 10; i++)
            {
                elf.LichaamActueel--;
                elf.ToonInfo();
            }
        }
    }
}
