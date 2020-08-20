using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //ilgili odanın kayıt sekmesine giriş (temsili sadece oda 101)
        private void btn_durum_101_Click(object sender, EventArgs e)
        {
            Form3 oda_101_panel = new Form3();
            oda_101_panel.Show();
        }
    }
}
