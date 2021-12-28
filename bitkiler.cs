using System;

namespace Inheritance_kalıtım
{
    public class bitkiler:canlılar
    {
      protected void Fotosentez(){
          Console.WriteLine("bitkiler fotosentez yapar");
      }
    }
    public class tohumluBitkiler:bitkiler
    {
        public tohumluBitkiler(){
            base.Fotosentez();
            base.bosaltım();
            base.Beslenme();
            base.solunum();
        }
        public void Tohumlacogalma(){
          Console.WriteLine("tohumlu bitkiler tohumla coğalır");
        }
    }
    public class tuhumsuzBitkiler:bitkiler
    {
          public tuhumsuzBitkiler(){
            base.Fotosentez();
        }
        public void sporlacogalma(){
          Console.WriteLine("tohumsuz bitkiler sporla coğalır");
        }
    }
}