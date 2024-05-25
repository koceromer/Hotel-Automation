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
    public partial class YeniMusteriKayit : Form
    {
        public YeniMusteriKayit()
        {
            InitializeComponent();
        }

        private void musteriEkle_Load(object sender, EventArgs e)
        {
            programAyarlari.formBasligi(this, tSAciklama);// Form başlığını yazdırdık.
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) groupBox1.Visible = false;
            else groupBox1.Visible = true;
        }

        private void bArkaPlan_Click(object sender, EventArgs e)
        {
            this.Hide();
            programAyarlari.fodalar.Show();
        }

        private void musteriEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            labelRezervasyon.Text = "Oda rezervasyonu bulunmamaktadır.";
            programAyarlari.fodalar.Show();
        }
        void odaSat()
        {
            foreach (Control item in programAyarlari.fodalar.panel2.Controls) // panel2 deki elemanları kontrol ediyoruz.
            {
                if (item is PictureBox) // eğer eleman picturebox ise
                {
                    PictureBox yeniP = item as PictureBox; // bu elemanı pictureboxa aktardık
                    if (item.Name.ToString() == "p" + programAyarlari.secilenOda)
                    {
                        yeniP.ImageLocation = @"resimler/doluOda.png"; // eğer elemanın namesi doluodanumarasına eşitse resmini değiştirdik.
                    }
                }
                else if (item is Button)  // eğer eleman Button ise
                    if (item.Name.ToString() == "b" + programAyarlari.secilenOda)
                    {
                        item.BackColor = Color.Red; // arkaplanını kırmızı yaptık.
                        item.Text = programAyarlari.secilenOda + " - Dolu";
                    }
            }
        }
        void siradakiMusteriRezervasyonTarihi()
        {
            // Bir sonraki rezervasyonu getiriyoruz.
            DateTime ilkRez = DateTime.Parse("28.12.2999 00:00");
            programAyarlari.rezervasyonBtarihi = "28.12.2999";
            degiskenler.komut = new System.Data.OleDb.OleDbCommand("select * from REZERVASYON where R_O_NU=@odaNu", degiskenler.baglan);
            degiskenler.komut.Parameters.Add("@odaNu", programAyarlari.secilenOda);
            islemler.kosulluVeriGetir(degiskenler.komut);
            while (degiskenler.oku.Read())
            {
                if (ilkRez > Convert.ToDateTime(degiskenler.oku["R_BASLANGIC_TARIHI"])) ilkRez = Convert.ToDateTime(degiskenler.oku["R_BASLANGIC_TARIHI"]);
                programAyarlari.rezervasyonBtarihi = ilkRez.ToShortDateString();
                programAyarlari.fmusteriEkle.labelRezervasyon.Text = "Bu odanın en yakın rezervasyon tarihi : " + programAyarlari.rezervasyonBtarihi;
            }
            if (programAyarlari.rezervasyonBtarihi == "28.12.2999")
                programAyarlari.fmusteriEkle.labelRezervasyon.Text = "Oda rezervasyonu bulunmamaktadır.";
            degiskenler.baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                if (tAdiSoyadi.Text == "" || tMusteriTC.Text == "" || tTel.Text == "") programAyarlari.hataVer("Dikkat", "Gerekli alanları boş bırakmayınız.");
                else
                {
                    bool rezervasyonVarMi = false;
                    degiskenler.komut = new System.Data.OleDb.OleDbCommand("Select * from REZERVASYON where R_BASLANGIC_TARIHI=@rBaslangic and R_O_NU=@odaNu and R_M_TC=@m_tc", degiskenler.baglan);
                    degiskenler.komut.Parameters.Add("@rBaslangic", DateTime.Now.ToShortDateString());
                    degiskenler.komut.Parameters.Add("@odaNu", programAyarlari.secilenOda);
                    degiskenler.komut.Parameters.Add("@m_tc", tMusteriTC.Text);
                    islemler.kosulluVeriGetir(degiskenler.komut);
                    if (degiskenler.oku.Read()) rezervasyonVarMi = true;
                    degiskenler.baglan.Close();
                    if (rezervasyonVarMi == true)
                    {
                        degiskenler.komut = new System.Data.OleDb.OleDbCommand("Delete * from REZERVASYON where R_BASLANGIC_TARIHI=@rBaslangic and R_O_NU=@odaNu and R_M_TC=@m_tc", degiskenler.baglan);
                        degiskenler.komut.Parameters.Add("@rBaslangic", DateTime.Now.ToShortDateString());
                        degiskenler.komut.Parameters.Add("@odaNu", programAyarlari.secilenOda);
                        degiskenler.komut.Parameters.Add("@m_tc", tMusteriTC.Text);
                        islemler.kosulluVeriSil(degiskenler.komut);
                    }
                    siradakiMusteriRezervasyonTarihi();
                    if (dTpCikisTarihi.Value > Convert.ToDateTime(programAyarlari.rezervasyonBtarihi))
                    {
                        programAyarlari.hataVer("Çıkış tarihi ile ilgili bir hata oldu", "Çıkış tarihi sırada ki randevulu müşterinin giriş tarihinden büyük.\nLütfen çıkış tarihinizi sırada ki müşterininkine göre ayarlayınız.");
                        dTpCikisTarihi.Value = DateTime.Now;
                    }
                    else
                    {
                        try
                        {
                            islemler.veriEkle("MUSTERI", "M_TC,M_ADI_SOYADI,M_TEL,M_ADRES,M_KAYIT_TARIHI,M_BERABERINDEKILER", "'" + tMusteriTC.Text + "','" + tAdiSoyadi.Text + "','" + tTel.Text + "','" + tAdres.Text + "','" + DateTime.Now.ToShortDateString() + "','" + tBeraberindekiler.Text + "'");
                            islemler.veriEkle("ODA_MUSTERI", "OM_O_NU,OM_M_TC,OM_GIRIS_TARIHI,OM_CIKIS_TARIHI", "'" + programAyarlari.secilenOda + "','" + tMusteriTC.Text + "','" + DateTime.Now.ToShortDateString() + "','" + dTpCikisTarihi.Value.ToShortDateString() + "'");
                            islemler.veriEkle("GIRIS_RAPOR", "GR_O_NU,GR_M_TC,GR_TARIH_SAAT", "'" + programAyarlari.secilenOda + "','" + tMusteriTC.Text + "','" + DateTime.Now + "'");
                            odaSat();
                            programAyarlari.bosOdaS -= 1; // label doluya yazdık
                            programAyarlari.doluOdaS += 1;
                            programAyarlari.fodalar.lBos.Text = "Boş oda : " + programAyarlari.bosOdaS.ToString(); // label doluya yazdık odalar Formundaki
                            programAyarlari.fodalar.lDolu.Text = "Dolu oda : " + programAyarlari.doluOdaS.ToString(); // label doluya yazdık
                            programAyarlari.fodalar.Show();
                            programAyarlari.rezervasyonBtarihi = DateTime.Now.ToShortDateString();
                            MessageBox.Show("Müşteri " + programAyarlari.secilenOda + " numaralı odaya başarıyla eklenmiştir.", "Başarı");
                        }
                        catch (Exception) { programAyarlari.hataVer("Dikkat", "Müşteri zaten kayıtlı.\n'Müşteri kayıtlı ise işaretleyiniz.' onay kutusu sizin için seçiliyor."); checkBox1.Checked = true; } 
                    }
                }
            }
            else
            {
                if (tMusteriTC.Text == "") programAyarlari.hataVer("Dikkat", "Gerekli alanları boş bırakmayınız.");
                else
                {
                    bool rezervasyonVarMi = false;
                    degiskenler.komut = new System.Data.OleDb.OleDbCommand("Select * from REZERVASYON where R_BASLANGIC_TARIHI=@rBaslangic and R_O_NU=@odaNu and R_M_TC=@m_tc", degiskenler.baglan);
                    degiskenler.komut.Parameters.Add("@rBaslangic", DateTime.Now.ToShortDateString());
                    degiskenler.komut.Parameters.Add("@odaNu", programAyarlari.secilenOda);
                    degiskenler.komut.Parameters.Add("@m_tc", tMusteriTC.Text);
                    islemler.kosulluVeriGetir(degiskenler.komut);
                    if (degiskenler.oku.Read()) rezervasyonVarMi = true;
                    degiskenler.baglan.Close();
                    if (rezervasyonVarMi == true)
                    {
                        degiskenler.komut = new System.Data.OleDb.OleDbCommand("Delete * from REZERVASYON where R_BASLANGIC_TARIHI=@rBaslangic and R_O_NU=@odaNu and R_M_TC=@m_tc", degiskenler.baglan);
                        degiskenler.komut.Parameters.Add("@rBaslangic", DateTime.Now.ToShortDateString());
                        degiskenler.komut.Parameters.Add("@odaNu", programAyarlari.secilenOda);
                        degiskenler.komut.Parameters.Add("@m_tc", tMusteriTC.Text);
                        islemler.kosulluVeriSil(degiskenler.komut);
                    }
                    siradakiMusteriRezervasyonTarihi();
                    if (dTpCikisTarihi.Value > Convert.ToDateTime(programAyarlari.rezervasyonBtarihi))
                    {
                        programAyarlari.hataVer("Çıkış tarihi ile ilgili bir hata oldu.", "Çıkış tarihi sırada ki randevulu müşterinin giriş tarihine eş değer.\nLütfen çıkış tarihinizi sırada ki müşterininkine göre ayarlayınız.");
                        dTpCikisTarihi.Value = DateTime.Now;
                    }
                    else
                    {
                        islemler.veriEkle("ODA_MUSTERI", "OM_O_NU,OM_M_TC,OM_GIRIS_TARIHI,OM_CIKIS_TARIHI", "'" + programAyarlari.secilenOda + "','" + tMusteriTC.Text + "','" + DateTime.Now.ToShortDateString() + "','" + dTpCikisTarihi.Value.ToShortDateString() + "'");
                        islemler.veriEkle("GIRIS_RAPOR", "GR_O_NU,GR_M_TC,GR_TARIH_SAAT", "'" + programAyarlari.secilenOda + "','" + tMusteriTC.Text + "','" + DateTime.Now + "'");
                        odaSat();
                        this.Hide();
                        programAyarlari.bosOdaS -= 1; // label doluya yazdık
                        programAyarlari.doluOdaS += 1;
                        programAyarlari.fodalar.lBos.Text = "Boş oda : " + programAyarlari.bosOdaS.ToString(); // label doluya yazdık odalar Formundaki
                        programAyarlari.fodalar.lDolu.Text = "Dolu oda : " + programAyarlari.doluOdaS.ToString(); // label doluya yazdık
                        programAyarlari.fodalar.Show();
                        programAyarlari.rezervasyonBtarihi = DateTime.Now.ToShortDateString();
                        MessageBox.Show("Müşteri " + programAyarlari.secilenOda + " numaralı odaya başarıyla eklenmiştir.", "Başarı");
                    }
                }
            }
        }

        private void dTpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (dTpCikisTarihi.Value < DateTime.Now)
            {
                dTpCikisTarihi.Value = DateTime.Now;
                MessageBox.Show("Geçmiş döneme ait giriş yapamazsınız.", "Hata");
            }
      
        }
    }
}
