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
    public partial class Müşteri_Panel_101 : Form
    {
        public Müşteri_Panel_101()
        {
            InitializeComponent();
        }

        //acil butonu
        private void button_musteripanel_acil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İstek iletildi");
            Form2 acil = new Form2();
            acil.Show();
            this.Hide();
            MessageBox.Show("Oda 101 acil çağrı");
        }

        //şikayet etme 
        private void button_musteripanel_sikayet_Click(object sender, EventArgs e)
        {
            DateTime sikayet_log = new DateTime();
            sikayet_log = DateTime.Today;
            StreamWriter sikayetyaz = new StreamWriter("Sikayetler.txt",true);
            sikayetyaz.WriteLine();
            sikayetyaz.WriteLine("********************************");
            sikayetyaz.WriteLine(sikayet_log);
            sikayetyaz.WriteLine(DateTime.Now);
            sikayetyaz.WriteLine(richTextBox_musteripanel_sikayet);
            sikayetyaz.WriteLine("*********************************");
            sikayetyaz.WriteLine();
            sikayetyaz.Close();
            MessageBox.Show("Şikayetiniz iletildi en kısa zamanda dönüş yapılacak");

        }
        
        //görevli çağırma 
        private void button_musteripanel_görevli_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En kısa zamanda ilgili görevli gelecektir");
            Form2 talep = new Form2();
            talep.Show();
            this.Hide();
            MessageBox.Show(richTextBox_gorevli.Text, "Oda 101 Personel talebi");
        }

        //sipariş verme 
        private void button_musteripanel_siparis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz hazırlanmaya başladı bile!!");
            Form2 order = new Form2();
            order.Show();
            this.Hide();
            MessageBox.Show(richTextBox_siparis.Text, "Oda 101 sipariş");
        }

        //aracımı hazırla
        private void button_musteripanel_arac_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            StreamWriter talep_arac = new StreamWriter("Araçtalep.txt", true);
            //talep_arac.WriteLine(frm3.textBox9);
            talep_arac.WriteLine(DateTime.Now);
            talep_arac.WriteLine("34 AT 7632");
            talep_arac.Close();
            MessageBox.Show("Araç talebiniz iletildi");
            Vale_İletişim vl = new Vale_İletişim();
            vl.Show();
            this.Hide();
            MessageBox.Show("Araç talebi var");


        }

        //kartım kayboldu
        private void button_musteripanel_kayıp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kart aktiviteniz durdurulacaktır iptal için vezneye gidiniz");
            Form2 bloke = new Form2();
            bloke.Show();
            this.Hide();
            MessageBox.Show("MÜŞTERİ KARTINI KAYBETTİ HEMEN KART AKTİVİTESİNİ DURDURUN", "Oda 101 Kullanıcısı");
        }

        //menü içeriği
        private void button_musteripanel_menu_Click(object sender, EventArgs e)
        {
            //Microsoft office programına erişim sağlayamadığım için text doyasını kullanıyorum
            StreamReader menu = new StreamReader("Menü.txt", true);
            Form1 menu_panel = new Form1();
            menu_panel.Show();
            menu_panel.richTextBox1.Text = menu.ReadToEnd();
        }
    }
}
