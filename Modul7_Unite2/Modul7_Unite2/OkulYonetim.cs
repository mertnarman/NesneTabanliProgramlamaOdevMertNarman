namespace Arayuzler
{
    interface IInsan
    {
        void Buyu();
    }

    public abstract class OkuyanInsan
    {
        public void Oku()
        {
            Console.WriteLine("Okudum.");
        }
    }

    public class Ogrenci : OkuyanInsan, IInsan
    {
        public void Buyu()
        {
            Console.WriteLine("Hızlı büyüdüm.");
        }
    }

    public class Ogretmen : OkuyanInsan, IInsan
    {
        public void Buyu()
        {
            Console.WriteLine("Yavaş büyüdüm.");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Ogrenci birOgrenci = new Ogrenci();
            Ogretmen birOgretmen = new Ogretmen();

            birOgrenci.Buyu();
            birOgretmen.Buyu();
            birOgrenci.Oku();
            birOgretmen.Oku();

            Console.ReadLine();
        }
    }
}
