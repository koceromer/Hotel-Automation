namespace OtelOtomasyonV1
{
    partial class AdminKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bMusteriSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGvKullanici = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tAra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bDuzenle = new System.Windows.Forms.Button();
            this.bKullaniciEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tAdres = new System.Windows.Forms.TextBox();
            this.tTel = new System.Windows.Forms.TextBox();
            this.tTC = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bResimSec = new System.Windows.Forms.Button();
            this.pResim = new System.Windows.Forms.PictureBox();
            this.cYetki = new System.Windows.Forms.ComboBox();
            this.dTpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tKisisel = new System.Windows.Forms.TextBox();
            this.tKadi = new System.Windows.Forms.TextBox();
            this.tAdSoyad = new System.Windows.Forms.TextBox();
            this.tSifre = new System.Windows.Forms.TextBox();
            this.tSAciklama = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvKullanici)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pResim)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bMusteriSil
            // 
            this.bMusteriSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMusteriSil.AutoSize = true;
            this.bMusteriSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bMusteriSil.BackColor = System.Drawing.Color.DarkRed;
            this.bMusteriSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bMusteriSil.Enabled = false;
            this.bMusteriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMusteriSil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bMusteriSil.ForeColor = System.Drawing.Color.White;
            this.bMusteriSil.Location = new System.Drawing.Point(626, 12);
            this.bMusteriSil.Name = "bMusteriSil";
            this.bMusteriSil.Size = new System.Drawing.Size(140, 31);
            this.bMusteriSil.TabIndex = 13;
            this.bMusteriSil.Text = "Seçilen kullanıcıyı sil";
            this.bMusteriSil.UseVisualStyleBackColor = false;
            this.bMusteriSil.Click += new System.EventHandler(this.bMusteriSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı ara :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dGvKullanici);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 654);
            this.panel2.TabIndex = 1;
            // 
            // dGvKullanici
            // 
            this.dGvKullanici.AllowUserToAddRows = false;
            this.dGvKullanici.AllowUserToDeleteRows = false;
            this.dGvKullanici.AllowUserToResizeColumns = false;
            this.dGvKullanici.AllowUserToResizeRows = false;
            this.dGvKullanici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvKullanici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGvKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGvKullanici.EnableHeadersVisualStyles = false;
            this.dGvKullanici.Location = new System.Drawing.Point(0, 0);
            this.dGvKullanici.Name = "dGvKullanici";
            this.dGvKullanici.ReadOnly = true;
            this.dGvKullanici.RowHeadersVisible = false;
            this.dGvKullanici.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dGvKullanici.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGvKullanici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvKullanici.ShowCellErrors = false;
            this.dGvKullanici.ShowCellToolTips = false;
            this.dGvKullanici.ShowEditingIcon = false;
            this.dGvKullanici.ShowRowErrors = false;
            this.dGvKullanici.Size = new System.Drawing.Size(769, 654);
            this.dGvKullanici.StandardTab = true;
            this.dGvKullanici.TabIndex = 10;
            this.dGvKullanici.VirtualMode = true;
            this.dGvKullanici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bMusteriSil);
            this.panel1.Controls.Add(this.tAra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 54);
            this.panel1.TabIndex = 0;
            // 
            // tAra
            // 
            this.tAra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tAra.Location = new System.Drawing.Point(102, 12);
            this.tAra.Name = "tAra";
            this.tAra.Size = new System.Drawing.Size(511, 26);
            this.tAra.TabIndex = 12;
            this.tAra.Text = "Tc kimlik numarası veya isme göre ara\r\n";
            this.tAra.Click += new System.EventHandler(this.tAra_Click);
            this.tAra.TextChanged += new System.EventHandler(this.tAra_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(0, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Adres :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(0, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bDuzenle
            // 
            this.bDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDuzenle.AutoSize = true;
            this.bDuzenle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bDuzenle.BackColor = System.Drawing.Color.SkyBlue;
            this.bDuzenle.Enabled = false;
            this.bDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDuzenle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bDuzenle.ForeColor = System.Drawing.Color.Cornsilk;
            this.bDuzenle.Location = new System.Drawing.Point(188, 445);
            this.bDuzenle.Name = "bDuzenle";
            this.bDuzenle.Size = new System.Drawing.Size(127, 31);
            this.bDuzenle.TabIndex = 11;
            this.bDuzenle.Text = "Düzenlemeyi bitir";
            this.bDuzenle.UseVisualStyleBackColor = false;
            this.bDuzenle.Click += new System.EventHandler(this.bDuzenle_Click);
            // 
            // bKullaniciEkle
            // 
            this.bKullaniciEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bKullaniciEkle.AutoSize = true;
            this.bKullaniciEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bKullaniciEkle.BackColor = System.Drawing.Color.Chartreuse;
            this.bKullaniciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKullaniciEkle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bKullaniciEkle.ForeColor = System.Drawing.Color.FloralWhite;
            this.bKullaniciEkle.Location = new System.Drawing.Point(188, 403);
            this.bKullaniciEkle.Name = "bKullaniciEkle";
            this.bKullaniciEkle.Size = new System.Drawing.Size(126, 31);
            this.bKullaniciEkle.TabIndex = 10;
            this.bKullaniciEkle.Text = "Yeni kullanıcı ekle";
            this.bKullaniciEkle.UseVisualStyleBackColor = false;
            this.bKullaniciEkle.Click += new System.EventHandler(this.bKullaniciEkle_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(0, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "TC :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tAdres
            // 
            this.tAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tAdres.Location = new System.Drawing.Point(112, 251);
            this.tAdres.Multiline = true;
            this.tAdres.Name = "tAdres";
            this.tAdres.Size = new System.Drawing.Size(205, 52);
            this.tAdres.TabIndex = 6;
            // 
            // tTel
            // 
            this.tTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tTel.Location = new System.Drawing.Point(112, 219);
            this.tTel.Name = "tTel";
            this.tTel.Size = new System.Drawing.Size(205, 26);
            this.tTel.TabIndex = 5;
            // 
            // tTC
            // 
            this.tTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tTC.BackColor = System.Drawing.SystemColors.Window;
            this.tTC.Location = new System.Drawing.Point(112, 59);
            this.tTC.MaxLength = 11;
            this.tTC.Name = "tTC";
            this.tTC.Size = new System.Drawing.Size(205, 26);
            this.tTC.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.BackgroundImage = global::OtelOtomasyonV1.Properties.Resources.mavi_;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.bResimSec);
            this.splitContainer1.Panel1.Controls.Add(this.pResim);
            this.splitContainer1.Panel1.Controls.Add(this.cYetki);
            this.splitContainer1.Panel1.Controls.Add(this.dTpDogumTarihi);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.bDuzenle);
            this.splitContainer1.Panel1.Controls.Add(this.bKullaniciEkle);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.tKisisel);
            this.splitContainer1.Panel1.Controls.Add(this.tAdres);
            this.splitContainer1.Panel1.Controls.Add(this.tTel);
            this.splitContainer1.Panel1.Controls.Add(this.tKadi);
            this.splitContainer1.Panel1.Controls.Add(this.tAdSoyad);
            this.splitContainer1.Panel1.Controls.Add(this.tSifre);
            this.splitContainer1.Panel1.Controls.Add(this.tTC);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1098, 708);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 54);
            this.label2.TabIndex = 26;
            this.label2.Text = "YENİ PROGRAM KULLANICISI OLUŞTUR\r\nVEYA KULLANICIYI DÜZENLE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(28, 597);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Max (20 MB)";
            // 
            // bResimSec
            // 
            this.bResimSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bResimSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bResimSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bResimSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bResimSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bResimSec.ForeColor = System.Drawing.Color.Cornsilk;
            this.bResimSec.Location = new System.Drawing.Point(3, 559);
            this.bResimSec.Name = "bResimSec";
            this.bResimSec.Size = new System.Drawing.Size(150, 35);
            this.bResimSec.TabIndex = 9;
            this.bResimSec.Text = "Resim seç";
            this.bResimSec.UseVisualStyleBackColor = false;
            this.bResimSec.Click += new System.EventHandler(this.bResimSec_Click);
            // 
            // pResim
            // 
            this.pResim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pResim.BackColor = System.Drawing.Color.Transparent;
            this.pResim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pResim.Image = global::OtelOtomasyonV1.Properties.Resources.ResimYükleme;
            this.pResim.Location = new System.Drawing.Point(3, 403);
            this.pResim.Name = "pResim";
            this.pResim.Size = new System.Drawing.Size(150, 150);
            this.pResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pResim.TabIndex = 23;
            this.pResim.TabStop = false;
            // 
            // cYetki
            // 
            this.cYetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cYetki.FormattingEnabled = true;
            this.cYetki.Location = new System.Drawing.Point(114, 341);
            this.cYetki.Name = "cYetki";
            this.cYetki.Size = new System.Drawing.Size(205, 27);
            this.cYetki.TabIndex = 8;
            // 
            // dTpDogumTarihi
            // 
            this.dTpDogumTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dTpDogumTarihi.Location = new System.Drawing.Point(112, 187);
            this.dTpDogumTarihi.Name = "dTpDogumTarihi";
            this.dTpDogumTarihi.Size = new System.Drawing.Size(205, 26);
            this.dTpDogumTarihi.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 643);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 65);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 57);
            this.label7.TabIndex = 16;
            this.label7.Text = "Yeni kullanıcı eklemek için gerekli alanları doldurup \"Yeni kullanıcı ekle\" buton" +
    "una basmanız yeterli olacaktır.";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(0, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Yetkisi :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(0, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "E-posta :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(-1, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 26);
            this.label10.TabIndex = 12;
            this.label10.Text = "Kullanıcı adı :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(0, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 26);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ad soyad :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(0, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 26);
            this.label11.TabIndex = 12;
            this.label11.Text = "Şifre :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(-4, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 26);
            this.label12.TabIndex = 12;
            this.label12.Text = "Doğum Tarihi :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tKisisel
            // 
            this.tKisisel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tKisisel.Location = new System.Drawing.Point(114, 309);
            this.tKisisel.Name = "tKisisel";
            this.tKisisel.Size = new System.Drawing.Size(205, 26);
            this.tKisisel.TabIndex = 7;
            // 
            // tKadi
            // 
            this.tKadi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tKadi.Location = new System.Drawing.Point(112, 91);
            this.tKadi.Name = "tKadi";
            this.tKadi.Size = new System.Drawing.Size(205, 26);
            this.tKadi.TabIndex = 1;
            // 
            // tAdSoyad
            // 
            this.tAdSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tAdSoyad.Location = new System.Drawing.Point(112, 155);
            this.tAdSoyad.Name = "tAdSoyad";
            this.tAdSoyad.Size = new System.Drawing.Size(205, 26);
            this.tAdSoyad.TabIndex = 3;
            // 
            // tSifre
            // 
            this.tSifre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tSifre.Location = new System.Drawing.Point(112, 123);
            this.tSifre.Name = "tSifre";
            this.tSifre.Size = new System.Drawing.Size(205, 26);
            this.tSifre.TabIndex = 2;
            // 
            // tSAciklama
            // 
            this.tSAciklama.BackColor = System.Drawing.Color.Transparent;
            this.tSAciklama.Name = "tSAciklama";
            this.tSAciklama.Size = new System.Drawing.Size(277, 17);
            this.tSAciklama.Text = "Bu program ömer ve fatih tarafından tasarlanmıştır.";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAciklama});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1098, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::OtelOtomasyonV1.Properties.Resources.mavi_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 730);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullanicilar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kullanicilar_FormClosing);
            this.Load += new System.EventHandler(this.kullanicilar_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGvKullanici)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pResim)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button bMusteriSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dGvKullanici;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tAra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button bDuzenle;
        public System.Windows.Forms.Button bKullaniciEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tAdres;
        private System.Windows.Forms.TextBox tTel;
        private System.Windows.Forms.TextBox tTC;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel tSAciklama;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tKadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tKisisel;
        private System.Windows.Forms.TextBox tAdSoyad;
        private System.Windows.Forms.TextBox tSifre;
        public System.Windows.Forms.DateTimePicker dTpDogumTarihi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bResimSec;
        public System.Windows.Forms.PictureBox pResim;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cYetki;
    }
}