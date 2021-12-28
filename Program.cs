using System;

namespace Inheritance_kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
           //            canlılar
           //                |
           //    bitkiler           hayvanlar
           //   |         |        |               |
           //tohumlu     tohumsuz  surungenler  kuslar
           tohumluBitkiler tohumlubitki = new tohumluBitkiler();

        //    tohumlubitki.Tohumlacogalma();
           Console.WriteLine("**************");
           kuslar martı = new kuslar();

           martı.Sucmak();
        }
    }
}
