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
    public partial class personeltatilgunleri : UserControl
    {
        public personeltatilgunleri()
        {
            InitializeComponent();
        }
        public int personelno=0;
        private void personeltatilgunleri_Load(object sender, EventArgs e)
        {
            int pno = personelno;
            izinguncelle();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            personel.izingunu[personelno] = comboBox1.Text;
            label2.Text = "Haftalık İzin Günü : " + personel.izingunu[personelno];
        }



        private void button4_Click(object sender, EventArgs e)
        {
            personel.yillikizinkalan[personelno]--;if (personel.yillikizinkalan[personelno] < 0) personel.yillikizinkalan[personelno] = 0;
            izinguncelle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            personel.yillikizinkalan[personelno]++;
            if (personel.yillikizinkalan[personelno] > 14) personel.yillikizinkalan[personelno] = 14;
            izinguncelle();
        }

        private void izinguncelle()
        {
            label1.Text = personel.adisoyadi[personelno];
            label2.Text = "Haftalık İzin Günü : " + personel.izingunu[personelno];
            label3.Text = "Yıllık İzin Kalanı : " + personel.yillikizinkalan[personelno];
        }
    }
}
