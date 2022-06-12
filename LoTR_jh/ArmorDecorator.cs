using System;
using System.Collections.Generic;
using System.Text;

namespace LoTR_jh
{
    internal class ArmorDecorator : ElvenDecorator  //additional armor - more health points
    {
        public ArmorDecorator(ElvenHouse _ElvenHouse) : base(_ElvenHouse)
        {
            Health = ElvenHouse.Health + 150;
            //Attack = ElvenHouse.Attack;
            Console.WriteLine("Added 150 healthpoints");
        }
        public override int GetNextAttack()         //ship's basic attack 
        {
            return base.GetNextAttack();
        }


    }
}
