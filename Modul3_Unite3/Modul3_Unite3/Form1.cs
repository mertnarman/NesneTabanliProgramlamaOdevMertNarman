using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_Unite3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

         
            int toplam = 0;

            
            int baslangic = Math.Min(sayi1, sayi2);  
            int bitis = Math.Max(sayi1, sayi2);      

           
            for (int i = baslangic; i <= bitis; i++)
            {
                toplam += i;  
            }

            label3.Text = "Toplam: " + toplam.ToString();
        }

    }
}
