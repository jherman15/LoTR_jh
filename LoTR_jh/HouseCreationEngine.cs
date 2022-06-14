using System;
using System.Collections.Generic;
using System.Text;

namespace LoTR_jh
{
    class HouseCreationEngine
    {

        Treasury treasure;

        ElvenHouse Morgoth = new Ainur();
        public static void choosing(ElvenHouse x)
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "Armor":
                    {
                        Console.WriteLine("Health before: " + x.Health);
                        x = new ArmorDecorator(x);
                        Console.WriteLine("Health after: " + x.Health);
                        break;
                    }

                case "Defence":
                    {
                        x = new ArmorDecorator(x);
                        Console.WriteLine($"Added {choice}.");
                        break;
                    }

                case "Magic":
                    {
                        Console.WriteLine("Magic power before: " + x.MagicPower);
                        x = new MagicDecorator(x);
                        Console.WriteLine("Magic power after: " + x.MagicPower);
                        break;
                    }

                default:
                    Console.WriteLine("You did not choose anything.");
                    break;
            }
        }

        public static ElvenHouse CreateNoldor()
        {

            
            //int hp1 = h1.Health;               
            //int at1 = h1.Attack;              
            //battleList.Add(h1);                  // -> a co z tym?
            
            ElvenHouse noldorHouse = new Noldor();
            HouseCreationEngine.choosing(noldorHouse);
            return noldorHouse;
            //Engine.choosing(h3);
            //treasure.CheckTreasury();
        }

        public static ElvenHouse CreateTeleri()
        {
            ElvenHouse teleriHouse = new Teleri();
            return teleriHouse;
        }

        public static ElvenHouse CreateVanyar()
        {
            ElvenHouse vanyarHouse = new Vanyar();
            return vanyarHouse;
        }

        //public static AttackWithNoldor()
        //{
        //    HouseCreationEngine.CreateNoldor();
        //    int attack1 = Morgoth.GetNextAttack();
        //    int attack2 = noldorHouse.GetNextAttack();
        //    battleList[0].Health -= attack1;                    //tutaj zamiast battlelist[j]
        //    Morgoth.Health -= attack2;

        //    // } while (battleList[j].Health > 0 && Morgoth.Health > 0);
        //}

    }
}


