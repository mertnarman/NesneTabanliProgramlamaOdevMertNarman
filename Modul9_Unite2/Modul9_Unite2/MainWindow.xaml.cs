using System.Windows;

namespace UyeKayit
{
    public partial class MainWindow : Window
    {
        public Uye uye { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Üye nesnesi oluştur
            uye = new Uye();

            // Grid bileşenine veri kaynağı olarak göster
            this.DataContext = uye;
        }
    }
}
