using System;

namespace zarAtmaUygulamasi
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

            int sayi = rnd.Next(1, 6);

            if (sayi == 1)
            {
                pictureBox1.Visible = true;
            }
            else if (sayi == 2)
            {
                pictureBox2.Visible = true;
            }
            else if (sayi == 3)
            {
                pictureBox3.Visible = true;
            }
            else if (sayi == 4)
            {
                pictureBox4.Visible = true;
            }
            else if (sayi == 5)
            {
                pictureBox5.Visible = true;
            }
            else if (sayi == 6)
            {
                pictureBox6.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }
    }
}