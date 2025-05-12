using System;

namespace kutulamaOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 123;       
            object obj;           

            
            obj = sayi;
            Console.WriteLine("Boxing işlemi yapıldı. obj: " + obj);

           
            int sayi2 = (int)obj;
            Console.WriteLine("Unboxing işlemi yapıldı. sayi2: " + sayi2);

            
            if (obj is int)
            {
                Console.WriteLine("obj değişkeni int türündedir.");
            }

            
            object kelime = "Merhaba";
            string str = kelime as string;

            if (str != null)
            {
                Console.WriteLine("Dönüşüm başarılı: " + str);
            }
        }
    }
}
