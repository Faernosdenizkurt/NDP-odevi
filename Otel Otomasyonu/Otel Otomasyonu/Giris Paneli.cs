using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 YAZ DÖNEMİ
**
** PROJE NUMARASI.........: 01
** ÖĞRENCİ ADI............:Deniz KURT
** ÖĞRENCİ NUMARASI.......:b191200034
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/

namespace Otel_Otomasyonu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //müşteri girişi
        private void pictureBox_musteriikon_Click(object sender, EventArgs e)
        {
            textBox_secilengiris.Text = "Müşteri Girişi";
        }

        //yönetici girişi
        private void pictureBox_adminikon_Click(object sender, EventArgs e)
        {
            textBox_secilengiris.Text = "Yönetici Girişi";
        }

        //resepsiyon girişi
        private void pictureBox_Resepsiyonikon_Click(object sender, EventArgs e)
        {
            textBox_secilengiris.Text = "Resepsiyon Girişi";
        }

        //görevli ikon
        private void pictureBox_görevliikon_Click(object sender, EventArgs e)
        {
            textBox_secilengiris.Text = "Personel Girişi";
        }

        //giriş butonu karak yapısı
        private void button_gir_Click(object sender, EventArgs e)
        {

            if (textBox_secilengiris.Text == "Yönetici Girişi")
            {
                if ((textBox_kullaniciad.Text == "admin") && (textBox_sifre.Text == "123"))
                {
                    Yonetici_Paneli yp = new Yonetici_Paneli();
                    yp.Show();
                }
            }
            if (textBox_secilengiris.Text == "Resepsiyon Girişi")
            {
                if ((textBox_kullaniciad.Text == "vezne") && (textBox_sifre.Text == "123"))
                {
                    Form2 op = new Form2();
                    op.Show();
                }
            }
            if (textBox_secilengiris.Text == "Müşteri Girişi")
            {
                if ((textBox_kullaniciad.Text == "10100") && (textBox_sifre.Text == "123"))
                {
                    Müşteri_Panel_101 mp = new Müşteri_Panel_101();
                    mp.Show();
                }
            }
            if (textBox_secilengiris.Text == "Personel Girişi")
            {
                if ((textBox_kullaniciad.Text == "personel") && (textBox_sifre.Text == "123"))
                {
                    Vale_İletişim vp = new Vale_İletişim();
                    vp.Show();
                }
            }
        }

        //sosyal medya (temsili)
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/?hl=tr");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/?hl=tr");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/login?lang=tr");
        }
    }
}
