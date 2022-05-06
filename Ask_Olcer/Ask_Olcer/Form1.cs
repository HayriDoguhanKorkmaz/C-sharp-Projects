using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ask_Olcer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int deger = rnd.Next(0, 101);
            if (deger >= 66) 
            {
                string isim1 = textBox1.Text;
                string isim2 = textBox2.Text;

                pictureBox1.Visible = true;
                listBox1.Items.Add(isim1 + " " + isim2 + " birbiriniz için yaratılmışsınız " + "%"+deger);
            }
            else if (deger >=33)
            {
                string isim1 = textBox1.Text;
                string isim2 = textBox2.Text;
                pictureBox1.Visible = true;
                listBox1.Items.Add(isim1 + " " + isim2 + " oluru var " + "%"+deger);
            }
            else
            {
                string isim1 = textBox1.Text;
                string isim2 = textBox2.Text;

                pictureBox2.Visible = true;
                listBox1.Items.Add(isim1 + " " + isim2 + " Sizden olmaz " + "%"+deger);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }
    }
}
