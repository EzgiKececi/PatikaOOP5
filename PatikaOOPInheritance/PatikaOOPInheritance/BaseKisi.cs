using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOOPInheritance
{
    public abstract class BaseKisi
    {
        public string Ad;
        public string Soyad;

        public void YazdırAdSoyad()
        {
            Console.WriteLine($"Adı ve soyadı : {Ad} {Soyad}");
        }
    
    }

    public sealed class Ogrenci : BaseKisi
    {
        public int OgrenciNumarasi {  get; set; }

        public void YazdırOgrenci()
        {
            Console.WriteLine($"Öğrenci numarası : {OgrenciNumarasi}");
            YazdırAdSoyad();
        }

    }
    
    public sealed class Ogretmen: BaseKisi
    {
        public decimal OgretmenMaasi { get; set; }  

        public void YazdırOgretmen()
        {
            YazdırAdSoyad();
            Console.WriteLine($"Öğretmenin maaşı: {OgretmenMaasi}");
        }


    }

}
