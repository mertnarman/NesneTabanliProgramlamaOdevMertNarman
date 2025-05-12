using System;
using Modul8_Unite2; 

class Program
{
    static void Main(string[] args)
    {
        Sepet sepet = new Sepet();

        sepet.UrunEklendi += Sepet_UrunEklendi;

        while (true)
        {
            Console.Write("Ürün Adı (Çıkmak için 'q' yaz): ");
            string? ad = Console.ReadLine();
            if (string.IsNullOrEmpty(ad))
                continue;

            if (ad.ToLower() == "q")
                break;

            Console.Write("Fiyat: ");
            string? fiyatGirdi = Console.ReadLine();

            if (decimal.TryParse(fiyatGirdi, out decimal fiyat))
            {
                Urun urun = new Urun { Ad = ad, Fiyat = fiyat };
                sepet.UrunEkle(urun);
            }
            else
            {
                Console.WriteLine("Geçerli bir fiyat giriniz!");
            }
        }
    }

    private static void Sepet_UrunEklendi(object? sender, EventArgs e)
    {
        if (sender is Sepet sepet)
        {
            Console.WriteLine($"Toplam Tutar: {sepet.ToplamTutar()} TL\n");
        }
    }
}
