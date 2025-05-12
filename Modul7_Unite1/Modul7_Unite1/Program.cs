using Modul7_Unite1;
using System;

class Program
{
    static void Main(string[] args)
    {
        Ogrenci birOgrenci = new Ogrenci("Ali UZUN");
        Console.WriteLine("Adı");
        Console.Write("{0}", birOgrenci.Ad);
        Console.WriteLine("Boyu");
        Console.Write("{0}", birOgrenci.Boy);
        Console.WriteLine("Kilosu");
        Console.Write("{0}", birOgrenci.Kilo);

        Console.WriteLine("\n");
        Daire daire = new Daire(3.0);
        Console.WriteLine("Kürenin Alanı:");
        Console.WriteLine("{0}", daire.Alan());
    }
}
