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
    public partial class RezervasyonOlustur : Form
    {
        public RezervasyonOlustur()
        {
            InitializeComponent();
        }

        private void rezervasyonlar_Load(object sender, EventArgs e)
        {
            programAyarlari.formBasligi(this, tSAciklama);// Form başlığını yazdırdık.
        }

        private void rezervasyonlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            programAyarlari.fmain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            programAyarlari.fmusteriler.Show();
            this.Hide();
            programAyarlari.fmusteriler.tAra.Text = tTC.Text;
            if (programAyarlari.fmusteriler.tAra.Text == "")
            {
                programAyarlari.fmusteriler.dGvMusteri.DataSource = degiskenler.ds.Tables["MUSTERI"];
                programAyarlari.fmusteriler.dGvMusteri.Refresh();
            } // Boşsa tüm veriler gelecek
            else // Doluysa arama yapılacak.
            {
                OleDbDataAdapter oDataA = new OleDbDataAdapter("Select * From MUSTERI where M_TC like '%" + programAyarlari.fmusteriler.tAra.Text + "%' or M_ADI_SOYADI like '%" + programAyarlari.fmusteriler.tAra.Text + "%'", degiskenler.baglan);
                programAyarlari.kosulluMusteriGetir("MUSTERI", programAyarlari.fmusteriler.dGvMusteri, oDataA);
                programAyarlari.fmusteriler.dGvMusteri.ClearSelection();
               
            }
        }

        private void cOda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cOda.SelectedIndex > -1)
            {
                if (programAyarlari.fmusteriler.tAra.Text == "")
                {
                    dGvSecilenOdaRezervasyonlari.DataSource = degiskenler.ds.Tables["MUSTERI"];
                    dGvSecilenOdaRezervasyonlari.Refresh();
                } // Boşsa tüm veriler gelecek
                else // Doluysa arama yapılacak.
                {
                    OleDbDataAdapter oDataA = new OleDbDataAdapter("Select * From REZERVASYON where R_O_NU =" + cOda.Text, degiskenler.baglan);
                    programAyarlari.kosulluMusteriGetir("REZERVASYON", dGvSecilenOdaRezervasyonlari, oDataA);
                    dGvSecilenOdaRezervasyonlari.ClearSelection();
                }
            }
        }

        private void dGvSecilenOdaRezervasyonlari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bMusteriEkle.Enabled = false;
            bMusteriSil.Enabled = bDuzenle.Enabled = true;
            DataGridView d = sender as DataGridView;
            try
            {
                dTpBitis.Text = d.SelectedRows[0].Cells[3].Value.ToString();
                dTpBaslangic.Text = d.SelectedRows[0].Cells[0].Value.ToString();
                cOda.Text = d.SelectedRows[0].Cells[1].Value.ToString();
                tTC.Text = d.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception) { }
        }

        void rGetir()
        {
            tTC.Text = "";
            programAyarlari.tabloDoldur("REZERVASYON", dGvTumRezervasyon);

            islemler.bagKontrol(); // Bağlantı kontrolü
            programAyarlari.ds3.Clear(); // dataset temizle
            degiskenler.adaptor = new OleDbDataAdapter("Select * from REZERVASYON where R_BASLANGIC_TARIHI=@rBaslangic", degiskenler.baglan);// Sorguda ki tablo verilerini koşul varsa getir yoksa koşul boşsa tüm veriler.
            degiskenler.adaptor.SelectCommand.Parameters.Add("@rBaslangic", DateTime.Now.ToShortDateString());
            degiskenler.adaptor.Fill(programAyarlari.ds3, "REZERVASYON"); // dataseti tabloadına göre doldur
            dGvRezervasyonuOlanKisiler.DataSource = programAyarlari.ds3.Tables["REZERVASYON"];
            degiskenler.baglan.Close();
            dGvRezervasyonuOlanKisiler.ClearSelection();
            programAyarlari.tabloDoldur("REZERVASYON where R_O_NU =" + cOda.Text, dGvSecilenOdaRezervasyonlari);

        }

        private void bDuzenle_Click(object sender, EventArgs e)
        {
            bMusteriEkle.Enabled = true;
            bMusteriSil.Enabled = bDuzenle.Enabled = false;
        }

        private void bMusteriSil_Click(object sender, EventArgs e)
        {
            bMusteriEkle.Enabled = true;
            bMusteriSil.Enabled = bDuzenle.Enabled = false;
            try
            {
                degiskenler.komut = new OleDbCommand("DELETE * FROM REZERVASYON where R_BASLANGIC_TARIHI=@rBaslagic and R_O_NU=@rOdaNu and R_M_TC=@rMTC and R_BITIS_TARIHI=@rBitis",degiskenler.baglan);
                degiskenler.komut.Parameters.Add("@rBaslagic", dTpBaslangic.Value.ToShortDateString());
                degiskenler.komut.Parameters.Add("@rOdaNu", cOda.Text);
                degiskenler.komut.Parameters.Add("@rMTC", tTC.Text);
                degiskenler.komut.Parameters.Add("@rBitis", dTpBitis.Value.ToShortDateString());
                islemler.kosulluVeriSil(degiskenler.komut);
                rGetir();
                MessageBox.Show("Müşteri rezervasyonu başarıyla silinmiştir.","Başarılı");
            }
            catch (Exception) { programAyarlari.hataVer("Kayıt bulunamadı","Lütfen silmek istediğiniz müşteri rezervasyonuna tıklayın ve sil tuşuna tekrar basın."); }
        }

        private void bMusteriEkle_Click(object sender, EventArgs e)
        {
            
            try
            { // eğer bu odaya ait rezervasyonlar içerisinde dTpBaslangic tarihinden büyük bir başlangıç tarihi VE dTpBitis tarihinden küçük bir rezervasyon varsa rezervasyonu o tarihler arasına alınmayacak.
                
                islemler.veriEkle("REZERVASYON", "R_BASLANGIC_TARIHI,R_O_NU,R_M_TC,R_BITIS_TARIHI", "'" + dTpBaslangic.Value.ToShortDateString() + "','" + cOda.Text + "','" + tTC.Text + "','" + dTpBitis.Value.ToShortDateString() + "'");
                MessageBox.Show("Müşteri rezervasyonu başarıyla alınmıştır.", "Başarılı");
                rGetir();
            }
            catch (Exception) { programAyarlari.hataVer("Rezervasyon alınamadı. ", "Lütfen müşteri numarasını kontrol ediniz."); }
        }

        private void dTpBitis_ValueChanged(object sender, EventArgs e)
        {
            // if (dTpBitis.Value < dTpBaslangic.Value) { programAyarlari.hataVer("Hata", "Lütfen çıkış tarihini ileri bir tarih seçiniz."); dTpBitis.Value = DateTime.Now; }
           // if (dTpBitis.Value < DateTime.Now) { programAyarlari.hataVer("Hata", "Geçmiş döneme ait rezervasyon alamazsınız."); dTpBitis.Value = DateTime.Now; }
        }

        private void dTpBaslangic_ValueChanged(object sender, EventArgs e)
        {
           // if (dTpBaslangic.Value > dTpBitis.Value) { programAyarlari.hataVer("Hata", "Lütfen başlangıç tarihini geri bir tarih seçiniz."); dTpBaslangic.Value = DateTime.Now; }
           // if (dTpBaslangic.Value < DateTime.Now) { programAyarlari.hataVer("Hata", "Geçmiş döneme ait rezervasyon alamazsınız."); dTpBaslangic.Value = DateTime.Now; }
        }
    }
}
