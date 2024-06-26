﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using herodemo.Hulpklassen;

namespace herodemo.Engine
{

    public enum HeldTypes { Barbaar, Dwerg, Elf, Tovenaar }

    internal class Held : SpelPersonage
    {


        public Held(HeldTypes heldType) : base("Held", 2, 2, 2, 2, 2)
        {
            switch (heldType)
            {
                case HeldTypes.Barbaar:
                    Aanval = 3;
                    Verdediging = 2;
                    Lopen = 2;
                    IntelligentieMax = 2;
                    LichaamMax = 8;
                    break;
                case HeldTypes.Dwerg: //2,2,2,3,7
                    break;
                case HeldTypes.Elf://2,2,2,4,6
                    break;
                case HeldTypes.Tovenaar://1,2,2,6,4
                    break;
                default:
                    break;
            }

            LichaamActueel = LichaamMax;
            IntelligentieActueel = IntelligentieMax;
            HeldType = heldType;
        }

        private Schat inventaris = new Schat();

        public void VoegSchatToe(Schat deSchat)
        {
            if (deSchat != null)
            {
                inventaris = deSchat;
            }
        }

        public static void VergelijkHelden(Held held1, Held held2)
        {
            if (held1.LichaamActueel > held2.lichaamActueel)
                Console.WriteLine("held1 staat er beter voor dan held 2");
        }

        public HeldTypes HeldType { get; set; }


        public string Beschrijving { get; set; }



        public int IntelligentieMax { get; set; }
        public int LichaamMax { get; set; }

        private int lichaamActueel;

        public int LichaamActueel
        {
            get { return lichaamActueel; }
            set
            {
                if (value >= 0 && value <= LichaamMax)
                    lichaamActueel = value;
            }
        }

        private int intelligentieActueel;
        public int IntelligentieActueel
        {
            get { return intelligentieActueel; }
            set
            {
                if (value >= 0 && value <= IntelligentieMax)
                    intelligentieActueel = value;
            }
        }

        public void ValAan(Mummie vijand) //Todo wat met andere type monsters? En andere gelden ? (friendly fire?)
        {
            Dobbelsteen d1 = new Dobbelsteen();

            int aantalSkelet = 0;
            int aantalSchildVijand = 0;

            //aanval keren rollen door held
            for (int i = 0; i < Aanval; i++)
            {
                if (d1.Rol() == DobbelWaarden.Skelet)
                    aantalSkelet++;
            }

            //verdediging keren rollen door monster

            for (int i = 0; i < vijand.Verdediging; i++)
            {
                if (d1.Rol() == DobbelWaarden.MonsterSchild)
                    aantalSchildVijand++;
            }
            Console.WriteLine(aantalSkelet);
            Console.WriteLine(aantalSchildVijand);
            //vergelijken en monster doden indien aantalSkelet > aantalSchildVijand
            if (aantalSkelet > aantalSchildVijand)
            {
                vijand.KrijgSchade(aantalSkelet - aantalSchildVijand);
            }
        }

    }
}
