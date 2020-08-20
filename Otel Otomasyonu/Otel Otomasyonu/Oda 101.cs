using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void button_101_kayitacma_Click(object sender, EventArgs e)
        {
            //Bütün odaların tek bir metin belgesinde toplanması (oda 101 için altta)
            StreamWriter musteri_kayit = new StreamWriter("Müsteri Kayıtları.txt", true);
            musteri_kayit.WriteLine();
            musteri_kayit.WriteLine();
            musteri_kayit.WriteLine("***********************************************");
            musteri_kayit.WriteLine("Kayıt alınma tarihi" + DateTime.Now);
            musteri_kayit.WriteLine(lbl_101_kaydeden.Text + ": " + textBox6.Text);
            musteri_kayit.WriteLine(label_101_giris.Text + ": " + textBox7.Text);
            musteri_kayit.WriteLine(label_101_cikis.Text + ": " + textBox8.Text);
            musteri_kayit.WriteLine(lbl_101_musteri.Text);
            musteri_kayit.WriteLine(lbl_101_kiralayanad.Text + ": " + textBox1.Text);
            musteri_kayit.WriteLine(lbl_101_kiralayansoyad.Text + ": " + textBox2.Text);
            musteri_kayit.WriteLine(lbl_101_kiralayankimlik.Text + ": " + textBox3.Text);
            musteri_kayit.WriteLine(lbl_101_kiralayaniletisim.Text + ": " + textBox4.Text);
            musteri_kayit.WriteLine(lbl_101_kiralayandoğum.Text + ": " + textBox5.Text);
            musteri_kayit.WriteLine(lbl_101_cinsiyet.Text + ": " + comboBox_101_cinsiyet.Text);
            musteri_kayit.WriteLine(lbl_101_kart.Text);
            musteri_kayit.WriteLine(lbl_101_kartİD.Text + label_kartİD.Text);
            musteri_kayit.WriteLine(label_101_kartbakiye.Text + ": " + textBox11.Text + "TL");
            musteri_kayit.WriteLine("*****");
            musteri_kayit.WriteLine("Önemli notlar");
            musteri_kayit.WriteLine(richTextBox1.Text);
            musteri_kayit.WriteLine("*****");
            //if (checkBox_101_araba.CheckedChanged)
            musteri_kayit.WriteLine("Araç plaka (varsa)");
            musteri_kayit.WriteLine(textBox9.Text);
            musteri_kayit.WriteLine("*************************************************");
            musteri_kayit.Close();
        }

        private void checkBox_101_araba_CheckedChanged(object sender, EventArgs e)
        {
            //araç plakasının okuma -> yazma/okuma izni
            textBox9.ReadOnly = false;
        }
    }
}
