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
    public partial class OdaKontrol : Form
    {
        public OdaKontrol()
        {
            InitializeComponent();
        }

        private void odalar_FormClosing(object sender, FormClosingEventArgs e)
        {
            bRezervasyon.Enabled = bTemizeGec.Enabled = bMusteriCikisi.Enabled = bMusteriEkle.Enabled = false;
            e.Cancel = true;
            this.Hide();
            programAyarlari.fmain.Show();
        }

        private void odalar_Load(object sender, EventArgs e)
        {
            programAyarlari.formBasligi(this, tSAciklama);// Form başlığını yazdırdık.
        }
        private void panel2_Resize(object sender, EventArgs e)
        {
            int konumX = 0;
            int konumY = 20;
            int bWBoyutu = (panel2.Width / 10) - 2;
            PictureBox p = new PictureBox();
            Button b = new Button();
            foreach (Control item in panel2.Controls)
            {
                if (konumX == 10)
                {
                    konumX = 0;
                    konumY += (bWBoyutu / 2) + (bWBoyutu / 4) + 30;
                }
                if (item is PictureBox)
                {
                    p = item as PictureBox;
                    p.Size = new Size(bWBoyutu, (bWBoyutu / 2) + (bWBoyutu / 4)); // boyutu yarısının çeyrek fazlası
                    item.Location = new Point((konumX * bWBoyutu) + 10, konumY);
                }
                else if (item is Button)
                {
                    b = item as Button;
                    b.Size = new Size(bWBoyutu, 30);
                    item.Location = new Point((konumX * bWBoyutu) + 10, p.Location.Y + (bWBoyutu / 2) + (bWBoyutu / 4));
                    konumX++;
                }
            }
        }
        private void bMusteriEkle_Click(object sender, EventArgs e)
        {
            programAyarlari.fmusteriEkle.dTpCikisTarihi.Value = DateTime.Now;
            DateTime ilkRez = DateTime.Parse("28.12.2999 00:00");
            programAyarlari.rezervasyonBtarihi = "28.12.2999";
            degiskenler.komut = new OleDbCommand("select * from REZERVASYON where R_O_NU=@odaNu", degiskenler.baglan);
            degiskenler.komut.Parameters.Add("@odaNu", programAyarlari.secilenOda);
            islemler.kosulluVeriGetir(degiskenler.komut);
            while (degiskenler.oku.Read())
            {
                if (ilkRez > Convert.ToDateTime(degiskenler.oku["R_BASLANGIC_TARIHI"])) ilkRez = Convert.ToDateTime(degiskenler.oku["R_BASLANGIC_TARIHI"]);
                programAyarlari.rezervasyonBtarihi = ilkRez.ToShortDateString();
                programAyarlari.fmusteriEkle.labelRezervasyon.Text = "Bu odanın en yakın rezervasyon tarihi : " + programAyarlari.rezervasyonBtarihi;
            }
            degiskenler.baglan.Close();
            if (programAyarlari.rezervasyonBtarihi == "28.12.2999")
                programAyarlari.fmusteriEkle.labelRezervasyon.Text = "Oda rezervasyonu bulunmamaktadır.";
            programAyarlari.fmusteriEkle.labelOdaNu.Text = "Oda numarası " + programAyarlari.secilenOda;
            programAyarlari.fmusteriEkle.Show();
            this.Hide();
        }

        private void bTemizeGec_Click(object sender, EventArgs e)
        {
            if (programAyarlari.secilen.Text == programAyarlari.secilenOda + " - Kirli")
            {
                try
                {
                    degiskenler.komut = new OleDbCommand("Delete * from ODA_MUSTERI where OM_O_NU=@odaNu", degiskenler.baglan);
                    degiskenler.komut.Parameters.Add("@odaNu", programAyarlari.secilenOda);
                    islemler.kosulluVeriSil(degiskenler.komut);
                    programAyarlari.bosOdaS += 1; // label doluya yazdık
                    programAyarlari.doluOdaS -= 1;
                    programAyarlari.fodalar.lBos.Text = "Boş oda : " + programAyarlari.bosOdaS.ToString(); // label doluya yazdık odalar Formundaki
                    programAyarlari.fodalar.lDolu.Text = "Dolu oda : " + programAyarlari.doluOdaS.ToString(); // label doluya yazdık
                    foreach (Control item in programAyarlari.fodalar.panel2.Controls) // panel2 deki elemanları kontrol ediyoruz.
                    {
                        if (item is PictureBox) // eğer eleman picturebox ise
                        {
                            PictureBox yeniP = item as PictureBox; // bu elemanı pictureboxa aktardık
                            if (item.Name.ToString() == "p" + programAyarlari.secilenOda)
                            {
                                yeniP.ImageLocation = @"Resimler/bosOda.png"; // eğer elemanın namesi doluodanumarasına eşitse resmini değiştirdik.
                            }
                        }
                        else if (item is Button)  // eğer eleman Button ise
                            if (item.Name.ToString() == "b" + programAyarlari.secilenOda)
                            {
                                item.BackColor = Color.Green; // arkaplanını kırmızı yaptık.
                                item.Text = programAyarlari.secilenOda;
                            }
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void bMusteriCikisi_Click(object sender, EventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("Dikkat çıkış yapılacak.\n" + programAyarlari.secilenOda + " numaralı oda " + ((programAyarlari.gun == 0) ? programAyarlari.gun + 1 : programAyarlari.gun) + " Gün kalınmış.\n" + (programAyarlari.odaFiyati * ((programAyarlari.gun == 0) ? programAyarlari.gun + 1 : programAyarlari.gun)).ToString() + " ₺ Oda ücreti bulunuyor.\nKayıtlara geçilmesini ve çıkış yapılmasını onaylıyor musunuz ?", "Uyarı: Bu işlem geri alınamaz. Lütfen dikkatli kullanınız.", MessageBoxButtons.YesNo);

            if (programAyarlari.secilen.Text == programAyarlari.secilenOda + " - Dolu" && diaRes == DialogResult.Yes)
            {
                try
                {
                    degiskenler.komut = new OleDbCommand("Delete * from ODA_MUSTERI where OM_O_NU=@odaNu", degiskenler.baglan);
                    degiskenler.komut.Parameters.Add("@odaNu", programAyarlari.secilenOda);
                    islemler.kosulluVeriSil(degiskenler.komut);

                    // ÇIKIŞ RAPORU
                    islemler.veriEkle("CIKIS_RAPOR", "CR_TARIH_SAAT,CR_M_TC,CR_O_NU,CR_TOPLAM_TUTAR", "'" + DateTime.Now + "','" + programAyarlari.secilenOda + "','" + programAyarlari.secilenOda + "','" + programAyarlari.sOdaTutari + "'");
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
                                item.Text = programAyarlari.secilenOda + " - Kirli";
                            }
                    }
                    bMusteriCikisi.Enabled = false;
                    bTemizeGec.Enabled = true;
                }
                catch (Exception ex) { programAyarlari.hataVer("Bir şeyler ters gitti.", "Beklenmedik bir hata gerçekleşti.\nHata ayrıntılarına aşağıdan ulaşabilirsiniz.\n" + ex.ToString()); } // Hata mesajı
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            islemler.kosulsuzVeriGetir("Select O_NU from ODA");
            while (degiskenler.oku.Read())
            { programAyarlari.frezervasyonlar.cOda.Items.Add(degiskenler.oku["O_NU"].ToString()); }
            degiskenler.baglan.Close();
            programAyarlari.frezervasyonlar.cOda.Text = programAyarlari.secilenOda;
            programAyarlari.frezervasyonlar.Show();
            this.Hide();

            programAyarlari.tabloDoldur("REZERVASYON", programAyarlari.frezervasyonlar.dGvTumRezervasyon);

            islemler.bagKontrol(); // Bağlantı kontrolü
            programAyarlari.ds3.Clear(); // dataset temizle
            degiskenler.adaptor = new OleDbDataAdapter("Select * from REZERVASYON where R_BASLANGIC_TARIHI=@rBaslangic", degiskenler.baglan);// Sorguda ki tablo verilerini koşul varsa getir yoksa koşul boşsa tüm veriler.
            degiskenler.adaptor.SelectCommand.Parameters.Add("@rBaslangic", DateTime.Now.ToShortDateString());
            degiskenler.adaptor.Fill(programAyarlari.ds3, "REZERVASYON"); // dataseti tabloadına göre doldur
            programAyarlari.frezervasyonlar.dGvRezervasyonuOlanKisiler.DataSource = programAyarlari.ds3.Tables["REZERVASYON"];
            degiskenler.baglan.Close();
            programAyarlari.tabloDoldur("REZERVASYON where R_O_NU =" + programAyarlari.secilenOda, programAyarlari.frezervasyonlar.dGvSecilenOdaRezervasyonlari);
            dGvisimleri(programAyarlari.frezervasyonlar.dGvRezervasyonuOlanKisiler);
            dGvisimleri(programAyarlari.frezervasyonlar.dGvSecilenOdaRezervasyonlari);
            dGvisimleri(programAyarlari.frezervasyonlar.dGvTumRezervasyon);
        }
        void dGvisimleri(DataGridView d)
        {
            d.Columns[0].HeaderText = "Başlangıç tarihi";
            d.Columns[1].HeaderText = "Oda Numarası";
            d.Columns[2].HeaderText = "Müşteri TC'si";
            d.Columns[3].HeaderText = "Bitiş tarihi";
            d.ClearSelection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
