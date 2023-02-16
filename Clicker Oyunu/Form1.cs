using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int altin = 480;
        int hit = 10;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            lblDeger.Text = "500 Altın";
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            lblDeger.Text = "750 Altın";
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            lblDeger.Text = "1000 Altın";
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            lblDeger.Text = "1200 Altın";
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            lblDeger.Text = "1500 Altın";
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            lblDeger.Text = "1800 Altın";
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            lblDeger.Text = "2000 Altın";
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            lblDeger.Text = "2500 Altın";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            altin++;
            lblAltinSayisi.Text = altin.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblBaslangic.Visible = false;
            altin += hit;
            lblAltinSayisi.Text = altin.ToString();


        }

        private void SatinAlma(int itemDegeri, int hitDegeri, PictureBox pictureBox)
        {
            if (altin >= itemDegeri)
            {

                hit = hitDegeri;
                altin = altin - itemDegeri;
                lblAltinSayisi.Text = altin.ToString();
                pictureBox.BackColor = Color.Green; // item alındığında item arka planı yeşil olacak.
                pictureBox.Enabled = false; // item ikinci kez alınmayacak. 
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SatinAlma(500, 125, pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SatinAlma(750, 45, pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SatinAlma(1000, 60, pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SatinAlma(1200, 85, pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SatinAlma(1500, 100, pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SatinAlma(1800, 120, pictureBox7);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            SatinAlma(2000, 150, pictureBox9);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SatinAlma(2500, 200, pictureBox8);
        }
    }
}
