using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri Ekle)
        {
            Console.WriteLine("************************************************************************");
            Console.WriteLine("***Müşteri Eklenmiştir!*** No:" + Ekle.Id + " Ad Soyad:" + Ekle.Adi + " " + Ekle.Soyadi+ " İkametgah Adresi:" +Ekle.Ikametgah);
            Console.WriteLine("************************************************************************");
        }
        public void Sil(Musteri Sil)
        {
            Console.WriteLine("************************************************************************");
            Console.WriteLine("***Bilgileri Yazılan Müşteri Silinmiştir!*** "+Sil.Id+" "+Sil.Adi+" "+Sil.Soyadi+" "+Sil.Ikametgah);
            Console.WriteLine("************************************************************************");
        }
        public void Listele(Musteri listele)
        {
            Console.WriteLine("****************************");
            Console.WriteLine(listele.Id);
            Console.WriteLine(listele.Adi);
            Console.WriteLine(listele.Soyadi);
            Console.WriteLine(listele.Ikametgah);
            Console.WriteLine("****************************");
        }
    }
}
