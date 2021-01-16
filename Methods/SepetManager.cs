using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi:"+ urun.UrunAdi);
        }
        public void Ekle2(string urunadi, string aciklama, double fiyat,int stokAdedi)// bu şekilde de alınabilir ancak parametre eklenmeye kalkındığında metodun çağırıldığı yerde sayfalar patlar ENCAPSULATİON
        {
            Console.WriteLine("Tebrikler! Sepete eklendi:"+urunadi);
        }
    }
}
