using System;
using System.Windows.Forms;

namespace marketpanelim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int yetkino;
        private void button1_Click(object sender, EventArgs e)
        {
            girisbutonu();
            
        }

        private void girisbutonu()
        {
            if ((textBox1.Text == "admin" && textBox2.Text == "123") || (textBox1.Text == "mudur" && textBox2.Text == "123") || (textBox1.Text == "MY" && textBox2.Text == "123"))
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış bilgi girdiniz. Tekrar deneyin");
                textBox1.Clear();
                textBox2.Clear();
            }
        }


        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)  girisbutonu();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) girisbutonu();
      
        }
    }
}
