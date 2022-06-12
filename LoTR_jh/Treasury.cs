using System;
using System.Collections.Generic;
using System.Text;

namespace LoTR_jh
{
    internal class Treasury
    {
        private Noldor feanor;
        private int silmaril=0;

        public Treasury(Noldor feanor)
        {
            Feanor = feanor;
        }

        public Noldor Feanor
        {
            get { return feanor; }
            set { feanor = value; }
        }

        public int CheckTreasury()          //jakiś argument?
        {
            if (Feanor.craft > 100)
                return silmaril += 1;
            else
                return silmaril;
        }

        //metoda get liczba bułek, jeśli chcę zaglądnąć
        //jeśli to ma fabularne uzasadnienie, to ok
        //nie mozna podlądnać wartości nie wchodząc w nią

    }
}
