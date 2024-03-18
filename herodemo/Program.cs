using System.Net.WebSockets;

namespace herodemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string monster = HQ24_DAL_CL.HQDAL.GetMonsterStats();

            //string[] splitMonsters = monster.Split("\r\n");

            //string[] mummieData = splitMonsters[6].Split(";");


            List<Mummie> theHorde = new List<Mummie>();
            Mummie mommy = new Mummie();
            theHorde.Add(mommy);

            for (int i = 0; i < 10; i++)
            {
                // theHorde.Add(new Mummie());
                Mummie soloMummie = new Mummie();
                theHorde.Add(soloMummie);
            }

            theHorde[4].ToonInfo();

            theHorde.Remove(new Mummie());


          


            Held speler1 = new Held(HeldTypes.Barbaar);
            
            Held speler2 = new Held(HeldTypes.Barbaar);//overloaded constructor
            Mummie mummie = new Mummie(); //default constructor

            //references/referenties
            Held actieveSpeler = speler1;
            while (true)
            {
                Console.WriteLine("Nieuwe ronde");
                if (actieveSpeler == speler1)
                    actieveSpeler = speler2;
                else
                    actieveSpeler = speler1;


                //vraag aan gebruiker wat hij wil doen 
                actieveSpeler.ValAan(mummie);

                Held.VergelijkHelden(speler1, speler2);
            }
        }
    }
}
