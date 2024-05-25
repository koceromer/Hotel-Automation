using System;
using System.Collections.Generic;
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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        void yetkiKontrol(bool yetkiDegiskeni, string veriAdi, ToolStripMenuItem t) // Main sayfasında bazı bölümleri yetki kontrol ile kontrol ettik.
        {
            if (Convert.ToBoolean(degiskenler.oku[veriAdi]) == true) t.Visible = true; // yetki değişkeni true ise toolstripmenüitemi gösterttik değilse gizledik.
            else t.Visible = false;
        }

        private void bGiris_Click(object sender, EventArgs e)
        {
            degiskenler.baglan.Close();// Giriş yapıldığında textboxlar boşsa uyarı verilsin değilse giriş için sorgu kontrolü yapılsın.
            if (tKullaniciAdi.Text == "" || tSifre.Text == "") MessageBox.Show("Lütfen kullanıcı adı veya şifre alanını boş bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                programAyarlari.kAdi = programAyarlari.fprofil.tKAdi.Text = tKullaniciAdi.Text.Replace(" ", "").ToLower(); // Kullanıcı adı ve şifre yi baglanti da ki değişkenlere atadık boşluk varsa sildik.
                programAyarlari.kSifre = tSifre.Text.Trim();
                degiskenler.komut = new OleDbCommand("SELECT * FROM KULLANICILAR INNER JOIN YETKI ON KULLANICILAR.K_Y_ADI = YETKI.Y_ADI where K_KADI=@kAdi and K_SIFRE=@kSifre", degiskenler.baglan);
                degiskenler.komut.Parameters.Add("@kAdi", programAyarlari.kAdi);
                degiskenler.komut.Parameters.Add("@kSifre", programAyarlari.kSifre);
                islemler.kosulluVeriGetir(degiskenler.komut);
                if (degiskenler.oku.Read())
                {
                  
                    tKullaniciAdi.Text = "Kullanıcı adı"; // textboxı sıfırlıyoruz.
                    tSifre.Text = "Şifre"; // textboxı sıfırlıyoruz.

                    /* Giriş yapan kullanıcıların yetkileri */
                    programAyarlari.kRutbe = degiskenler.oku["K_Y_ADI"].ToString(); // Rütbesi
                    programAyarlari.kTC = degiskenler.oku["K_TC"].ToString();
                    programAyarlari.kAdiSoyadi = degiskenler.oku["K_ADI_SOYADI"].ToString();
                    programAyarlari.kDogumTarihi = degiskenler.oku["K_DOGUM_TARIHI"].ToString();
                    programAyarlari.kTel = degiskenler.oku["K_TEL"].ToString();
                    programAyarlari.kAdres = degiskenler.oku["K_ADRES"].ToString();
                    programAyarlari.kKisiselBilgiler = degiskenler.oku["K_MAIL"].ToString();
                    if (degiskenler.oku["K_RESIM"].ToString() == "") programAyarlari.kResim = @"resimler/default.png";
                    else programAyarlari.kResim = degiskenler.oku["K_RESIM"].ToString();

                    yetkiKontrol(programAyarlari.programDuzeni, "PROGRAM_DUZENI", programAyarlari.fmain.tSAyarlar);
                    yetkiKontrol(programAyarlari.yetkiLer, "YETKI_AYARLARI", programAyarlari.fmain.tSYetki);
                    yetkiKontrol(programAyarlari.kullaniciIslemleri, "KULLANICI_ISLEMLERI", programAyarlari.fmain.tSKullanicilar);
                    yetkiKontrol(programAyarlari.odaIslemleri, "ODA_ISLEMLERI", programAyarlari.fmain.tsOda);
                    yetkiKontrol(programAyarlari.musteriIslemleri, "MUSTERI_ISLEMLERI", programAyarlari.fmain.tSMusteriler);
                   
                    

                    // main formuna kullanıcının rütbesini ve kullanıcı adını yazdırdık ve formu gösterip bu formu kapattık.
                    programAyarlari.fmain.tSHosgeldiniz.Text = programAyarlari.kAdi;
                    programAyarlari.fmain.Show();
                    this.Hide();
                }
                //Eğer başarılı değilse hata ver bilgilendirme yap.
                else programAyarlari.hataVer("Giriş yapılamadı. Bilgileri kontrol edip tekrar deneyiniz.", "Lütfen kullanıcı adı veya şifrenizi kontrol edin.\nEğer doğru olduğuna eminseniz daha sonra tekrar deneyiniz.\nŞifrenizi unuttuysanız şifre mi unuttumu deneyebilirsiniz.");
                degiskenler.baglan.Close();
            }
        }

        private void giris_Load(object sender, EventArgs e)
        {
            degiskenler.baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath.ToString() + "\\OtelOtomasyonV1veriTabani.mdb");
            islemler.kosulsuzVeriGetir("Select * from PROGRAM");
            while (degiskenler.oku.Read()) // Eğer okunuyorsa başarılıysa programAyarlarını belirle
            {
                programAyarlari.pAdi = degiskenler.oku["P_ADI"].ToString();
                programAyarlari.pYapimci = degiskenler.oku["P_YAYIMCISI"].ToString();
                programAyarlari.pYapimciTel = degiskenler.oku["P_YAYIMCISI_TEL"].ToString();
                programAyarlari.pYenilikler = degiskenler.oku["P_YENILIKLER"].ToString();
            }
            degiskenler.baglan.Close(); // Bağlantıyı kapattık
          
            odalar();
            degiskenler.ds.Clear();
            programAyarlari.musteriGetir("KULLANICILAR", programAyarlari.fkullanicilar.dGvKullanici, ""); // Datagridviewlere müşterileri çektik.
            programAyarlari.musteriGetir("MUSTERI", programAyarlari.fmusteriler.dGvMusteri, ""); // Datagridviewlere müşterileri çektik.

            programAyarlari.musteriSayisi = programAyarlari.fmusteriler.dGvMusteri.Rows.Count;
            dGvSutunlariAdlandirma(programAyarlari.fmusteriler.dGvMusteri);
            dGvSutunlariAdlandirma(programAyarlari.fkullanicilar.dGvKullanici);

            programAyarlari.tabloDoldur("ODA", programAyarlari.fodaAyarlari.dGvOdaAyarlari);
            dGvSutunlariAdlandirma(programAyarlari.fodaAyarlari.dGvOdaAyarlari);
        }

        Button b;
        PictureBox pic;
        public void odalar()
        {
            programAyarlari.toplamOdaS = programAyarlari.doluOdaS = 0; // işlem bitiminde bunları sıfırladık.
            try
            {
                int konumX = 0;
                int konumY = 20;
                int bWBoyutu = (programAyarlari.fodalar.panel2.Width / 10) - 2;
                islemler.kosulsuzVeriGetir("SELECT * from ODA");
                while (degiskenler.oku.Read())
                {
                    b = new Button();
                    pic = new PictureBox();
                    b.Size = new Size(bWBoyutu, 30);
                    pic.Size = new Size(bWBoyutu, (bWBoyutu / 2) + (bWBoyutu / 4)); // boyutu yarısının çeyrek fazlası
                    b.FlatStyle = FlatStyle.Popup;
                    b.ForeColor = Color.White;
                    if (konumX == 10)
                    {
                        konumX = 0;
                        konumY += (bWBoyutu / 2) + (bWBoyutu / 4) + 30;
                    }
                    b.Name = "b" + degiskenler.oku["O_NU"].ToString();
                    pic.Name = "p" + degiskenler.oku["O_NU"].ToString();
                    b.Text = degiskenler.oku["O_NU"].ToString();
                    pic.ImageLocation = @"resimler/bosOda.png";
                    pic.BackColor = Color.Transparent;
                    b.Cursor = Cursors.Hand;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Location = new Point((konumX * bWBoyutu) + 10, konumY);
                    b.Location = new Point((konumX * bWBoyutu) + 10, pic.Location.Y + (bWBoyutu / 2) + (bWBoyutu / 4));
                    konumX++;
                    pic.MouseHover += pic_MouseHover;
                    pic.MouseLeave += pic_MouseLeave;
                    pic.MouseMove += pic_MouseMove;
                    b.Click += but_Click;
                    programAyarlari.fodalar.panel2.Controls.Add(pic);
                    programAyarlari.fodalar.panel2.Controls.Add(b);
                    programAyarlari.toplamOdaS++;
                }
                degiskenler.baglan.Close();
                foreach (Control item in programAyarlari.fodalar.panel2.Controls) { if (item is Button) item.BackColor = Color.Green; } // Önce bütün butonları yeşil yaptık.
                islemler.kosulsuzVeriGetir("SELECT * from ODA_MUSTERI");
                while (degiskenler.oku.Read())
                {
                    foreach (Control item in programAyarlari.fodalar.panel2.Controls) // panel2 deki elemanları kontrol ediyoruz.
                    {
                        if (item is PictureBox) // eğer eleman picturebox ise
                        {
                            PictureBox yeniP = item as PictureBox; // bu elemanı pictureboxa aktardık
                            if (item.Name.ToString() == "p" + degiskenler.oku["OM_O_NU"].ToString())
                            { yeniP.ImageLocation = @"resimler/doluOda.png"; } // eğer elemanın namesi doluodanumarasına eşitse resmini değiştirdik.
                        }
                        else if (item is Button)  // eğer eleman Button ise
                            if (item.Name.ToString() == "b" + degiskenler.oku["OM_O_NU"].ToString())
                            {
                                item.BackColor = Color.Red; // arkaplanını kırmızı yaptık.
                                item.Text = degiskenler.oku["OM_O_NU"].ToString() + " - Dolu";
                                if (Convert.ToBoolean(degiskenler.oku["CIKTI_MI"]) == true) item.Text = degiskenler.oku["OM_O_NU"].ToString() + " - Kirli";
                            }
                    }
                    programAyarlari.doluOdaS++;  // doluyu bir arttırdık teker teker baktığımız için
                }// Arraylistesine dolu odaları ekledik.
                degiskenler.baglan.Close();
                programAyarlari.bosOdaS = (programAyarlari.toplamOdaS - programAyarlari.doluOdaS); // Boş oda sayısına değer atadık
                programAyarlari.fodalar.lBos.Text = "Boş oda : " + programAyarlari.bosOdaS.ToString(); // label doluya yazdık odalar Formundaki
                programAyarlari.fodalar.lDolu.Text = "Dolu oda : " + programAyarlari.doluOdaS.ToString(); // label doluya yazdık
                programAyarlari.miniOdaDegerGetir();
            }
            catch (Exception ex) { programAyarlari.hataVer("Beklenmedik bir hata", "Hata ayrıntılarını buradan  görebilirsiniz.\n\n" + ex); }
        }
        void but_Click(object sender, EventArgs e)
        {
            programAyarlari.secilen = sender as Button;
            programAyarlari.secilenOda = programAyarlari.secilen.Name.Substring(1, 3);
            programAyarlari.fodalar.lSecilenOda.Text = "Son seçilen oda : " + programAyarlari.secilenOda;
            programAyarlari.fodalar.bRezervasyon.Enabled = true;
            if (programAyarlari.secilen.Text == programAyarlari.secilenOda + " - Kirli")
            {
                programAyarlari.fodalar.bTemizeGec.Enabled = true;
                programAyarlari.fodalar.bMusteriCikisi.Enabled = programAyarlari.fodalar.bMusteriEkle.Enabled = false;
            }
            else if (programAyarlari.secilen.Text == programAyarlari.secilenOda + " - Dolu")
            {
                programAyarlari.fodalar.bTemizeGec.Enabled = programAyarlari.fodalar.bMusteriEkle.Enabled = false;
                programAyarlari.fodalar.bMusteriCikisi.Enabled = true;
            }
            else
            {
                programAyarlari.fodalar.bMusteriEkle.Enabled = true;
                programAyarlari.fodalar.bMusteriCikisi.Enabled = programAyarlari.fodalar.bTemizeGec.Enabled = false;
            }
            degiskenler.komut = new OleDbCommand("SELECT * FROM MUSTERI INNER JOIN (ODA INNER JOIN ODA_MUSTERI ON ODA.O_NU = ODA_MUSTERI.OM_O_NU) ON MUSTERI.M_TC = ODA_MUSTERI.OM_M_TC where ODA_MUSTERI.OM_O_NU = @odaNu", degiskenler.baglan);
            degiskenler.komut.Parameters.Add("@odaNu", programAyarlari.secilenOda);
            islemler.kosulluVeriGetir(degiskenler.komut);
            while (degiskenler.oku.Read())
            {
                programAyarlari.sMusteriTC = degiskenler.oku["OM_M_TC"].ToString();
                if (Convert.ToBoolean(degiskenler.oku["CIKTI_MI"]) == true)
                    programAyarlari.fodaBilgisi.lToplamOdenecek.Text = programAyarlari.fodaBilgisi.ltoplamGun.Text = programAyarlari.fodaBilgisi.lCikisTarihi.Text = programAyarlari.fodaBilgisi.lGirisTarihi.Text = programAyarlari.fodaBilgisi.lAdiSoyadi.Text = programAyarlari.fodaBilgisi.lKisiTC.Text = "Oda şuan kirli";
                else
                {
                    TimeSpan fark = DateTime.Now.Subtract(Convert.ToDateTime(degiskenler.oku["OM_GIRIS_TARIHI"]));
                    programAyarlari.gun = Convert.ToInt32(fark.TotalDays) - 1;
                    if (programAyarlari.gun == 0) programAyarlari.gun = 1; // çıkış tarihinden bir gün geçtiyse
                    if (programAyarlari.gun < 0) programAyarlari.gun = 0; // çıkış tarihi şimdi ki güne eşitse
                    programAyarlari.sOdaTutari = (Convert.ToInt32(degiskenler.oku["O_FIYATI"]) * ((programAyarlari.gun == 0) ? programAyarlari.gun + 1 : programAyarlari.gun)).ToString();
                    programAyarlari.odaFiyati = Convert.ToInt32(degiskenler.oku["O_FIYATI"]);
                }
            }
            degiskenler.baglan.Close();
        }
        PictureBox picHover;
        void pic_MouseHover(object sender, EventArgs e)
        {
            try
            {
                picHover = sender as PictureBox;
                programAyarlari.fodaBilgisi.checkBoxSuit.Checked = programAyarlari.fodaBilgisi.checkBoxKlima.Checked = programAyarlari.fodaBilgisi.checkBoxTelevizyon.Checked = programAyarlari.fodaBilgisi.checkBoxKapalı.Checked = false;
                programAyarlari.fodaBilgisi.lToplamOdenecek.Text = programAyarlari.fodaBilgisi.ltoplamGun.Text = programAyarlari.fodaBilgisi.lCikisTarihi.Text = programAyarlari.fodaBilgisi.lGirisTarihi.Text = programAyarlari.fodaBilgisi.lAdiSoyadi.Text = programAyarlari.fodaBilgisi.lKisiTC.Text = "";
                programAyarlari.fodaBilgisi.LodaNumarasi.Text = "Oda numarası " + picHover.Name.Substring(1, 3);
                degiskenler.komut = new OleDbCommand("SELECT * FROM MUSTERI INNER JOIN (ODA INNER JOIN ODA_MUSTERI ON ODA.O_NU = ODA_MUSTERI.OM_O_NU) ON MUSTERI.M_TC = ODA_MUSTERI.OM_M_TC where ODA_MUSTERI.OM_O_NU = @odaNu", degiskenler.baglan);
                degiskenler.komut.Parameters.Add("@odaNu", picHover.Name.Substring(1, 3).ToString());
                islemler.kosulluVeriGetir(degiskenler.komut);
                while (degiskenler.oku.Read())
                {
                    if (Convert.ToBoolean(degiskenler.oku["CIKTI_MI"]) == true)
                        programAyarlari.fodaBilgisi.lToplamOdenecek.Text = programAyarlari.fodaBilgisi.ltoplamGun.Text = programAyarlari.fodaBilgisi.lCikisTarihi.Text = programAyarlari.fodaBilgisi.lGirisTarihi.Text = programAyarlari.fodaBilgisi.lAdiSoyadi.Text = programAyarlari.fodaBilgisi.lKisiTC.Text = "Oda şuan kirli";
                    else
                    {
                        programAyarlari.fodaBilgisi.LodaNumarasi.Text = "Oda numarası " + degiskenler.oku["OM_O_NU"].ToString();
                        programAyarlari.fodaBilgisi.lKisiTC.Text = degiskenler.oku["M_TC"].ToString();
                        programAyarlari.fodaBilgisi.lAdiSoyadi.Text = degiskenler.oku["M_ADI_SOYADI"].ToString();
                        programAyarlari.fodaBilgisi.lGirisTarihi.Text = Convert.ToDateTime(degiskenler.oku["OM_GIRIS_TARIHI"]).ToShortDateString();
                        programAyarlari.fodaBilgisi.lCikisTarihi.Text = Convert.ToDateTime(degiskenler.oku["OM_CIKIS_TARIHI"]).ToShortDateString();
                        TimeSpan fark = DateTime.Now.Subtract(Convert.ToDateTime(degiskenler.oku["OM_GIRIS_TARIHI"]));
                        int gun = Convert.ToInt32(fark.TotalDays);
                        programAyarlari.fodaBilgisi.ltoplamGun.Text = gun.ToString();
                        if (gun == 0) gun = 1; // çıkış tarihinden bir gün geçtiyse
                        if (gun < 0) gun = 0; // çıkış tarihi şimdi ki güne eşitse
                        if (Convert.ToDateTime(degiskenler.oku["OM_CIKIS_TARIHI"]) < DateTime.Now) programAyarlari.fodaBilgisi.ltoplamGun.Text = ((gun == 0) ? gun + 1 : gun).ToString() + " Gün oldu çıkış yapılmadı.";
                        else programAyarlari.fodaBilgisi.ltoplamGun.Text = "Henüz " + ((gun == 0) ? gun + 1 : gun) + " gün oldu.";
                        programAyarlari.fodaBilgisi.lToplamOdenecek.Text = (Convert.ToInt32(degiskenler.oku["O_FIYATI"]) * ((gun == 0) ? gun + 1 : gun)).ToString() + " ₺ Oda ücreti";
                    }
                }
                degiskenler.baglan.Close();
            }
            catch (Exception ex) { programAyarlari.hataVer("Beklenmedik bir hata", "Hata ayrıntılarını buradan  görebilirsiniz.\n\n" + ex); }
            try // ODA BİLGİLERİ GETİRTTİK
            {
                degiskenler.komut = new OleDbCommand("SELECT * FROM ODA where O_NU = @odaNu", degiskenler.baglan);
                degiskenler.komut.Parameters.Add("@odaNu", picHover.Name.Substring(1, 3).ToString());
                islemler.kosulluVeriGetir(degiskenler.komut);
                while (degiskenler.oku.Read())
                {
                    programAyarlari.fodaBilgisi.checkBoxSuit.Checked = (Convert.ToBoolean(degiskenler.oku["O_SUIT"]));
                    programAyarlari.fodaBilgisi.checkBoxKlima.Checked = (Convert.ToBoolean(degiskenler.oku["O_KLIMA"]));
                    programAyarlari.fodaBilgisi.checkBoxTelevizyon.Checked = (Convert.ToBoolean(degiskenler.oku["O_TELEVIZYON"]));
                    programAyarlari.fodaBilgisi.checkBoxKapalı.Checked = (Convert.ToBoolean(degiskenler.oku["O_KAPALI"]));
                    programAyarlari.fodaBilgisi.labelOdaYatakSayisi.Text = degiskenler.oku["O_YATAK_SAYISI"].ToString();
                    programAyarlari.fodaBilgisi.labelGenisYatakSayisi.Text = degiskenler.oku["O_GENIS_YATAK_SAYISI"].ToString();
                    programAyarlari.fodaBilgisi.labelKat.Text = degiskenler.oku["O_KAT_NU"].ToString();
                    programAyarlari.fodaBilgisi.labelGecelikFiyat.Text = degiskenler.oku["O_FIYATI"].ToString() + " ₺";
                }
                degiskenler.baglan.Close();
            }
            catch (Exception ex) { programAyarlari.hataVer("Beklenmedik bir hata", "Hata ayrıntılarını buradan  görebilirsiniz.\n\n" + ex); }
            programAyarlari.fodaBilgisi.Show();
        }
        void pic_MouseLeave(object sender, EventArgs e)
        {
            programAyarlari.fodaBilgisi.Hide();
        }
        void pic_MouseMove(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            double s = (MousePosition.X + 20) - programAyarlari.fodaBilgisi.Width - 30;
            if (programAyarlari.fodalar.panel2.Width > 1300)
            {
                if (MousePosition.X + 20 > programAyarlari.fodalar.panel2.Width - p.Width * 3.5) programAyarlari.fodaBilgisi.Location = new Point(Convert.ToInt32(s), MousePosition.Y);
                else programAyarlari.fodaBilgisi.Location = new Point(MousePosition.X + 20, MousePosition.Y);
            }
            else programAyarlari.fodaBilgisi.Location = new Point(MousePosition.X + 20, MousePosition.Y);
        }

        TextBox t;
        private void tChanged(object sender, EventArgs e)
        {
            t = sender as TextBox;
            t.ForeColor = Color.Black;
            if (t.Name == "tSifre") if (tSifre.Text != "Şifre") tSifre.PasswordChar = '*'; // Şifre girilmeye başlandığında karakter * olarak görünsün.
        }

        private void tClick(object sender, EventArgs e)
        {
            t = sender as TextBox;
            if (t.Text == "Kullanıcı adı" || t.Text == "Şifre") t.Text = "";
        }

        private void tKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar)) e.Handled = true; // Bazı özel karakterler girilmesini engelledik.
            if (e.KeyChar == ' ' || e.KeyChar == '+' || e.KeyChar == '^' || e.KeyChar == '=' || e.KeyChar == '|') e.Handled = true; // Ve bu karakterleride biz engelledik.
        }

        private void giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.ExitThread();
        }

        void dGvSutunlariAdlandirma(DataGridView d)
        {
            if (d.Name == "dGvMusteri")
            {
                d.Columns[0].HeaderText = "TC Kimlik";
                d.Columns[1].HeaderText = "Adı Soyadı";
                d.Columns[2].HeaderText = "Telefon";
                d.Columns[3].HeaderText = "Adres";
                d.Columns[4].HeaderText = "Kayıt Tarihi";
                d.Columns[5].HeaderText = "Beraberindekiler";
                d.ClearSelection();
            }
            else if (d.Name == "dGvKullanici")
            {
                d.Columns[0].HeaderText = "TC Kimlik";
                d.Columns[1].HeaderText = "Kullanıcı adı";
                d.Columns[2].HeaderText = "Şifre";
                d.Columns[3].HeaderText = "Adı Soyadı";
                d.Columns[4].HeaderText = "Doğum Tarihi";
                d.Columns[5].HeaderText = "Telefon Numarası";
                d.Columns[6].HeaderText = "Adres";
                d.Columns[7].HeaderText = "E-posta";
                d.Columns[8].HeaderText = "Program yetkisi";
                d.Columns[9].Visible = true;
                d.ClearSelection();
            }
            else if (d.Name == "dGvOdaAyarlari")
            {
                d.Columns[0].HeaderText = "Nu";
                d.Columns[1].HeaderText = "Kat";
                d.Columns[2].HeaderText = "Yatak Sayısı";
                d.Columns[3].HeaderText = "Geniş Yatak";
                d.Columns[4].HeaderText = "Suit";
                d.Columns[5].HeaderText = "Klima";
                d.Columns[6].HeaderText = "Televizyon";
                d.Columns[7].HeaderText = "Temiz";
                d.Columns[8].HeaderText = "Kapalı";
                d.Columns[9].HeaderText = "Fiyat";
                d.ClearSelection();
            }
        }

        private void bSifreUnuttum_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState==CheckState.Checked)
            {
                tSifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                tSifre.UseSystemPasswordChar=true;
                checkBox1.Text = "Göster";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
            sifremiUnuttum.Show();  
            this.Hide();  
        }
    }
}
