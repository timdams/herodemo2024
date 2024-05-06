using herodemo.Engine;
using System.Net.WebSockets;

namespace herodemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Spelbord bord = new Spelbord();
            bord.TekenBord();

            //Tegel tegel1 = new Tegel();
            //Schat tijdelijkeSchat = new Schat();
            //tijdelijkeSchat.Beschrijving = "Blinky diamond";
           
            
            //tegel1 = new Tegel();
            //tegel1.VoegSchatToe(tijdelijkeSchat);

            //tegel1.ToonSchat();


            //Held barbaar = new Held(HeldTypes.Barbaar);

            //barbaar.VoegSchatToe(tegel1.ZoekSchat());

 
            //List<Mummie> theHorde = new List<Mummie>();
            //Mummie mommy = new Mummie();
            //theHorde.Add(mommy);

            //for (int i = 0; i < 10; i++)
            //{
            //    // theHorde.Add(new Mummie());
            //    Mummie soloMummie = new Mummie();

            //    theHorde.Add(soloMummie);
            //}

            //theHorde[4].ToonInfo();

            //theHorde.Remove(new Mummie());





            //Held speler1 = new Held(HeldTypes.Barbaar);

            //Held speler2 = new Held(HeldTypes.Barbaar);//overloaded constructor
            //Mummie mummie = new Mummie(); //default constructor

            ////references/referenties
            //Held actieveSpeler = speler1;
            //while (true)
            //{
            //    Console.WriteLine("Nieuwe ronde");
            //    if (actieveSpeler == speler1)
            //        actieveSpeler = speler2;
            //    else
            //        actieveSpeler = speler1;


            //    //vraag aan gebruiker wat hij wil doen 
            //    actieveSpeler.ValAan(mummie);

            //    Held.VergelijkHelden(speler1, speler2);
            //}
        }
    }
}
