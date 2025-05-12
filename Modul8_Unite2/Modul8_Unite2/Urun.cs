using System;
using System.Collections.Generic;

namespace Modul8_Unite2
{
    public class Urun
    {
        public string? Ad { get; set; }
        public decimal Fiyat { get; set; }
    }

    public class Sepet
    {
        public List<Urun> Urunler { get; set; } = new List<Urun>();

        public event EventHandler? UrunEklendi;

        public void UrunEkle(Urun urun)
        {
            Urunler.Add(urun);
            UrunEklendi?.Invoke(this, EventArgs.Empty);
        }

        public decimal ToplamTutar()
        {
            decimal toplam = 0;
            foreach (var urun in Urunler)
            {
                toplam += urun.Fiyat;
            }
            return toplam;
        }
    }

    public class Makine
    {
        private int _sicaklik;

        public int Sicaklik
        {
            get { return _sicaklik; }
            set
            {
                _sicaklik = value;
                if (_sicaklik > 1000)
                {
                    SicaklikYukseldi?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler? SicaklikYukseldi;

        public void Kapat()
        {
            Console.WriteLine("Makine kapatılıyor! Sıcaklık aşırı yüksek.");
        }
    }
}
