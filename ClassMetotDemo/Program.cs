using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.Id = 01;
            Musteri1.Adi = "Melek";
            Musteri1.Soyadi = "Melek";
            Musteri1.Ikametgah = "Ankara";

            Musteri Musteri2 = new Musteri();
            Musteri2.Id = 02;
            Musteri2.Adi = "Salih";
            Musteri2.Soyadi = "Gül";
            Musteri2.Ikametgah = "İstanbul";

            Musteri Musteri3 = new Musteri();
            Musteri3.Id = 03;
            Musteri3.Adi = "Polat";
            Musteri3.Soyadi = "Alemdar";
            Musteri3.Ikametgah = "Almanya";


            MusteriManager mManager = new MusteriManager();
            mManager.Ekle(Musteri1);
            mManager.Sil(Musteri1);
            mManager.Listele(Musteri1);
            mManager.Listele(Musteri2);
            mManager.Listele(Musteri3);


            //Seçilen müşterileri foreach döngüsü ile konsol ekranına yazdıran Kod 

            /*
            Musteri[] musteriler = new Musteri[] { Musteri1, Musteri2 };
            foreach (var manager in musteriler)
            {
                Console.WriteLine(manager.Id);
                Console.WriteLine(manager.Adi);
                Console.WriteLine(manager.Soyadi);
                Console.WriteLine(manager.Ikametgah);
                Console.WriteLine("-----------------");
            }
            */
            Console.ReadKey();
        }
    }
}
