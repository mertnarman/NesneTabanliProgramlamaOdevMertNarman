using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_Unite2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kat = Convert.ToInt32(textBox1.Text);

            switch (kat)
            {
                case 0:
                    label1.Text = "Zemin Kat: Danışma, Güvenlik, Yemekhane";
                    break;
                case 1:
                    label1.Text = "1. Kat: Müdür Odası, Öğretmenler Odası";
                    break;
                case 2:
                    label1.Text = "2. Kat: Laboratuvarlar, Bilgisayar Sınıfı";
                    break;
                case 3:
                    label1.Text = "3. Kat: Kütüphane, Konferans Salonu";
                    break;
                default:
                    label1.Text = "Lütfen 0-3 arasında bir kat numarası giriniz...";
                    break;
            }
        }


    }
}
