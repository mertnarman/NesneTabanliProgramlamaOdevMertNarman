using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul2_unite2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tarih bugun = new Tarih(7, 5, 2025);
            MessageBox.Show("Bugünün tarihi: " + bugun.gun + "/" + bugun.ay + "/" + bugun.yil);
        }
    }

    
    struct Tarih
    {
        public int gun;
        public int ay;
        public int yil;

        
        public Tarih(int g, int a, int y)
        {
            gun = g;
            ay = a;
            yil = y;
        }
    }
}
