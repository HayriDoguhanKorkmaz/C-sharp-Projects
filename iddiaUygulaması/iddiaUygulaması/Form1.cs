using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iddiaUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string evSahibi = textBox1.Text;
            string deplasman = textBox2.Text;

            Random random = new Random();
            int olasilik = random.Next(0, 101);


            if (olasilik <= 10)
            {
                listBox1.Items.Add(evSahibi + " - " + deplasman + " maçını kazanan " + evSahibi);
            }
            else if (olasilik <= 20)
            {
                listBox1.Items.Add(evSahibi + " - " + deplasman + " maçını kazanan " + deplasman);
            }
            else if (olasilik <= 30)
            {
                listBox1.Items.Add(evSahibi + " - " + deplasman + " maç sonucu 1.5 üst!");
            }
            else if (olasilik <= 40)
            {
                listBox1.Items.Add(evSahibi + " - " + deplasman + " maç sonucu 2.5 üst!");
            }
            else if (olasilik <= 50)
            {
                listBox1.Items.Add(evSahibi + " - " + deplasman + " maç sonucu 3.5 üst!");
            }
            else if (olasilik <= 60)
            {
                listBox1.Items.Add(evSahibi + " - " + deplasman + " karşılıklı gol var!");
            }
            else if (olasilik <= 70)
            {
                listBox1.Items.Add(evSahibi + " - " + deplasman + " karşılıklı gol yok!");
            }
            else if (olasilik <= 80)
            {
                listBox1.Items.Add(evSahibi + " - " + deplasman + " ilk yarı 0.5 üst!");
            }
            else if (olasilik <= 90)
            {
                listBox1.Items.Add(evSahibi + " - " + deplasman + " ilk yarı 1.5 üst!");
            }
            else if (olasilik <= 100)
            {
                listBox1.Items.Add(evSahibi + " - " + deplasman + " maçının sonucu beraberlik!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
