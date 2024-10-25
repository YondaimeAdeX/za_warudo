using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace za_warudo
{
    public partial class Form1 : Form
    {
        int x = 0;
        int tpl = 0;
        int syc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayac = 0;
            while (sayac<=50)
            {
                listBox1.Items.Add(sayac);
                sayac++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int sayi,sayac=0;
            sayi = int.Parse(textBox1.Text);
            while (sayac<sayi)
            {
                listBox2.Items.Add("Adem");
                sayac++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            int rastgeleSayi, sayac = 0, toplam = 0;
            Random rnd = new Random();
            while (sayac<20)
            {
                rastgeleSayi = rnd.Next(100);
                toplam += rastgeleSayi;
                listBox3.Items.Add(rastgeleSayi);
                sayac++;
            }
            label2.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string aranan;
            aranan = textBox2.Text;
            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                if (listBox4.Items[i].ToString()==aranan)
                {
                    MessageBox.Show("Aranan Kişi Bulundu");
                    break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x++;
            label3.Text = x.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x--;
            label3.Text = x.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = int.Parse(textBox3.Text);
                if (tpl<50)
                {
                    tpl += sayi;
                    syc++;
                }
                label6.Text = tpl.ToString();
                label7.Text = syc.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş", "Hata");
            }
        }
    }
}
