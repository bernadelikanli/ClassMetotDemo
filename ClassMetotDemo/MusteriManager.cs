using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
     public void Ekle(Musteri musteri)
        {
            
             Console.WriteLine("Müşteri Eklendi"+ "\n"+musteri.Id + "\n" + musteri.Ad + " " + musteri.Soyad + "\n" + musteri.Adres + "\n" );

        }
     public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi"+"\n"+musteri.Id+"\n"+musteri.Ad+" "+musteri.Soyad+"\n"+musteri.Adres);
        }
     public void Liste(Musteri[] musteriler )
        {
            Console.WriteLine("Müşteri Listelendi");
      
            foreach (var yaz in musteriler)
            {
                Console.WriteLine(yaz.Id + "\n" + yaz.Ad + " " + yaz.Soyad + "\n" + yaz.Adres);
            }
            
          
        }
    }
}
