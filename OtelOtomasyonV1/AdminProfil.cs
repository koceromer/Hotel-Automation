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

namespace OtelOtomasyonV1
{
    public partial class AdminProfil : Form
    {
        public AdminProfil()
        {
            InitializeComponent();
        }

        private void profil_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            programAyarlari.fmain.Show();
        }

        private void profil_Load(object sender, EventArgs e)
        {
            programAyarlari.formBasligi(this, tSAciklama);// Form başlığını yazdırdık.
        }

        private void bDuzenle_Click(object sender, EventArgs e)
        {
            if (tEskiSifre.Text == "" && tYeniSifre.Text != "") tYeniSifre.Text = "";
            if (tEskiSifre.Text != "" && tYeniSifre.Text == "") tEskiSifre.Text = "";

            if (tEskiSifre.Text != "" && tYeniSifre.Text != "") // Eski şifre ile yeni şifre doluysa kontrol edilecek
                if (tEskiSifre.Text != programAyarlari.kSifre) programAyarlari.hataVer("Hata", "Eski şifrenizi yanlış girdiniz.\nLütfen kontrol edip tekrar deneyiniz.");
                else { islemler.varsaKosulluVeriGuncelle("KULLANICILAR", "K_KADI = '" + tKAdi.Text + "',K_SIFRE = '" + tYeniSifre.Text + "',K_ADI_SOYADI = '" + tAdiSoyadi.Text + "',K_DOGUM_TARIHI = '" + dTpDogumTarihi.Text + "',K_TEL = '" + tTel.Text + "',K_ADRES = '" + tAdres.Text + "',K_KISISEL_BILGILER = '" + tKisiselBilgiler.Text + "',K_RESIM = '" + pResim.ImageLocation.ToString() + "'", "K_TC = '" + lTC.Text + "'"); } // eski şifreyi doğru yazdıysa yeni şifre aktif olacak 
            else
            {  // Eğer telefon numarasının başına sıfır yazıldıysa hata versin.
                if (tTel.Text.Substring(0, 1) == "0") { programAyarlari.hataVer("Hata", "Lütfen telefon numarasını başında sıfır olmadan yazınız.\nÖrnek : 5123457890"); }
                else islemler.varsaKosulluVeriGuncelle("KULLANICILAR", "K_KADI = '" + tKAdi.Text + "',K_ADI_SOYADI = '" + tAdiSoyadi.Text + "',K_DOGUM_TARIHI = '" + dTpDogumTarihi.Text + "',K_TEL = '" + tTel.Text + "',K_ADRES = '" + tAdres.Text + "',K_KISISEL_BILGILER = '" + tKisiselBilgiler.Text + "',K_RESIM = '" + pResim.ImageLocation.ToString() + "'", "K_TC = '" + lTC.Text + "'");
            }
            programAyarlari.kTC = programAyarlari.fprofil.lTC.Text;
            programAyarlari.kAdiSoyadi = programAyarlari.fprofil.tAdiSoyadi.Text;
            programAyarlari.kDogumTarihi = programAyarlari.fprofil.dTpDogumTarihi.Text;
            programAyarlari.kTel = programAyarlari.fprofil.tTel.Text;
            programAyarlari.kAdres = programAyarlari.fprofil.tAdres.Text;
            programAyarlari.kKisiselBilgiler = programAyarlari.fprofil.tKisiselBilgiler.Text;
            programAyarlari.kResim = programAyarlari.fprofil.pResim.ImageLocation;
            tYeniSifre.Text = tEskiSifre.Text = "";
        }

        string resimPath = ""; // Resim yolu değişkenimizi tanımladık.

        private void bResimSec_Click(object sender, EventArgs e)
        {
           
            ofd.Title = "Resim Aç";
            ofd.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pResim.Image = Image.FromFile(ofd.FileName);
                resimPath = ofd.FileName.ToString();
            }
        }

        private void tTel_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Düzenlenecek telefon girilirken silme tuşu ve digit karakterler kullanılacak diğerleri kullanılmayacak.
            if (char.IsLetter(e.KeyChar)) e.Handled = true; // Bazı özel karakterler girilmesini engelledik.
            else if (e.KeyChar == ' ' || e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '?' || e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '^' || e.KeyChar == '=' || e.KeyChar == '|') e.Handled = true; // Ve bu karakterleride biz engelledik.
            else e.Handled = false;
        }

        private void tAdiSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = true;
            else e.Handled = false;
        }

        private void tKisiselBilgiler_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
