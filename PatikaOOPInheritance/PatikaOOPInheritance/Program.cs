
using PatikaOOPInheritance;

public class Program
{
    public static void Main()
    {

        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Ad = "Betül";
        ogrenci.Soyad = "Çelik";
        ogrenci.OgrenciNumarasi = 11223344;

        ogrenci.YazdırOgrenci();
        Console.WriteLine();

        Ogretmen ogretmen = new Ogretmen();
        ogretmen.Ad = "Zehra";
        ogretmen.Soyad = "Demir";
        ogretmen.OgretmenMaasi = 52000;

        ogretmen.YazdırOgretmen();



    }
}