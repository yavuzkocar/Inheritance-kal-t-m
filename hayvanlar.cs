using System;

namespace Inheritance_kalıtım
{
    public class hayvanlar:canlılar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon yapablir");
        }

    }
    public class sürüngenler:hayvanlar
    {
        public sürüngenler()
         {
            base.Adaptasyon();
            base.bosaltım();
            base.Beslenme();
            base.solunum();
        }
         public void SurunerekHareketEderler()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler");
        }
    }

        public class kuslar:hayvanlar
    {
         public kuslar()
         {
            base.Adaptasyon();
            base.bosaltım();
            base.Beslenme();
            base.solunum();
        }
         public void Sucmak()
        {
            Console.WriteLine("kuslar ucarlar");
        }
    }
}