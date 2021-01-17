using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketpanelim
{
    public partial class urunler : UserControl
    {
        public urunler()
        {
            InitializeComponent();
        }
        public int subeno,gida,temizlik,kampanya;

        private void button2_Click(object sender, EventArgs e)
        {
            gida += 10;
            guncelle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gida += 100;
            guncelle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gida -= 1; if (gida < 0) gida = 0;
            guncelle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gida -= 10; if (gida < 0) gida = 0;
            guncelle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gida -= 100; if (gida < 0) gida = 0;
            guncelle();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            temizlik += 1;
            guncelle();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            temizlik += 10;
            guncelle();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            temizlik += 100;
            guncelle();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            temizlik -= 1; if (temizlik < 0) temizlik = 0;
            guncelle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            temizlik -= 10; if (temizlik < 0) temizlik = 0;
            guncelle();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            temizlik -= 100;
            if (temizlik < 0) temizlik = 0;
            guncelle();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            kampanya += 1;
            guncelle();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            kampanya += 10;
            guncelle();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            kampanya += 100;
            guncelle();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            kampanya -= 1; if (kampanya < 0) kampanya = 0;
            guncelle();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            kampanya -= 10; if (kampanya < 0) kampanya = 0;
            guncelle();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kampanya -= 100; if (kampanya < 0) kampanya = 0;
            guncelle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gida += 1;
            guncelle();
        }

        private void urunler_Load(object sender, EventArgs e)
        {
            guncelle();
        }
        private void guncelle()
        {
            label2.Text = "Gıda Ürünleri\n" + gida.ToString();
            market.gida_stogu[subeno] = gida;
            label3.Text = "Temizlik Ürünleri\n" + temizlik.ToString();
            market.temizlik_stogu[subeno] = temizlik;
            label4.Text = "Kampanyalı Ürünleri\n" + kampanya.ToString();
            market.kampanyali_stogu[subeno] = kampanya;
        }
    }
}
