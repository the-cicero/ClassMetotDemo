using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri kaydı oluşturuldu. -----> " +  musteri.Adi +" " + musteri.Soyadi);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Bu müşteri silindi. ----> " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void İptal(Musteri musteri) //50 puan altındaki müşteri kredi alamaz diyelim.
        {
            Console.WriteLine("Bu müşteri Kredi alamaz. ----> " + musteri.Adi + " " + musteri.Soyadi);
        }
    }
}
