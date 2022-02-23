using System;

namespace OOP
{
    class Program
    {

        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mehmet";
            musteri1.Soyadi = "Ortaburun";
            musteri1.TcNo = "12345678912";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama.ıo";
            musteri2.VergiNo = "9876543210";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //Musteri sınıfından kalıtılmıs tüm değerleri ekler
            // Ekle() metodu parametre olarak Musteri sınıfından bir nesne alır
            // Polimorfizim işlemi 
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);





        }
    }
}
