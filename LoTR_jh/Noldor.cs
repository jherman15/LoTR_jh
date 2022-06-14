using System;
using System.Collections.Generic;
using System.Text;

namespace LoTR_jh
{
    class Noldor:ElvenHouse
    {
        public Noldor() : base()
        {
            Wisdom += 150;
        }

        //public void 
        public double craft=100;

        public override int GetNextAttack()
        {
            return 2 * Attack;
        }




    }
}
