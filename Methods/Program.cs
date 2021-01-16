using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1= new Urun();
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 10;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("-----------Metodlar---------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut","yeşilarmut",15,4);
            sepetManager.Ekle2("elma", "yeşilelma", 15,54);
            sepetManager.Ekle2("karpuz", "diyarbakır", 15,32);
        }
    }
}
