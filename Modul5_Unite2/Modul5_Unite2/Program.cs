using System;

namespace StaticOrnegi
{
    class Program
    {
      
        class Nokta
        {
            private int x, y;
            private static int noktaSayisi = 0;

            public Nokta()
            {
                this.x = 0;
                this.y = 0;
                noktaSayisi++;
            }

            public Nokta(int x, int y)
            {
                this.x = x;
                this.y = y;
                noktaSayisi++;
            }

            public static int NoktaSayisiGetir()
            {
                return noktaSayisi;
            }
        }

        static void Main(string[] args)
        {
            Nokta n1 = new Nokta();

            Nokta n2 = new Nokta(5, 10);

            Nokta n3 = new Nokta(20, 30);

            Console.WriteLine("Toplam Nokta Sayısı: " + Nokta.NoktaSayisiGetir());
        }
    }
}
