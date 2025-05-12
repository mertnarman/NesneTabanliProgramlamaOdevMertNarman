using System;

namespace SinifOrnegi
{
    class Program
    {
        
        class Bisiklet
        {
            
            private int hiz = 0;
            private int vites = 1;
            public int VitesSayisi = 18;

            
            public Bisiklet()
            {
                vites = 1;
                hiz = 0;
                VitesSayisi = 18;
            }

            
            public Bisiklet(int vitesSayisi)
            {
                VitesSayisi = vitesSayisi;
            }

            
            public void VitesDegistir(int yeniVites)
            {
                vites = yeniVites;
            }

            public void Hizlan(int artis)
            {
                hiz += artis;
            }

            public void FrenYap(int azalis)
            {
                hiz -= azalis;
                if (hiz < 0) hiz = 0;
            }

            public void BilgileriYaz()
            {
                Console.WriteLine("Vites: {0}, Hız: {1}, Vites Sayısı: {2}", vites, hiz, VitesSayisi);
            }

            
            public void AlanlariDirektDegistir(int yeniHiz, int yeniVites)
            {
                hiz = yeniHiz;
                vites = yeniVites;
            }
        }

        static void Main(string[] args)
        {
            
            Bisiklet bisiklet1 = new Bisiklet();
            bisiklet1.VitesDegistir(5);
            bisiklet1.Hizlan(20);
            bisiklet1.FrenYap(5);
            bisiklet1.BilgileriYaz();

            
            Bisiklet bisiklet2 = new Bisiklet(21); 
            bisiklet2.VitesDegistir(3);
            bisiklet2.Hizlan(10);
            bisiklet2.FrenYap(3);
            bisiklet2.BilgileriYaz();

            
            bisiklet1.AlanlariDirektDegistir(50, 7);
            bisiklet1.BilgileriYaz();
        }
    }
}
