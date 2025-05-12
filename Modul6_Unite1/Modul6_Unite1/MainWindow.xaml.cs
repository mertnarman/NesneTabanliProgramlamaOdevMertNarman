using System;
using System.Windows;

namespace Modul6_Unite1
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, RoutedEventArgs e)
        {
            islem();
        }

        public void islem()
        {
            try
            {
                int sayi1 = Convert.ToInt32(TextBox1.Text);
                int sayi2 = Convert.ToInt32(TextBox2.Text);

                int sonuc = sayi1 + sayi2;

                TextBox3.Text = sonuc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz!");
            }
        }
    }
}
