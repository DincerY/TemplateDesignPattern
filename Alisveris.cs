using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Template_Design_Pattern
{
    public abstract class Alisveris
    {
        public int Fiyat { get; set; }
        public string OdemeSekli { get; set; }
        public void AlisverisBaslat() => Console.WriteLine("Alışveriş Başladı");
        public void AliverisBitir() => Console.WriteLine($"Alışveriş Bitti.{Fiyat} fiyatlı ürünün ödemesi {OdemeSekli} halinde yapıldı");
        public abstract void OdemeSekliDegis();
        public abstract void FiyatDegis();

        public void TemplateMethod()
        {
            AlisverisBaslat();
            FiyatDegis();
            OdemeSekliDegis();
            AliverisBitir();
        }
    }
}
