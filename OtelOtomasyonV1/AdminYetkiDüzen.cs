using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veriT;
using System.Data.OleDb;

namespace OtelOtomasyonV1
{
    public partial class AdminYetkiDüzen : Form
    {
        public AdminYetkiDüzen()
        {
            InitializeComponent();
        }

        private void yetki_FormClosing(object sender, FormClosingEventArgs e)
        {
            sifirla();
            e.Cancel = true;
            this.Hide();
            programAyarlari.fmain.Show();
        }

        private void yetki_Load(object sender, EventArgs e)
        {
            programAyarlari.formBasligi(this, tSAciklama);// Form başlığını yazdırdık.
            cBxYetki.SelectedIndex = 0;
        }
        string yetkiAdi;
        private void cBxYetki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBxYetki.SelectedIndex > -1)
            {
                yetkiAdi = cBxYetki.Text;
                islemler.kosulsuzVeriGetir("Select * from YETKI where Y_ADI='" + yetkiAdi + "'");
                while (degiskenler.oku.Read())
                {
                    cHduzenProgramDuzeni.Checked = Convert.ToBoolean(degiskenler.oku["PROGRAM_DUZENI"].ToString());
                    cHduzenKullanıcı.Checked = Convert.ToBoolean(degiskenler.oku["KULLANICI_ISLEMLERI"].ToString());
                    cHduzenOdaAyarlari.Checked = Convert.ToBoolean(degiskenler.oku["ODA_ISLEMLERI"].ToString());
                    cHduzenMusteriAyarlari.Checked = Convert.ToBoolean(degiskenler.oku["MUSTERI_ISLEMLERI"].ToString());
                    cHduzenGirisCikisKayitlari.Checked = Convert.ToBoolean(degiskenler.oku["GIRIS_CIKIS_KAYITLARI"].ToString());
                    cHduzenHasilatRaporlari.Checked = Convert.ToBoolean(degiskenler.oku["HASILAT_R_OKUMA"].ToString());
                    cHduzenYetkiEkleme.Checked = Convert.ToBoolean(degiskenler.oku["YETKI_AYARLARI"].ToString());
                }
                degiskenler.baglan.Close();
            }
        }
        public static void sifirla()
        {
            programAyarlari.fyetki.cHduzenProgramDuzeni.Checked = programAyarlari.fyetki.cHduzenKullanıcı.Checked = programAyarlari.fyetki.cHduzenOdaAyarlari.Checked = programAyarlari.fyetki.cHduzenMusteriAyarlari.Checked = programAyarlari.fyetki.cHduzenGirisCikisKayitlari.Checked = programAyarlari.fyetki.cHduzenHasilatRaporlari.Checked = programAyarlari.fyetki.cHduzenYetkiEkleme.Checked = programAyarlari.fyetki.cHekleYetkiEkleme.Checked = programAyarlari.fyetki.cHekleProgramDuzeni.Checked = programAyarlari.fyetki.cHekleOdaAyarlari.Checked = programAyarlari.fyetki.cHekleMusteri.Checked = programAyarlari.fyetki.cHekleKullaniciYetkileri.Checked = programAyarlari.fyetki.cHekleHasilatRaporlari.Checked = programAyarlari.fyetki.cHekleGirisCikis.Checked = false;
            programAyarlari.fyetki.textBox1.Text = "";
            programAyarlari.fyetki.cBxYetki.Items.Clear();
            islemler.kosulsuzVeriGetir("Select Y_ADI from YETKI");
            while (degiskenler.oku.Read())
            { programAyarlari.fyetki.cBxYetki.Items.Add(degiskenler.oku["Y_ADI"].ToString()); }
            degiskenler.baglan.Close();
            programAyarlari.fyetki.cBxYetki.SelectedIndex = 0;
        }
        private void cBxYetki_TextChanged(object sender, EventArgs e)
        {
            if (cBxYetki.Text == "") sifirla();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBxYetki.Text != "Founder" || cBxYetki.Text != "")
                {
                    programAyarlari.fkullanicilar.cYetki.Items.Remove(cBxYetki.Text);
                    degiskenler.komut = new OleDbCommand("Delete * from YETKI where Y_ADI=@y_adi", degiskenler.baglan);
                    degiskenler.komut.Parameters.Add("@kosul1", cBxYetki.Text);
                    islemler.kosulluVeriSil(degiskenler.komut);
                    MessageBox.Show("Yetki silindi!", "Başarı");
                    sifirla();
                }
                else  programAyarlari.hataVer("Bu yetkiyi silemezsiniz.", "Kurucu yetkisi silinemez.");
            }
            catch (Exception)
            {
                programAyarlari.hataVer("Bu yetki şuanda silinemiyor.", "Bu yetki şuan bir veya birden fazla kullanıcı da bulunuyor.\nLütfen önce bu kullanıcıların yetkilerini değiştiriniz.");
            }
        }

        private void bAyarlariUygula_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    islemler.veriEkle("YETKI", "Y_ADI,GIRIS_CIKIS_KAYITLARI,HASILAT_R_OKUMA,KULLANICI_ISLEMLERI,MUSTERI_ISLEMLERI,ODA_ISLEMLERI,PROGRAM_DUZENI,YETKI_AYARLARI", "'" + textBox1.Text + "'," + cHekleGirisCikis.Checked + "," + cHekleHasilatRaporlari.Checked + "," + cHekleKullaniciYetkileri.Checked + "," + cHekleMusteri.Checked + "," + cHekleOdaAyarlari.Checked + "," + cHekleProgramDuzeni.Checked + "," + cHekleYetkiEkleme.Checked + "");
                    MessageBox.Show("Başarıyla eklendi!", "Başarı");
                    programAyarlari.fkullanicilar.cYetki.Items.Add(textBox1.Text);
                    sifirla();
                }
                catch (Exception ex)
                {
                    programAyarlari.hataVer("Bu yetki şuanda eklenemiyor.", "Bu yetki şuan bir yetkiyle aynı ismi taşıyor." + ex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cBxYetki.SelectedIndex > -1)
            {
                try
                {
                    if (cBxYetki.Text != "Founder")
                    {
                        islemler.varsaKosulluVeriGuncelle("YETKI", "PROGRAM_DUZENI = " + cHduzenProgramDuzeni.Checked + ",YETKI_AYARLARI = " + cHduzenYetkiEkleme.Checked + ",GIRIS_CIKIS_KAYITLARI=" + cHduzenGirisCikisKayitlari.Checked + ",HASILAT_R_OKUMA=" + cHduzenHasilatRaporlari.Checked + ",KULLANICI_ISLEMLERI=" + cHduzenKullanıcı.Checked + ",MUSTERI_ISLEMLERI=" + cHduzenMusteriAyarlari.Checked + ",ODA_ISLEMLERI =" + cHduzenOdaAyarlari.Checked, "Y_ADI = '" + cBxYetki.Text + "'");
                        MessageBox.Show("Yetki düzenlendi!", "Başarı");
                        sifirla();
                    } else programAyarlari.hataVer("Bu yetki düzenlenemiyor.", "Kurucu yetkileri değiştirilemez.");
                }
                catch (Exception)
                {
                    programAyarlari.hataVer("Bu yetki şuanda düzenlenemiyor.", "Bu yetki şuan bir veya birden fazla kullanıcı da bulunuyor.\nLütfen önce bu kullanıcıların yetkilerini değiştiriniz.");
                }
            }
        }
    }
}
