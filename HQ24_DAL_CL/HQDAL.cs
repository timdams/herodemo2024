namespace HQ24_DAL_CL
{
    public class HQDAL
    {
        /// <summary>
        /// Geeft een csv-tekst terug die alle eigenschappen van ieder type monster bevat
        /// </summary>
        /// <returns>csv met header</returns>
        public static string GetMonsterStats()
        {
            return "Type;Aanval;Verdediging;Lichaam;Intelligentie;Beweging\r\n" +
                "Goblin;2;1;1;1;10\r\n" +
                "Orc;3;2;1;2;8\r\n" +
                "Fimir;3;3;1;3;6" +
                "\r\nSkeleton;2;2;1;0;6" +
                "\r\nZombie;2;3;1;0;4" +
                "\r\nMummy;3;4;1;0;4" +
                "\r\nChaos Warrior;3;4;1;3;6\r\nGargoyle;4;4;1;4;6" +
                "\r\nElven Archer;4;2;3;2;6\r\nElven Warrior;4;3;3;2;6\r\nGiant Wolf;6;3;5;1;9\r\nOrge;6;4;10;2;4\r\nIce Gremlin;2;3;3;3;10\r\nPolar Warbear;4;3;6;2;6\r\nYeti;3;3;5;2;8\r\nCrossbowman;3;3;2;2;6\r\nHalberdier;3;3;2;2;6\r\nScout;2;3;2;2;9\r\nSwordsman;4;5;2;2;5\r\nCrossbowman;2;3;1;2;6\r\nHalberdier;3;3;1;2;6\r\nScout;2;3;1;2;9\r\nSwordsman;4;5;1;2;4\r\nDoomguard;4;5;1;3;6";
        }


    }
}
