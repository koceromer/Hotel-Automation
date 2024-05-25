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
    public partial class MusteriGörüntüle : Form
    {
        public MusteriGörüntüle()
        {
            InitializeComponent();
        }
        private void tSifirla()
        {
            tTC.Text = tAdSoyad.Text = tTel.Text = tAdres.Text = tBeraberindekiler.Text = "";
            bMusteriEkle.Enabled = tTC.Enabled = true;
            bDuzenle.Enabled = bMusteriSil.Enabled = false;
            checkBox1.Checked = false;
            dGvMusteri.ClearSelection();
        }
        private void musteriler_FormClosing(object sender, FormClosingEventArgs e)
        {
            tSifirla();
            tAra.Text = "Tc kimlik numarası veya isme göre ara";
            e.Cancel = true;
            this.Hide();
            programAyarlari.fmain.Show();
        }

        private void bDuzenle_Click(object sender, EventArgs e)
        { // BDUZENLEDE HATA VAR ONU ÇÖZ İLİŞKİLİ KAYITLAR SORUNU
            if (tTC.Text == "" || tAdSoyad.Text == "" || tTel.Text == "" || tAdres.Text == "") programAyarlari.hataVer("Eksik bilgi girişi yapıldı.", "Müşteri bilgileri eksik. Lütfen boş alanları doldurunuz. ");
            else 
            {
                try
                {
                    islemler.varsaKosulluVeriGuncelle("MUSTERI", "M_TC ='" + tTC.Text + "',M_ADI_SOYADI = '" + tAdSoyad.Text + "',M_TEL ='" + tTel.Text + "',M_ADRES = '" + tAdres.Text + "',M_BERABERINDEKILER = '" + tBeraberindekiler.Text + "' where M_TC = '" + tTC.Text + "'", "");
                    DataGridViewRow dr = dGvMusteri.CurrentRow;
                    dr.Cells[0].Value = tTC.Text;
                    dr.Cells[1].Value = tAdSoyad.Text;
                    dr.Cells[2].Value = tTel.Text;
                    dr.Cells[3].Value = tAdres.Text;
                    dr.Cells[5].Value = tBeraberindekiler.Text;
                    MessageBox.Show("Müşteri başarıyla düzenlendi","Başarı");
                }
                catch (Exception) { programAyarlari.hataVer("Bir hata gerçekleşti.", "Müşteri şuan düzenlenemez.\nLütfen müşterinin oda işlemleri bittikten sonra düzenleyiniz."); }
                dGvMusteri.DataSource = degiskenler.ds.Tables["MUSTERI"];
                dGvMusteri.Refresh();
                tSifirla();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bDuzenle.Enabled = bMusteriSil.Enabled = true;
            bMusteriEkle.Enabled = false;
            try
            {
                tTC.Enabled = false;
                tTC.Text = dGvMusteri.SelectedRows[0].Cells[0].Value.ToString();
                tAdSoyad.Text = dGvMusteri.SelectedRows[0].Cells[1].Value.ToString();
                tTel.Text = dGvMusteri.SelectedRows[0].Cells[2].Value.ToString();
                tAdres.Text = dGvMusteri.SelectedRows[0].Cells[3].Value.ToString();
                tBeraberindekiler.Text = dGvMusteri.SelectedRows[0].Cells[5].Value.ToString(); // sÜTUNLARI TEXTBOXLARA AKTARDIK
            }
            catch (Exception) { }
            if (tTC.Text == "")
            {
                bDuzenle.Enabled = bMusteriSil.Enabled = false;
                bMusteriEkle.Enabled = tTC.Enabled = true;
            }
        }

        private void bMusteriEkle_Click(object sender, EventArgs e)
        {
            if (tTC.Text == "" || tAdSoyad.Text == "" || tTel.Text == "" || tAdres.Text == "") programAyarlari.hataVer("Eksik bilgi girişi yapıldı.", "Müşteri bilgileri eksik. Lütfen boş alanları doldurunuz. ");
            else
            {
                // Yeni kayıt veri tabanına ekleme kodu
                islemler.veriEkle("MUSTERI", "M_TC,M_ADI_SOYADI,M_TEL,M_ADRES,M_KAYIT_TARIHI,M_BERABERINDEKILER", "'" + tTC.Text + "','" + tAdSoyad.Text + "','" + tTel.Text + "','" + tAdres.Text + "','" + DateTime.Now.ToShortDateString() + "','" + tBeraberindekiler.Text + "'");
                DataRow dr = degiskenler.ds.Tables["MUSTERI"].NewRow();
                dr["M_TC"] = tTC.Text;
                dr["M_ADI_SOYADI"] = tAdSoyad.Text;
                dr["M_TEL"] = tTel.Text;
                dr["M_ADRES"] = tAdres.Text;
                dr["M_KAYIT_TARIHI"] = DateTime.Now.ToShortDateString();
                dr["M_BERABERINDEKILER"] = tBeraberindekiler.Text;
                degiskenler.ds.Tables["MUSTERI"].Rows.Add(dr);
                programAyarlari.musteriSayisi++;
                tSifirla();
            }
        }

        private void bMusteriSil_Click(object sender, EventArgs e)
        {
            try
            {
                bool MusterininOdasiVarMi = false; // müşterinin odası var mı diye sorgulaacağız.
                OleDbCommand musterininOdasıVarMi = new OleDbCommand("Select * from ODA_MUSTERI where OM_M_TC = @m_tc and CIKTI_MI = false", degiskenler.baglan);
                musterininOdasıVarMi.Parameters.Add("@m_tc", tTC.Text); // Eğer oda müşteri tablosunda bu tc li kişi varsa
                islemler.kosulluVeriGetir(musterininOdasıVarMi);
                if (degiskenler.oku.Read()) MusterininOdasiVarMi = true; // Musterinin odası var mı true oluyor.
                else MusterininOdasiVarMi = false; // yoksa false değeri dönecek
                degiskenler.baglan.Close(); // bağlantıyı kapattık.

                // Eğer müşteri varsa hatamızı veriyoruz. Henüz çıkış yapmamış bir müşteriyi silemezsiniz.Lütfen önce çıkış işlemlerini yapınız.
                if (MusterininOdasiVarMi == true) MessageBox.Show("Henüz çıkış yapmamış bir müşteriyi silemezsiniz.\nLütfen önce çıkış işlemlerini yapınız.", "Uyarı!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else // Eğer müşterinin odası yoksa false ise
                {
                    DialogResult diaRes = MessageBox.Show("Müşteri silinecek onaylıyor musunuz ?.", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // Müşteriyi silmek istiyor musunuz diye soruyoruz.
                    if (diaRes == DialogResult.Yes) // Eğer cevap evet ise
                    {
                        bool MusteriCiktiMi = false; // müşterinin odası var mı diye sorgulayacağız.
                        degiskenler.komut = new OleDbCommand("Select * from ODA_MUSTERI where OM_M_TC = @m_tc and CIKTI_MI = true", degiskenler.baglan);
                        degiskenler.komut.Parameters.Add("@m_tc", tTC.Text); // Eğer oda müşteri tablosunda bu tc li kişi varsa
                        islemler.kosulluVeriGetir(degiskenler.komut);
                        if (degiskenler.oku.Read()) MusteriCiktiMi = true; // Musterinin odası var mı true oluyor.
                        else MusteriCiktiMi = false; // yoksa false değeri dönecek
                        degiskenler.baglan.Close(); // bağlantıyı kapattık.

                        if (MusteriCiktiMi == true) // Eğer müşteri çıkış yaptıysa silinebilir.
                        {
                           degiskenler.komut = new OleDbCommand("DELETE * FROM ODA_MUSTERI WHERE OM_M_TC = @m_tc", degiskenler.baglan);
                            degiskenler.komut.Parameters.Add("@m_tc", tTC.Text);
                            islemler.kosulluVeriSil(degiskenler.komut);
                        }

                        // Daha sonra müşteriyi sildik.
                        degiskenler.komut = new OleDbCommand("DELETE * FROM MUSTERI WHERE M_TC = @m_tc", degiskenler.baglan);
                        degiskenler.komut.Parameters.Add("@m_tc", tTC.Text);
                        islemler.kosulluVeriSil(degiskenler.komut);
                        dGvMusteri.Rows.Remove(dGvMusteri.SelectedRows[0]);
                        programAyarlari.musteriSayisi--;
                      
                    }
                }
            }
            catch (Exception ex) { programAyarlari.hataVer("Beklenmedik bir hata", "Hata ayrıntılarını buradan  görebilirsiniz.\n\n" + ex); }
            dGvMusteri.DataSource = degiskenler.ds.Tables["MUSTERI"];
            tSifirla();
            dGvMusteri.ClearSelection();
            bDuzenle.Enabled = bMusteriSil.Enabled = false;
            bMusteriEkle.Enabled = true;
        }

        private void tAra_Click(object sender, EventArgs e) { tAra.Text = ""; }

        private void tAra_TextChanged(object sender, EventArgs e)
        {
            if (tAra.Text == "")
            {
                dGvMusteri.DataSource = degiskenler.ds.Tables["MUSTERI"];
                dGvMusteri.Refresh();
                tSifirla();
            } // Boşsa tüm veriler gelecek
            else // Doluysa arama yapılacak.
            {
                OleDbDataAdapter oDataA = new OleDbDataAdapter("Select * From MUSTERI where M_TC like '%" + tAra.Text + "%' or M_ADI_SOYADI like '%" + tAra.Text + "%'", degiskenler.baglan);
                programAyarlari.kosulluMusteriGetir("MUSTERI", dGvMusteri, oDataA);
                dGvMusteri.ClearSelection();
                
                tSifirla();
            }
        }

        private void musteriler_Load(object sender, EventArgs e)
        {
            programAyarlari.formBasligi(this, tSAciklama);// Form başlığını yazdırdık.
            dGvMusteri.DataSource = degiskenler.ds.Tables["MUSTERI"];
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { //Belli tarihler arası kayıtları ara
            if (checkBox1.Checked == true) // seçiliyse
            {
                tAra.Enabled = false;
                groupBox1.Visible = true;
            }
            else // eğer seçili değilse
            {
                tAra.Enabled = true;
                groupBox1.Visible = false;
                dGvMusteri.DataSource = degiskenler.ds.Tables["MUSTERI"];
                dGvMusteri.Refresh();
            }
        }

        private void dTp_ValueChanged(object sender, EventArgs e)
        {// tarihlerin değerleri değiştiğinde
            if (checkBox1.Checked == true)
            {
                try
                {
                    OleDbDataAdapter oDataA = new OleDbDataAdapter("Select * From MUSTERI where M_KAYIT_TARIHI >= @tarih1 and M_KAYIT_TARIHI <= @tarih2", degiskenler.baglan);
                    oDataA.SelectCommand.Parameters.Add("@tarih1", dTpBaslangic.Value.ToShortDateString());
                    oDataA.SelectCommand.Parameters.Add("@tarih2", dTpBitis.Value.ToShortDateString());
                    programAyarlari.kosulluMusteriGetir("MUSTERI", dGvMusteri, oDataA);
                    dGvMusteri.ClearSelection();
                }
                catch (Exception ex) { programAyarlari.hataVer("Beklenmedik bir hata\n", ex.ToString()); }
            }
        }

        private void dGvMusteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
