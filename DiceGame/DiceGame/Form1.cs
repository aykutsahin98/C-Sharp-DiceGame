using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //GLOBAL DEĞİŞKENLERİ
        Random rastgele = new Random();
        int Oyuncu1Toplam, Oyuncu2Toplam = 0;
        int a, b;

        private void zarAt()
        {
            a = rastgele.Next(1, 7);
            b = rastgele.Next(1, 7);

            //Oyuncu 1 için Olan
            if(a == 1)
            { pictureBox1.ImageLocation = "image\\1.png"; }

            if (a == 2)
            { pictureBox1.ImageLocation = "image\\2.png"; }

            if (a == 3)
            { pictureBox1.ImageLocation = "image\\3.png"; }

            if (a == 4)
            { pictureBox1.ImageLocation = "image\\4.png"; }

            if (a == 5)
            { pictureBox1.ImageLocation = "image\\5.png"; }
                
            if (a == 6)
            { pictureBox1.ImageLocation = "image\\6.png"; }

            // Oyuncu 2 İçin İşlemler
            if (b == 1)
            { pictureBox2.ImageLocation = "image\\1.png"; }

            if (b == 2)
            { pictureBox2.ImageLocation = "image\\2.png"; }

            if (b == 3)
            { pictureBox2.ImageLocation = "image\\3.png"; }

            if (b == 4)
            { pictureBox2.ImageLocation = "image\\4.png"; }

            if (b == 5)
            { pictureBox2.ImageLocation = "image\\5.png"; }

            if (b == 6)
            { pictureBox2.ImageLocation = "image\\6.png"; }

        }
        private void oyuncuSkor()
        {
            if(Oyuncu1Toplam >= Convert.ToInt32(txtf_puan.Text))
            {
                label3.Visible = true;
                label3.Text = "Oyuncu 1 Kazandı...";
                button_tekrar.Visible = true;
                button_oyuncu2.Enabled = false;
            }
            if (Oyuncu2Toplam >= Convert.ToInt32(txtf_puan.Text))
            {
                label3.Visible = true;
                label3.Text = "Oyuncu 2 Kazandı...";
                button_tekrar.Visible = true;
                button_oyuncu1.Enabled = false; //button2 yazıyordu button oyuncu 1 olarak değiştirdik.
            }

        }

        private void button_oyuncu1_Click(object sender, EventArgs e)
        {
            txtf_puan.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button_oyuncu1.Enabled = false;
            button_oyuncu2.Enabled = true;
            zarAt();
            Oyuncu1Toplam = Oyuncu1Toplam + a + b;
            label_oyncu1.Text = Oyuncu1Toplam.ToString();
            oyuncuSkor();
        }

        private void button_oyuncu2_Click(object sender, EventArgs e)
        {
            txtf_puan.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button_oyuncu2.Enabled = false; // button oyuncu 1 idi biz onu 2 olarak değiştirdik.
            button_oyuncu1.Enabled = true;
            zarAt();
            Oyuncu2Toplam = Oyuncu2Toplam + a + b;
            label_oyncu2.Text = Oyuncu2Toplam.ToString();
            oyuncuSkor();
        }

        private void button_tekrar_Click(object sender, EventArgs e)
        {
            txtf_puan.Enabled = true;
            txtf_puan.Text = "100";
            button_oyuncu1.Enabled = true;
            button_oyuncu2.Enabled = true;
            label3.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            Oyuncu1Toplam = 0;
            Oyuncu2Toplam = 0;
            label_oyncu1.Text = "0";
            label_oyncu2.Text = "0";
            button_tekrar.Visible = false;
        }
    }
}
