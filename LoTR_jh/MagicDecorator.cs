using System;
using System.Collections.Generic;
using System.Text;

namespace LoTR_jh
{
    internal class MagicDecorator : ElvenDecorator  //additional armor - more health points
    {
        public MagicDecorator(ElvenHouse _ElvenHouse) : base(_ElvenHouse)
        {
            Health = ElvenHouse.MagicPower + 150;
            //Attack = ElvenHouse.Attack;
            Console.WriteLine("Added 150 magic power.");
        }
        public override int GetNextAttack()         //ship's basic attack 
        {
            return base.GetNextAttack();
        }


    }
}
