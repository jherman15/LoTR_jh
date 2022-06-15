using System;
using System.Collections.Generic;
using System.Text;

namespace LoTR_jh
{

    //rozdzielic interfejs od silnika - silnik odpowiada za logikę
    class Interface
    {

        Treasury treasure;

        ElvenHouse Morgot = new Noldor();

        //Engine engine = new Engine();
        public static void CreateHouse()
        {
            Console.WriteLine
                ("This is a LoTR game, where you are able to create your own houses. \n" +
                "What first house you want to create? \n " +
                "You can only create the total number of 5 troops" +
                "a) Noldor \n " +
                "b) Teleri \n " +
                "c) Vanyar \n\n " +
                "Your answer: ");



            //zrobic klase interfejsowa, którą wywołuje metody, ewentualnie robi ifa i wypisuje - czyli interfejs do kontaktu z uzytkownikiem

            for (int k=0; k<5; k++)
            {
                string house = Console.ReadLine();
                if (house == "Noldor")
                {
                    HouseCreationEngine.CreateNoldor();
                    //battleList.Add(h2);
                }
                else if (house == "Teleri")
                {
                    HouseCreationEngine.CreateTeleri();
                    //battleList.Add(h2);
                    //Console.WriteLine("1. Armor \n 2. Defence \n 3. Magic \n What do you choose?\n Your answer: ");
                    //string choice = Console.ReadLine();
                    //Engine.choosing(h2);
                }
                else if (house == "Vanyar")
                {
                    HouseCreationEngine.CreateVanyar();
                }
            }

            Console.WriteLine("Okay, you've got your troops.");


            Console.WriteLine
                ("Now you are facing the battle with Morgoth! \n" +
                "If you've created a well-balanced houses, you may win this brutal fight. \n ")




            Console.WriteLine("Morgoth health: " + Morgot.Health);
            Console.WriteLine("Elven health: " + battleList[0].Health);
        }

        int attack1 = Morgoth.GetNextAttack();
        int attack2 = HouseCreationEngine.CreateNoldor();
        battleList[0].Health -= attack1;                    //tutaj zamiast battlelist[j]
        Morgoth.Health -= attack2;

    }
}
