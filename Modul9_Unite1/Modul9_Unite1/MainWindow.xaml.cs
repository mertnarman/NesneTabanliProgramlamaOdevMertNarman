using System;
using System.Windows;
using Microsoft.Win32;

namespace Modul9_Unite1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Medya Dosyaları|*.mp4;*.wmv;*.avi";
            if (dialog.ShowDialog() == true)
            {
                Uri medyaYol = new Uri(dialog.FileName);
                string[] dosya = dialog.FileName.Split('\\');
                liste.Items.Add(dosya[dosya.Length - 1]); 
                media.Source = medyaYol;
            }
        }

        private void temizle_Click(object sender, RoutedEventArgs e)
        {
            liste.Items.Clear();
        }

        private void yurut_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        private void dur_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
        }

        private void ses_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (media != null) 
            {
                media.Volume = ses.Value;
            }
        }

    }
}
