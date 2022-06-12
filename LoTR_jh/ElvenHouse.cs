using System;
using System.Collections.Generic;
using System.Text;

namespace LoTR_jh
{
    public abstract class ElvenHouse
    {
        public virtual int Attack { get; set; } = 100;
        public virtual int Health { get; set; } = 300;
        public virtual int Wisdom { get; set; } = 300;          //jak ma sie dosc duzo to mozna uzyc spella
        public virtual int MagicAttack { get; set; } = 300;
        public virtual int Strength { get; set; } = 300;
        public virtual int Accuracy { get; set; } = 300;
        public virtual int MagicPower { get; set; } = 300;



        public virtual int GetNextAttack()
        {
            return Attack;
        }

        public virtual int GetNextMagicAttack()
        {
            return MagicAttack;
        }
    }
}
