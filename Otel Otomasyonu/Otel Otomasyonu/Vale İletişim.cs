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
    public partial class Vale_İletişim : Form
    {
        public Vale_İletişim()
        {
            InitializeComponent();
        }

        //aracının hazırlanmasını isteyen müşterinin talepleri
        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader plaka_oku = new StreamReader("Araçtalep.txt");
            string okuma = plaka_oku.ReadToEnd();
            plaka_oku.Close();
            richTextBox1.Text = okuma;
        }
    }
}
