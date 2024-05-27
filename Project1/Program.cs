namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriAdi = "Onur";
            musteri1.musteriSoyadi = "Kanbolat";
            musteri1.musteriNo = 2021469025;
            musteri1.musteriTc = 5353536472;

            Musteri musteri2 = new Musteri();
            musteri2.musteriAdi = "Uğur";
            musteri2.musteriSoyadi = "Yılmaz";
            musteri2.musteriNo = 2345743829;
            musteri2.musteriTc = 738495432;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };


            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.musteriAdi);
                Console.WriteLine(musteri.musteriSoyadi);
                Console.WriteLine(musteri.musteriNo);
                Console.WriteLine(musteri.musteriTc);
                Console.WriteLine("------- MÜŞTERİLER LİSTELENDİ------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("Müşteriler Eklendi");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            Console.WriteLine("Müşteriler Silindi");


            Console.WriteLine("Bütün İşlemler Başarıyla Tamamlandı");
        }
    }
}
