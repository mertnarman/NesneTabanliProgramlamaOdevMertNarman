using System;

namespace refOrnegi
{
    class Program
    {
        static void DegerArtir(ref int sayi)
        {
            sayi = sayi + 1;
        }

        static void Main(string[] args)
        {
            int sayi = 5; 
            DegerArtir(ref sayi); 
            Console.WriteLine("Sayı: " + sayi);
        }
    }
}
