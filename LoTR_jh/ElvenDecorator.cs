using System;
using System.Collections.Generic;
using System.Text;

namespace LoTR_jh
{
    class ElvenDecorator:ElvenHouse
    {
        protected ElvenHouse elvenHouse;

        public override int Attack
        {
            get { return elvenHouse.Attack; }
            set { elvenHouse.Attack = value; }
        }
        public override int Health { get => base.Health; set => base.Health = value; }  //drugi sposob na get/set?

        public ElvenHouse ElvenHouse
        {
            get { return elvenHouse; }
            set { elvenHouse = value; }
        }

        public ElvenDecorator(ElvenHouse _ElvenHouse)
        {
            ElvenHouse = _ElvenHouse;

        }

        public override int GetNextAttack()
        {
            return ElvenHouse.GetNextAttack();
        }
    }
}
