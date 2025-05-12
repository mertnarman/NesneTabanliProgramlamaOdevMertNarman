using System;

namespace TemsilciOrnek
{
    class Program
    {
        public delegate void SiralamaTemsilcisi(ref string[] kelimeler);

        static void Main(string[] args)
        {
            string[] kelimeler = { "elma", "armut", "üzüm", "kiraz" };

            Console.WriteLine("Sıralanmamış Dizi:");
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }

            SiralamaTemsilcisi temsilci;

            temsilci = AZSirala;
            temsilci(ref kelimeler);

            temsilci = DiziYazdir;
            temsilci(ref kelimeler);

            temsilci = ZASirala;
            temsilci(ref kelimeler);

            temsilci = DiziYazdir;
            temsilci(ref kelimeler);

            temsilci = AZSirala;
            temsilci += DiziYazdir;
            temsilci += ZASirala;
            temsilci += DiziYazdir;

            Console.WriteLine("\nÇoklu Çağırım Sonucu:");
            temsilci(ref kelimeler);
        }


        public static void AZSirala(ref string[] dizi)
        {
            Array.Sort(dizi);
            Console.WriteLine("Dizi A-Z'ye göre sıralandı.");
        }

        public static void ZASirala(ref string[] dizi)
        {
            Array.Sort(dizi);
            Array.Reverse(dizi);
            Console.WriteLine("Dizi Z-A'ya göre sıralandı.");
        }

        public static void DiziYazdir(ref string[] dizi)
        {
            Console.WriteLine("Dizi Elemanları:");
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }

    }
}
