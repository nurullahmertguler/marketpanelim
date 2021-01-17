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
    public partial class urunstokdurumlari : Form
    {
        public urunstokdurumlari()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();f2.Show();this.Hide();
        }

        private void urunstokdurumlari_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < market.subekodu; i++)
            {
                urunler ml = new urunler();
                ml.label1.Text = market.marketadi[i];
                ml.subeno = i;ml.gida = market.gida_stogu[i];ml.temizlik = market.temizlik_stogu[i];ml.kampanya = market.kampanyali_stogu[i];
                flowLayoutPanel1.Controls.Add(ml);
            }
        }
    }
}
