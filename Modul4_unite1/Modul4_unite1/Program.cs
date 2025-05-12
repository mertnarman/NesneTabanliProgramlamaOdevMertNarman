using System;

namespace BasvuruTuruKopyalama
{
    class Bisiklet
    {
        int hiz = 0;
        int vites = 0;

        public Bisiklet()
        {
            vites = 18;
        }

        public void Hizlan(int artis)
        {
            hiz = hiz + artis;
        }

        public void BilgileriYaz()
        {
            Console.Write("Vites: {0} ", vites);
            Console.Write("Hız: {0}", hiz);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bisiklet bisiklet1 = new Bisiklet();
            Bisiklet bisiklet2 = bisiklet1;

            bisiklet1.Hizlan(10);

            Console.WriteLine("Bisiklet 1 Bilgileri:");
            bisiklet1.BilgileriYaz();

            Console.WriteLine("Bisiklet 2 Bilgileri:");
            bisiklet2.BilgileriYaz();
        }
    }
}
