using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "kamp", "başlangıç", "java","python" };
            for (int i = 1; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("footer");
            Console.ReadLine();
        }
    }
}
