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
    public partial class personeltatilbilgileri : Form
    {
        public personeltatilbilgileri()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();f2.Show();this.Hide();
        }

        private void personeltatilbilgileri_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < personel.adisoyadi.Length; i++)
            {
                if (personel.adisoyadi[i] != null)
                {
                    personeltatilgunleri ptg = new personeltatilgunleri();
                    ptg.personelno = i;
                    flowLayoutPanel1.Controls.Add(ptg);
                }
                
            }
        }
    }
}
