using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veriT;

namespace OtelOtomasyonV1
{
    public partial class AnaMenü : Form
    {
        public AnaMenü()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.ExitThread();
        }
        PictureBox p;
        void miniFormislemleri(string pName,Color renk,string olay, Form miniForm)
        {
            if (p.Name == pName)
            {
                if (olay == "pMouseMove") { p.BackColor = renk; miniForm.Location = new Point(MousePosition.X + 20, MousePosition.Y); }
                else if (olay == "pMouseLeave") { p.BackColor = renk; miniForm.Hide(); }
                else if (olay == "pHover" || olay == "pClick") miniForm.Show();
            }
        }
        private void pMouseMove(object sender, MouseEventArgs e)
        {
            p = sender as PictureBox;
            miniFormislemleri("pOda", Color.SeaGreen, "pMouseMove", programAyarlari.fminiOda);
            miniFormislemleri("pRezervasyon", Color.Orange, "pMouseMove", programAyarlari.fminiRezervasyon);
            miniFormislemleri("pMusteri", Color.MediumVioletRed, "pMouseMove", programAyarlari.fminiMusteri);
            miniFormislemleri("pKayitlar", Color.CadetBlue, "pMouseMove", programAyarlari.fminiKayitlar);
            miniFormislemleri("pTel", Color.Goldenrod, "pMouseMove", programAyarlari.fminiTel);
            miniFormislemleri("pProgramHk", Color.Firebrick, "pMouseMove", programAyarlari.fminiProgramHK);
        }
        private void pMouseLeave(object sender, EventArgs e)
        {
            miniFormislemleri("pOda", Color.DarkGreen, "pMouseLeave", programAyarlari.fminiOda);
            miniFormislemleri("pRezervasyon", Color.DarkOrange, "pMouseLeave", programAyarlari.fminiRezervasyon);
            miniFormislemleri("pMusteri", Color.DarkMagenta, "pMouseLeave", programAyarlari.fminiMusteri);
            miniFormislemleri("pKayitlar", Color.SteelBlue, "pMouseLeave", programAyarlari.fminiKayitlar);
            miniFormislemleri("pTel", Color.DarkGoldenrod, "pMouseLeave", programAyarlari.fminiTel);
            miniFormislemleri("pProgramHk", Color.DarkRed, "pMouseLeave", programAyarlari.fminiProgramHK);
        }

        private void pHover(object sender, EventArgs e)
        {
            miniFormislemleri("pOda", Color.SeaGreen, "pHover", programAyarlari.fminiOda);
            if (p.Name == "pOda") programAyarlari.miniOdaDegerGetir();
            miniFormislemleri("pRezervasyon", Color.DarkOrange, "pHover", programAyarlari.fminiRezervasyon);

            miniFormislemleri("pMusteri", Color.DarkMagenta, "pHover", programAyarlari.fminiMusteri);
            if (p.Name == "pMusteri")
                programAyarlari.fminiMusteri.lMusteriSayisi.Text = (programAyarlari.musteriSayisi).ToString();

            miniFormislemleri("pKayitlar", Color.SteelBlue, "pHover", programAyarlari.fminiKayitlar);
            miniFormislemleri("pTel", Color.DarkGoldenrod, "pHover", programAyarlari.fminiTel);
            miniFormislemleri("pProgramHk", Color.DarkRed, "pHover", programAyarlari.fminiProgramHK);
        }

        private void pClick(object sender, EventArgs e)
        {
            miniFormislemleri("pOda", Color.SeaGreen, "pClick", programAyarlari.fodalar);
            if (p.Name == "pOda") { programAyarlari.secilenOda = ""; programAyarlari.fodalar.lSecilenOda.Text = "Son seçilen oda : "; }

            miniFormislemleri("pRezervasyon", Color.DarkOrange, "pClick", programAyarlari.frezervasyonlar);
            if (p.Name == "pRezervasyon")
            {
                islemler.kosulsuzVeriGetir("Select O_NU from ODA");
                while (degiskenler.oku.Read())
                { programAyarlari.frezervasyonlar.cOda.Items.Add(degiskenler.oku["O_NU"].ToString()); }
                degiskenler.baglan.Close();
                programAyarlari.frezervasyonlar.cOda.SelectedIndex = 0;

                // REZERVASYON KODLARI BAŞLANGIÇ
                programAyarlari.tabloDoldur("REZERVASYON", programAyarlari.frezervasyonlar.dGvTumRezervasyon); 
                
                islemler.bagKontrol(); // Bağlantı kontrolü
                programAyarlari.ds3.Clear(); // dataset temizle
                degiskenler.adaptor = new OleDbDataAdapter("Select * from REZERVASYON where R_BASLANGIC_TARIHI=@rBaslangic", degiskenler.baglan);// Sorguda ki tablo verilerini koşul varsa getir yoksa koşul boşsa tüm veriler.
                degiskenler.adaptor.SelectCommand.Parameters.Add("@rBaslangic", DateTime.Now.ToShortDateString());
                degiskenler.adaptor.Fill(programAyarlari.ds3, "REZERVASYON"); // dataseti tabloadına göre doldur
                programAyarlari.frezervasyonlar.dGvRezervasyonuOlanKisiler.DataSource = programAyarlari.ds3.Tables["REZERVASYON"];
                degiskenler.baglan.Close();
                programAyarlari.frezervasyonlar.dGvRezervasyonuOlanKisiler.ClearSelection();
                programAyarlari.tabloDoldur("REZERVASYON where R_O_NU =" + programAyarlari.frezervasyonlar.cOda.Text, programAyarlari.frezervasyonlar.dGvSecilenOdaRezervasyonlari);
                
                dGvisimleri(programAyarlari.frezervasyonlar.dGvRezervasyonuOlanKisiler);
                dGvisimleri(programAyarlari.frezervasyonlar.dGvSecilenOdaRezervasyonlari);
                dGvisimleri(programAyarlari.frezervasyonlar.dGvTumRezervasyon);
                // REZERVASYON KODLARI BİTTİ
            }
            miniFormislemleri("pMusteri", Color.DarkMagenta, "pClick", programAyarlari.fmusteriler);
            if (p.Name == "pMusteri") programAyarlari.fmusteriler.dGvMusteri.DataSource = degiskenler.ds.Tables["MUSTERI"];
            miniFormislemleri("pKayitlar", Color.SteelBlue, "pClick", programAyarlari.fkayitlar);
            if (p.Name == "pKayitlar")
            {
                programAyarlari.tabloDoldur("GIRIS_RAPOR", programAyarlari.fkayitlar.dGvGirisK);
                programAyarlari.tabloDoldur("CIKIS_RAPOR", programAyarlari.fkayitlar.dGvCikisK);
                programAyarlari.fkayitlar.dGvGirisK.Columns[0].HeaderText = "Giriş tarihi";
                programAyarlari.fkayitlar.dGvGirisK.Columns[1].HeaderText = "TC Kimlik";
                programAyarlari.fkayitlar.dGvGirisK.Columns[2].HeaderText = "Oda Numarası";
                programAyarlari.fkayitlar.dGvGirisK.Columns[3].HeaderText = "Başlangıç tarihi";

                programAyarlari.fkayitlar.dGvCikisK.Columns[0].HeaderText = "Çıkış tarihi";
                programAyarlari.fkayitlar.dGvCikisK.Columns[1].HeaderText = "TC Kimlik";
                programAyarlari.fkayitlar.dGvCikisK.Columns[2].HeaderText = "Oda Numarası";
                programAyarlari.fkayitlar.dGvCikisK.Columns[3].HeaderText = "Toplam tutarı";
            }
            miniFormislemleri("pTel", Color.DarkGoldenrod, "pClick", programAyarlari.ftelefonlar);
            if (p.Name == "pTel") programAyarlari.musteriGetir("TELEFON_NU", programAyarlari.ftelefonlar.dGvTelefon, "");
            miniFormislemleri("pProgramHk", Color.DarkRed, "pClick", programAyarlari.fprogramHK);
            this.Hide();
        }
        void dGvisimleri(DataGridView d)
        {
            d.Columns[0].HeaderText = "Başlangıç tarihi";
            d.Columns[1].HeaderText = "Oda Numarası";
            d.Columns[2].HeaderText = "Müşteri TC'si";
            d.Columns[3].HeaderText = "Bitiş tarihi";
            d.ClearSelection();
        }

        private void tSCikis_Click(object sender, EventArgs e) // Profilin orda çıkışa tıklanırsa
        {
            this.Hide();
            programAyarlari.fgiris.Show();
        }

        private void tSProfil_Click(object sender, EventArgs e)
        {
            programAyarlari.fprofil.lTC.Text = programAyarlari.kTC;
            programAyarlari.fprofil.tAdiSoyadi.Text = programAyarlari.kAdiSoyadi;
            programAyarlari.fprofil.dTpDogumTarihi.Text = programAyarlari.kDogumTarihi;
            programAyarlari.fprofil.tTel.Text = programAyarlari.kTel;
            programAyarlari.fprofil.tAdres.Text = programAyarlari.kAdres;
            programAyarlari.fprofil.tKisiselBilgiler.Text = programAyarlari.kKisiselBilgiler;
            programAyarlari.fprofil.pResim.ImageLocation = programAyarlari.kResim;
            this.Hide();
            programAyarlari.fprofil.Show();
        }

        private void tSAyarlar_Click(object sender, EventArgs e)
        {
            // Değişkenlere ekle
            programAyarlari.fayarlar.tPAdi.Text = programAyarlari.pAdi;
            programAyarlari.fayarlar.tSurumu.Text = programAyarlari.pSurumu;
            programAyarlari.fayarlar.tYapimci.Text = programAyarlari.pYapimci;
            programAyarlari.fayarlar.tTel.Text = programAyarlari.pYapimciTel;
           
            this.Hide();
            programAyarlari.fayarlar.Show();
        }

        private void tSMusteriler_Click(object sender, EventArgs e)
        {
            programAyarlari.fmusteriler.dGvMusteri.DataSource = degiskenler.ds.Tables["MUSTERI"];
            programAyarlari.fmusteriler.Show();
            this.Hide();
        }
        private void tSKullanicilar_Click(object sender, EventArgs e)
        {
            programAyarlari.fkullanicilar.pResim.ImageLocation = @"resimler/default.png";
            programAyarlari.fkullanicilar.dGvKullanici.DataSource = degiskenler.ds.Tables["KULLANICILAR"];
            programAyarlari.fkullanicilar.Show();
            this.Hide();
        }

        private void tSYetki_Click(object sender, EventArgs e)
        {
            programAyarlari.fyetki.cBxYetki.Items.Clear();
            islemler.kosulsuzVeriGetir("Select Y_ADI from YETKI");
            while (degiskenler.oku.Read())
            { programAyarlari.fyetki.cBxYetki.Items.Add(degiskenler.oku["Y_ADI"].ToString()); }
            degiskenler.baglan.Close();
            programAyarlari.fyetki.cBxYetki.SelectedIndex = 0;
            programAyarlari.fyetki.Show();
            this.Hide();
        }

        private void menu_Hover(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = sender as ToolStripMenuItem;
            ts.ForeColor = Color.Black;
        }

        private void menu_Leave(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = sender as ToolStripMenuItem;
            ts.ForeColor = Color.WhiteSmoke;
            
        }

        private void tSProfil_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripDropDownItem ts = sender as ToolStripDropDownItem;
            tSHosgeldiniz.ForeColor = Color.Black;
        }

        private void tsDropİtem_Leave(object sender, EventArgs e)
        {
            tSHosgeldiniz.ForeColor = Color.WhiteSmoke;
        }

        private void f1YardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programAyarlari.fprogramHK.Show();
            this.Hide();
        }

        private void programHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programAyarlari.fsurumNotlari.Show();
            this.Hide();
        }

        private void tsOda_Click(object sender, EventArgs e)
        {
            programAyarlari.tabloDoldur("ODA", programAyarlari.fodaAyarlari.dGvOdaAyarlari);
            programAyarlari.fodaAyarlari.Show();
            this.Hide();
        }

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
