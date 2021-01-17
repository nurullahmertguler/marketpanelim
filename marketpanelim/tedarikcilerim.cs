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
    public partial class tedarikcilerim : Form
    {
        public tedarikcilerim()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void tedarikcilerim_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tedarikcibilgileri.gida_tedarikcileri.Length; i++)
            {
                if (tedarikcibilgileri.gida_tedarikcileri[i] != null)
                {
                    tedarikciler td = new tedarikciler();
                    td.label1.Text = tedarikcibilgileri.gida_tedarikcileri[i];
                    td.BackColor = Color.Lime;
                    flowLayoutPanel1.Controls.Add(td);
                }
            }
                for (int i = 0; i < tedarikcibilgileri.temizlik_tedarikcileri.Length; i++)
                {
                    if (tedarikcibilgileri.temizlik_tedarikcileri[i] != null)
                    {
                        tedarikciler td = new tedarikciler();
                        td.label1.Text = tedarikcibilgileri.temizlik_tedarikcileri[i];
                        td.BackColor = Color.BlueViolet;
                        flowLayoutPanel1.Controls.Add(td);
                    }
                }
                for (int i = 0; i < tedarikcibilgileri.kampanyali_tedarikcileri.Length; i++)
                {
                    if (tedarikcibilgileri.kampanyali_tedarikcileri[i] != null)
                    {
                        tedarikciler td = new tedarikciler();
                        td.label1.Text = tedarikcibilgileri.kampanyali_tedarikcileri[i];
                        td.BackColor = Color.OrangeRed;
                        flowLayoutPanel1.Controls.Add(td);
                    }
                }
                
            }
        }
    }

