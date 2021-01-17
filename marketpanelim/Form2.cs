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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int a = 0,personelsayisi=0,urunsayisi=0,toplampersonelsayisi = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            
            if (a==0)
            {
                marketleritanimla();
                personelleritanimla();
                tedarikcitanimla();
                a++;
            }
            genelraporyaz();
        }

        private void tedarikcitanimla()
        {
            tedarikcibilgileri.gida_tedarikcileri[0] = "Gazi Gıda : Karapürçek Mahllesi Ankara/Altındağ";
            tedarikcibilgileri.gida_tedarikcileri[1] = "Bal Gıda : Başak Mahllesi Ankara/Mamak";
            tedarikcibilgileri.gida_tedarikcileri[2] = "Can Gıda : Gazi Mahllesi Ankara/Altındağ";

            tedarikcibilgileri.temizlik_tedarikcileri[0] = "Ankara Kimya : Ankara/Aktaş";
            tedarikcibilgileri.temizlik_tedarikcileri[1] = "Atatürk Kimya : Ankara/Altındağ";

            tedarikcibilgileri.kampanyali_tedarikcileri[0] = "Haydar Plastik : Ankara/Mamak";
            tedarikcibilgileri.kampanyali_tedarikcileri[1] = "Metemer Toptan : Ankara/Çankaya";

        }
        
        private void genelraporyaz()
        {
            label1.Text = "Şube Sayısı : " + market.subekodu.ToString();

            for (int i = 0; i < personel.adisoyadi.Length; i++)
            {
                if (personel.adisoyadi[i] != null)personelsayisi++;
            }
            toplampersonelsayisi = personelsayisi;
            label2.Text = "Personel Sayısı : " + personelsayisi.ToString(); personelsayisi = 0;

            for (int j = 0; j < market.subekodu; j++)
            {
                urunsayisi += market.gida_stogu[j] + market.temizlik_stogu[j] + market.kampanyali_stogu[j];
            }
            label3.Text = "Ürün Sayısı : " + urunsayisi.ToString();urunsayisi = 0;

        }
        private void marketleritanimla()
        {
            market.marketadi[0] = "A102 Ankara Mamak Şubesi";
            market.marketadres[0] = "Başak Mahallesi Ankara/Mamak";
            market.gida_stogu[0] = 47;
            market.temizlik_stogu[0] = 54;
            market.kampanyali_stogu[0] = 77;
            market.subeno[0] = 0;
            market.subekodu++;

            market.marketadi[1] = "A102 Ankara Altındağ Şubesi";
            market.marketadres[1] = "Karapürçek Mahallesi Ankara/Altındağ";
            market.gida_stogu[1] = 38;
            market.temizlik_stogu[1] = 45;
            market.kampanyali_stogu[1] = 68;
            market.subeno[1] = 1;
            market.subekodu++;
        }
        private void personelleritanimla()
        {
            personel.adisoyadi[0] = "Nurullah Mert GULER";
            personel.izingunu[0] = "Salı";
            personel.adresi[0] = "Karapürçek mahallesi Ankara/Altındağ";
            personel.isbaslangici[0] = "01.07.2018";
            personel.maas[0] = 2224;
            personel.pozisyon[0] = "Kasiyer";
            personel.calisilansubekodu[0] = 0;
            personel.yillikizinkalan[0] = 13;

            personel.adisoyadi[1] = "Berk TUNA";
            personel.izingunu[1] = "Pazartesi";
            personel.adresi[1] = "Kurtuluş mahallesi Ankara/Çankaya";
            personel.isbaslangici[1] = "22.10.2019";
            personel.maas[1] = 3224;
            personel.pozisyon[1] = "Müdür Yardımcısı";
            personel.calisilansubekodu[1] = 0;
            personel.yillikizinkalan[1] = 12;

            personel.adisoyadi[2] = "Ömer KİLLİK";
            personel.izingunu[2] = "Cuma";
            personel.adresi[2] = "Başak mahallesi Ankara/Mamak";
            personel.isbaslangici[2] = "11.03.2020";
            personel.maas[2] = 4224;
            personel.pozisyon[2] = "Müdür";
            personel.calisilansubekodu[2] = 0;
            personel.yillikizinkalan[2] = 10;

            personel.adisoyadi[3] = "Bedirhan ŞAHAN";
            personel.izingunu[3] = "Çarşamba";
            personel.adresi[3] = "Gazi mahallesi Ankara/Altındağ";
            personel.isbaslangici[3] = "05.03.2020";
            personel.maas[3] = 2224;
            personel.pozisyon[3] = "Kasiyer";
            personel.calisilansubekodu[3] = 1;
            personel.yillikizinkalan[3] = 8;

            personel.adisoyadi[4] = "Metehan KAÇAN";
            personel.izingunu[4] = "Pazartesi";
            personel.adresi[4] = "Önder mahallesi Ankara/Altındağ";
            personel.isbaslangici[4] = "05.05.2019";
            personel.maas[4] = 3224;
            personel.pozisyon[4] = "Müdür Yardımcısı";
            personel.calisilansubekodu[4] = 1;
            personel.yillikizinkalan[4] = 11;

            personel.adisoyadi[5] = "Enes ELMALI";
            personel.izingunu[5] = "Cuma";
            personel.adresi[5] = "Gülveren mahallesi Ankara/Mamak";
            personel.isbaslangici[5] = "02.03.2019";
            personel.maas[5] = 4224;
            personel.pozisyon[5] = "Müdür";
            personel.calisilansubekodu[5] = 1;
            personel.yillikizinkalan[5] = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunstokdurumlari usd = new urunstokdurumlari();
            usd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personeltatilbilgileri ptb = new personeltatilbilgileri();
            ptb.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tedarikcilerim tdk = new tedarikcilerim();
            tdk.Show();
            this.Hide();
        }




        private void button8_Click(object sender, EventArgs e)
        {
            adresler adrsler = new adresler();
            adrsler.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            personellerim prsnllerim = new personellerim();
            prsnllerim.Show();
            this.Hide();
        }
    }
}
