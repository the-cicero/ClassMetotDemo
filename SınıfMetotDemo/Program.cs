using System;

namespace ClassMetotDemo
{

    class Program
    {


        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Mehmet Arif";
            musteri1.Soyadi = "AKÇADAĞ";
            musteri1.TcKimlikNo = 12312312312;
            musteri1.KrediPuani = 100;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Mustafa";
            musteri2.Soyadi = "BLABLA";
            musteri2.TcKimlikNo = 23423423423;
            musteri2.KrediPuani = 70;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Adem";
            musteri3.Soyadi = "ksksks";
            musteri3.TcKimlikNo = 34534534534;
            musteri3.KrediPuani = 30;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id Numarası: " + musteri.Id);
                Console.WriteLine("Müşteri İsmi: " + musteri.Adi);
                Console.WriteLine("Müşteri Soyismi: " + musteri.Soyadi);
                Console.WriteLine("Müşteri Kredi Puanı: " + musteri.KrediPuani);
                Console.WriteLine("Müşteri TC Kimlik Numarası: " + musteri.TcKimlikNo);
                Console.WriteLine("==========================\n");
            }

            Console.WriteLine("********  MÜŞTERİLERİ LİSTELE  ********\n");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);  
            musteriManager.Ekle(musteri3);

            Console.WriteLine("\n");
            musteriManager.Silme(musteri2);

            Console.WriteLine("\n");
            musteriManager.İptal(musteri3);
            



        }

    }


}
