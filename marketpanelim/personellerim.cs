using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketpanelim
{
    public partial class personellerim : Form
    {
        public personellerim()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); f2.Show(); this.Hide();
        }

        private void personellerim_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < personel.adisoyadi.Length; i++)
            {
                if (personel.adisoyadi[i] != null)
                {
                    personellerilistele pl = new personellerilistele();
                    pl.label1.Text = personel.adisoyadi[i];
                    pl.label2.Text = "İzin günü : " + personel.izingunu[i];
                    pl.label3.Text = "Adresi : " + personel.adresi[i];
                    pl.label4.Text = "İşe başlangıç : " + personel.isbaslangici[i];
                    pl.label5.Text = "Pozisyonu : " + personel.pozisyon[i];
                    pl.label6.Text = "Çalıştığı şube : " + market.marketadi[personel.calisilansubekodu[i]];
                    pl.label7.Text = "Maas : " + personel.maas[i];
                    pl.personelno = i;
                    flowLayoutPanel1.Controls.Add(pl);
                }
            }
        }
    }
}
