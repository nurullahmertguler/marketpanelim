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
    public partial class personellerilistele : UserControl
    {
        public personellerilistele()
        {
            InitializeComponent();
        }
        public int personelno;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Geçersiz değer");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int zammiktari = Convert.ToInt16(textBox1.Text);
            personel.maas[personelno] = personel.maas[personelno] * zammiktari / 100 + personel.maas[personelno];
            label7.Text = "Maas : " + personel.maas[personelno];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (personel.pozisyon[personelno] == "Müdür") personel.pozisyon[personelno] = "Müdür Yardımcısı";
            else if (personel.pozisyon[personelno] == "Müdür Yardımcısı") personel.pozisyon[personelno] = "Kasiyer";
            label5.Text = "Pozisyonu : " + personel.pozisyon[personelno];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (personel.pozisyon[personelno] == "Kasiyer") personel.pozisyon[personelno] = "Müdür Yardımcısı";
            else if (personel.pozisyon[personelno] == "Müdür Yardımcısı") personel.pozisyon[personelno] = "Müdür";
            label5.Text = "Pozisyonu : " + personel.pozisyon[personelno];
        }
        private int subekodu =0;
        private void button5_Click(object sender, EventArgs e)
        {
            subekodu -= 1;
            if (subekodu < 0) subekodu = 0;
            personel.calisilansubekodu[personelno] = subekodu;
            label6.Text = "Çalıştığı şube : " + market.marketadi[personel.calisilansubekodu[personelno]];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            subekodu+=1;
            if (subekodu >= market.subekodu) subekodu = market.subekodu-1;
            personel.calisilansubekodu[personelno] = subekodu;
            label6.Text = "Çalıştığı şube : " + market.marketadi[personel.calisilansubekodu[personelno]];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
