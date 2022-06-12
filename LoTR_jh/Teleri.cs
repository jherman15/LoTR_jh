using System;
using System.Collections.Generic;
using System.Text;

namespace LoTR_jh
{
    class Teleri:ElvenHouse
    {
        //public override int GetNextAttack()
        //{
        //    Random RNG = new Random();
        //    if (Morgoth.OnSea==true) return base.GetNextAttack();
        //    else
        //        return base.GetNextAttack() + base.GetNextAttack();
        //}

        public Teleri() : base()
        {
            Wisdom += 300;
        }

        public int GetPseudoRandomNumber(int input)
        {
            Random random = new Random(input);
            if (random.Next(10) < 7) return base.GetNextAttack();
            else
                return base.GetNextAttack() + base.GetNextAttack();
        }

    }
}
