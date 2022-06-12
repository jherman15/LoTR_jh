using System;
using System.Collections.Generic;
using System.Text;

namespace LoTR_jh
{
    class ManweAinurDecorator:Ainur //ewentualnie można to później zaimplementować, ale teraz niech wszystko wywodzi się od elfów
    {
        public void SpecialBlessing()
        {
            Console.WriteLine("Manwe is blessing you with his special blessing.");


        }
    }
}
