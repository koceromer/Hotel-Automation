using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using veriT;

namespace OtelOtomasyonV1
{
    public partial class AdminKayit : Form
    {
        public AdminKayit()
        {
            InitializeComponent();
        }

        private void tSifirla()
        {
            tTC.Text = tKadi.Text = tSifre.Text = tAdSoyad.Text = dTpDogumTarihi.Text = tTel.Text = tAdres.Text = tKisisel.Text = cYetki.Text = "";
            bKullaniciEkle.Enabled = tKadi.Enabled = true;
            cYetki.SelectedIndex = 1;
            bDuzenle.Enabled = bMusteriSil.Enabled = false;
            dGvKullanici.ClearSelection();
            pResim.ImageLocation = @"resimler/default.png";
        }

        private void tAra_TextChanged(object sender, EventArgs e)
        {
            if (tAra.Text == "")
            {
                dGvKullanici.DataSource = degiskenler.ds.Tables["KULLANICILAR"];
                tSifirla();
            } // Boşsa tüm veriler gelecek
            else // Doluysa arama yapılacak.
            {
                OleDbDataAdapter oDataA = new OleDbDataAdapter("Select * From KULLANICILAR where K_TC like '%" + tAra.Text + "%' or K_ADI_SOYADI like '%" + tAra.Text + "%' or K_KADI like '%" + tAra.Text + "%'", degiskenler.baglan);
                programAyarlari.kosulluMusteriGetir("KULLANICILAR", dGvKullanici, oDataA);
                dGvKullanici.ClearSelection();
                tSifirla();
            }
        }

        private void tAra_Click(object sender, EventArgs e)
        {
            tAra.Text = "";
        }

        private void bMusteriSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult diaRes = MessageBox.Show("Müşteri silinecek onaylıyor musunuz ?.", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // Müşteriyi silmek istiyor musunuz diye soruyoruz.
                if (diaRes == DialogResult.Yes) // Eğer cevap evet ise
                {
                    degiskenler.komut = new OleDbCommand("DELETE * FROM KULLANICILAR WHERE K_TC = @k_tc", degiskenler.baglan);
                    degiskenler.komut.Parameters.Add("@k_tc", tTC.Text);
                    islemler.kosulluVeriSil(degiskenler.komut);
                    dGvKullanici.Rows.Remove(dGvKullanici.SelectedRows[0]);
                }
            }
            catch (Exception ex) { programAyarlari.hataVer("Beklenmedik bir hata", "Hata ayrıntılarını buradan  görebilirsiniz.\n\n" + ex); }

            tSifirla();
            //dGvKullanici.DataSource = degiskenler.ds.Tables["KULLANICILAR"];
            bDuzenle.Enabled = bMusteriSil.Enabled = false;
            bKullaniciEkle.Enabled = tKadi.Enabled = true;
        }

        private void bKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tTC.Text) || String.IsNullOrWhiteSpace(tKadi.Text) || String.IsNullOrWhiteSpace(tSifre.Text) || String.IsNullOrWhiteSpace(tAdSoyad.Text) || String.IsNullOrWhiteSpace(dTpDogumTarihi.Text) || String.IsNullOrWhiteSpace(tTel.Text) || String.IsNullOrWhiteSpace(tAdres.Text) || String.IsNullOrWhiteSpace(pResim.ImageLocation.ToString()))
            {
                programAyarlari.hataVer("Eksik bilgi girişi yapıldı.", "Müşteri bilgileri eksik. Lütfen boş alanları doldurunuz. ");
            }
            else
            {
                // Yeni kayıt eklenecek
                islemler.veriEkle("KULLANICILAR", "K_TC,K_KADI,K_SIFRE,K_ADI_SOYADI,K_DOGUM_TARIHI,K_TEL,K_ADRES,K_KISISEL_BILGILER,K_Y_ADI,K_RESIM", "'" + tTC.Text + "','" + tKadi.Text + "','" + tSifre.Text + "','" + tAdSoyad.Text + "','" + dTpDogumTarihi.Text + "','" + tTel.Text + "','" + tAdres.Text + "','" + tKisisel.Text + "','" + cYetki.Text + "','" + pResim.ImageLocation.ToString() + "'");
                DataRow dataR = degiskenler.ds.Tables["KULLANICILAR"].NewRow();
                dataR["K_TC"] = tTC.Text;
                dataR["K_KADI"] = tKadi.Text;
                dataR["K_SIFRE"] = tSifre.Text;
                dataR["K_ADI_SOYADI"] = tAdSoyad.Text;
                dataR["K_DOGUM_TARIHI"] = dTpDogumTarihi.Text;
                dataR["K_TEL"] = tTel.Text;
                dataR["K_ADRES"] = tAdres.Text;
                dataR["K_KISISEL_BILGILER"] = tKisisel.Text;
                dataR["K_Y_ADI"] = cYetki.Text;
                dataR["K_RESIM"] = pResim.ImageLocation.ToString();
                degiskenler.ds.Tables["KULLANICILAR"].Rows.Add(dataR);
                MessageBox.Show("Müşteri başarıyla eklendi.", "Başarı");
                tSifirla();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bDuzenle.Enabled = bMusteriSil.Enabled = true;
            bKullaniciEkle.Enabled = tKadi.Enabled = false;
            try
            {
                tTC.Text = dGvKullanici.SelectedRows[0].Cells[0].Value.ToString();
                tKadi.Text = dGvKullanici.SelectedRows[0].Cells[1].Value.ToString();
                tSifre.Text = dGvKullanici.SelectedRows[0].Cells[2].Value.ToString();
                tAdSoyad.Text = dGvKullanici.SelectedRows[0].Cells[3].Value.ToString();
                dTpDogumTarihi.Text = dGvKullanici.SelectedRows[0].Cells[4].Value.ToString();
                tTel.Text = dGvKullanici.SelectedRows[0].Cells[5].Value.ToString();
                tAdres.Text = dGvKullanici.SelectedRows[0].Cells[6].Value.ToString();
                tKisisel.Text = dGvKullanici.SelectedRows[0].Cells[7].Value.ToString();
                cYetki.Text = dGvKullanici.SelectedRows[0].Cells[8].Value.ToString();
                if (dGvKullanici.SelectedRows[0].Cells[9].Value.ToString() == "") pResim.ImageLocation = @"resimler/default.png";
                else pResim.ImageLocation = dGvKullanici.SelectedRows[0].Cells[9].Value.ToString();
            }
            catch (Exception) { }
        }

        private void bDuzenle_Click(object sender, EventArgs e)
        {
            if (tTC.Text == "" || tAdSoyad.Text == "" || tTel.Text == "" || tAdres.Text == "") programAyarlari.hataVer("Eksik bilgi girişi yapıldı.", "Müşteri bilgileri eksik. Lütfen boş alanları doldurunuz. ");
            else
            {
                islemler.varsaKosulluVeriGuncelle("KULLANICILAR", "K_TC ='" + tTC.Text + "',K_KADI = '" + tKadi.Text + "',K_SIFRE = '" + tSifre.Text + "',K_ADI_SOYADI = '" + tAdSoyad.Text + "',K_DOGUM_TARIHI = '" + dTpDogumTarihi.Text + "',K_TEL ='" + tTel.Text + "',K_ADRES = '" + tAdres.Text + "',K_KISISEL_BILGILER = '" + tKisisel.Text + "',K_Y_ADI = '" + cYetki.Text + "',K_RESIM = '" + pResim.ImageLocation.ToString() + "' where K_KADI = '" + tKadi.Text + "'", "");
                DataGridViewRow dr = dGvKullanici.CurrentRow;
                dr.Cells[0].Value = tTC.Text;
                dr.Cells[1].Value = tKadi.Text;
                dr.Cells[2].Value = tSifre.Text;
                dr.Cells[3].Value = tAdSoyad.Text;
                dr.Cells[4].Value = dTpDogumTarihi.Text;
                dr.Cells[5].Value = tTel.Text;
                dr.Cells[6].Value = tAdres.Text;
                dr.Cells[7].Value = tKisisel.Text;
                dr.Cells[8].Value = cYetki.Text;
                dr.Cells[9].Value = pResim.ImageLocation.ToString();
                MessageBox.Show("Müşteri başarıyla düzenlendi.", "Başarı");
                tSifirla();
            }
        }

        private void kullanicilar_FormClosing(object sender, FormClosingEventArgs e)
        {
            tSifirla();
            tAra.Text = "Tc kimlik numarası,kullanıcı adı veya isme göre ara";
            e.Cancel = true;
            this.Hide();
            programAyarlari.fmain.Show();
        }

        private void kullanicilar_Load(object sender, EventArgs e)
        {
            programAyarlari.formBasligi(this, tSAciklama);// Form başlığını yazdırdık.
            islemler.kosulsuzVeriGetir("select Y_ADI from YETKI");
            while (degiskenler.oku.Read()) // Eğer okunuyorsa başarılıysa giriş yap
            {
                /* Giriş yapan kişinin profil bilgisi */
                cYetki.Items.Add(degiskenler.oku["Y_ADI"].ToString());
            }
            degiskenler.baglan.Close();
            cYetki.SelectedIndex = 1;

        }

        string resimYolu = ""; // Resim yolu değişkenimizi tanımladık.
        private void bResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim seçiniz!"; // Resim seç dediğimizde açılan resim seçme ekranı başlığı
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png"; // Resim seç dediğimizde açılan resim seçme ekranı hangi uzantıları seçeceğimizi belirttik.
            if (openFileDialog1.ShowDialog() == DialogResult.OK) // Eğer resim seçildiyse
            {
                resimYolu = openFileDialog1.FileName; // resim yoluna seçtiğimiz resmin yolunu attık.
                Bitmap bmp = new Bitmap(resimYolu); // resim yolunu bitmapa çevirdik
                //resmimizi picturebox1 de gösterdik
                pResim.Image = Image.FromFile(resimYolu);
            }
        }
    }
}
