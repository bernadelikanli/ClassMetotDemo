using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ali";
            musteri1.Soyad = "GÜLER";
            musteri1.Adres = "Hatay İZMİR";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ayşe";
            musteri2.Soyad = "GÜL";
            musteri2.Adres = "Pendik İSTANBUL";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Ahmet";
            musteri3.Soyad = "Ören";
            musteri3.Adres = "Çankaya ANKARA";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Aslı";
            musteri4.Soyad = "ÇAN";
            musteri4.Adres = "Beytepe ANKARA";
            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3,musteri4};

            

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("MÜŞTERİ EKLEME ");
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("---------------------------");
            Console.WriteLine("MÜŞTERİ SİLME ");
            musteriManager.Silme(musteri4);
            Console.WriteLine("---------------------------");
            Console.WriteLine("MÜŞTERİ LİSTELEME ");
            musteriManager.Liste(musteriler);


           
        }
    }
}
