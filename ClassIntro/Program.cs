using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();//2-örnekle
            kurs1.KursAdi = "C#";//3-tanımla
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 61;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 61;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.IzlenmeOrani = 67;

            //Console.WriteLine(kurs1.KursAdi+":"+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };//4-array oluştur
            foreach (var kurs in kurslar)//5-diziyidolaş
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }//1-prop
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
