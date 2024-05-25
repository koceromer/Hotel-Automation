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
    class programAyarlari
    {

        /* Formlar */

        public static AdminGiris fgiris = new AdminGiris();
        public static AnaMenü fmain = new AnaMenü();
        public static YapımcıBilgiYan fprogramHK = new YapımcıBilgiYan();
        public static AdminProfil fprofil = new AdminProfil();
        public static ProgramAyar fayarlar = new ProgramAyar();
        public static OdaKontrol fodalar = new OdaKontrol();
        public static OdaBilgiSimge fodaBilgisi = new OdaBilgiSimge();
        public static MusteriGörüntüle fmusteriler = new MusteriGörüntüle();
        public static AdminKayit fkullanicilar = new AdminKayit();
        public static YeniMusteriKayit fmusteriEkle = new YeniMusteriKayit();
        public static AdminYetkiDüzen fyetki = new AdminYetkiDüzen();
        public static TelNoResepsiyon ftelefonlar = new TelNoResepsiyon();
        public static RezervasyonOlustur frezervasyonlar = new RezervasyonOlustur();
        public static OdaDüzen fodaAyarlari = new OdaDüzen();
        public static GirisCikisKyt fkayitlar = new GirisCikisKyt();
        public static YapımcıBilgi fsurumNotlari = new YapımcıBilgi();

        /* Mini Formlar */
        public static OdaSimge fminiOda = new OdaSimge();
        public static RezervasyonSimge fminiRezervasyon = new RezervasyonSimge();
        public static MusteriSimge fminiMusteri = new MusteriSimge();
        public static KayitSimge fminiKayitlar = new KayitSimge();
        public static TelNoSimge fminiTel = new TelNoSimge();
        public static YardımSimge fminiProgramHK = new YardımSimge();

        /* Public Değişkenler */
        public static string pAdi, pSurumu, pYapimci, pYapimciTel, pWebSite, pYenilikler, pArkaPlan, secilenOda,sMusteriTC,sOdaTutari, rezervasyonBtarihi;
        public static int toplamOdaS = 0, doluOdaS = 0, bosOdaS = 0, musteriSayisi = 0, gun = 0, odaFiyati = 0;
        public static Button secilen;
        /* Kullanıcı bilgileri ve rütbe bilgileri */
        public static string kAdi, kSifre, kRutbe, kTC, kAdiSoyadi, kDogumTarihi, kTel, kAdres, kKisiselBilgiler, kResim;
        /* Kullanıcı bilgisi ve yetkileri */
        public static bool programDuzeni, kullaniciIslemleri, yetkiLer, odaIslemleri, musteriIslemleri, girisCikisIslemleri, hasilatRaporuIslemleri;

        public static void hataVer(string hataBasligi, string hataDetayi) { MessageBox.Show(hataDetayi, hataBasligi, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        public static void formBasligi(Form f, ToolStripStatusLabel t) // Formların rengibaşlıkları vs ayarlar
        {
            f.Text = pAdi + " " + "V1" + " " + pYapimci + " 2023 ";
            t.Text = "Bu program Ömer Ve Fatih tarafından hazırlanmıştır.";
        }
        public static void musteriGetir(string tabloadi, DataGridView d, string varSaKosul)
        {
            islemler.bagKontrol(); // Bağlantı kontrolü
            degiskenler.adaptor = new OleDbDataAdapter("Select * From " + tabloadi + ((varSaKosul == "") ? varSaKosul : " where " + varSaKosul), degiskenler.baglan);// Sorguda ki tablo verilerini koşul varsa getir yoksa koşul boşsa tüm veriler.
            degiskenler.adaptor.Fill(degiskenler.ds, tabloadi); // dataseti tabloadına göre doldur
            d.DataSource = degiskenler.ds.Tables[tabloadi];
            degiskenler.baglan.Close();
        }

        public static DataSet ds2 = new DataSet();
        public static DataSet ds3 = new DataSet();
        public static void kosulluMusteriGetir(string tabloadi, DataGridView d, OleDbDataAdapter oDa)
        {
            try
            {
                islemler.bagKontrol(); // Bağlantı kontrolü
                ds2.Clear(); // dataset temizle
                degiskenler.adaptor = oDa;// Sorguda ki tablo verilerini koşul varsa getir yoksa koşul boşsa tüm veriler.
                degiskenler.adaptor.Fill(ds2, tabloadi); // dataseti tabloadına göre doldur
                d.DataSource = ds2.Tables[tabloadi];
                degiskenler.baglan.Close();
            }
            catch (Exception ex) { hataVer("Bir şeyler ters gitti.", "Beklenmedik bir hata gerçekleşti.\nHata ayrıntılarına aşağıdan ulaşabilirsiniz.\n" + ex.ToString()); } // Hata mesajı
        }

        public static void miniOdaDegerGetir()
        {
            programAyarlari.bosOdaS = (programAyarlari.toplamOdaS - programAyarlari.doluOdaS);

            // Progressbar kodları
            try { programAyarlari.fminiOda.chart1.Series["seriler"].Points.Clear(); }
            catch (Exception) { }
            programAyarlari.fminiOda.progressBar1.Value = (100 * programAyarlari.doluOdaS) / programAyarlari.toplamOdaS;
            programAyarlari.fminiOda.lDoluluk.Text = "%" + ((100 * programAyarlari.doluOdaS) / programAyarlari.toplamOdaS).ToString(); // label doluya yazdık
            if (programAyarlari.fminiOda.progressBar1.Value < 25) programAyarlari.fminiOda.progressBar1.BackColor = Color.Green;
            else if (programAyarlari.fminiOda.progressBar1.Value > 25 && programAyarlari.fminiOda.progressBar1.Value < 50) programAyarlari.fminiOda.progressBar1.BackColor = Color.Yellow;
            else if (programAyarlari.fminiOda.progressBar1.Value > 50 && programAyarlari.fminiOda.progressBar1.Value < 75) programAyarlari.fminiOda.progressBar1.BackColor = Color.LightSalmon;
            else if (programAyarlari.fminiOda.progressBar1.Value > 75 && programAyarlari.fminiOda.progressBar1.Value < 100) programAyarlari.fminiOda.progressBar1.BackColor = Color.Red;

            // chart kontrolü
            programAyarlari.fminiOda.chart1.Series["seriler"].Points.Add(programAyarlari.bosOdaS).LegendText = programAyarlari.bosOdaS.ToString() + " Boş";
            programAyarlari.fminiOda.chart1.Series["seriler"].Points[0].Color = Color.Green;
            programAyarlari.fminiOda.chart1.Series["seriler"].Points.Add(programAyarlari.doluOdaS).LegendText = programAyarlari.doluOdaS + " Dolu";
            programAyarlari.fminiOda.chart1.Series["seriler"].Points[1].Color = Color.Red;

            // labellara yazma işlemi
            programAyarlari.fminiOda.lToplam.Text = programAyarlari.toplamOdaS.ToString();
            programAyarlari.fminiOda.lBos.Text = programAyarlari.bosOdaS.ToString(); // label doluya yazdık
            programAyarlari.fminiOda.lDolu.Text = programAyarlari.doluOdaS.ToString(); // label doluya yazdık
        }
        public static DataSet tabloDS;
        public static void tabloDoldur(string tabloAdi,DataGridView d)
        {
            tabloDS = new DataSet();
            islemler.bagKontrol(); // Bağlantı kontrolü
            tabloDS.Clear(); // dataset temizle
            degiskenler.adaptor = new OleDbDataAdapter("Select * from " + tabloAdi, degiskenler.baglan);
            degiskenler.adaptor.Fill(tabloDS, tabloAdi); // dataseti tabloadına göre doldur
            d.DataSource = tabloDS.Tables[tabloAdi];
            degiskenler.baglan.Close();
            d.ClearSelection();
        }
    }
}
