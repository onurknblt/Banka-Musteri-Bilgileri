using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class MusteriManager
    {
        public void Ekle(string musteriAdi, string musteriSoyadi, int musteriTc, int musteriNo)
        {

            Console.WriteLine("Şu kişi eklendi:" + musteriAdi +" "+ musteriSoyadi);
        }

        public void Sil (string musteriAdi, string musteriSoyadi, int musteriTc, int musteriNo)
        {

            Console.WriteLine("Şu kişi silindi: " + musteriAdi +" "+ musteriSoyadi);
        }

    }
}
