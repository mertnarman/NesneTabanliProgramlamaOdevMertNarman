using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_unite1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 16, b = 12, c = 10;
            double islem1, islem2, islem3;

            
            islem1 = a + c / (b - c) * 10;
            MessageBox.Show("Parantezli Sonuç: " + islem1);

            
            islem2 = a + c / b - c * 10;
            MessageBox.Show("Parantezsiz Sonuç: " + islem2);

            
            islem3 = a + (c * 10) / (b - c);
            MessageBox.Show("Çarpma ve Bölme Yer Değiştirilmiş Sonuç: " + islem3);

           
            if (islem1 > 0)
            {
                MessageBox.Show("Sonuç pozitif");
            }
            else
            {
                MessageBox.Show("Sonuç negatif");
            }

          
            bool sonucDogruMu = islem1 > 0 ? true : false;
            MessageBox.Show("Sonuç pozitif mi? " + sonucDogruMu);
        }

    }
}
