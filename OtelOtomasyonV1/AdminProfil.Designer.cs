namespace OtelOtomasyonV1
{
    partial class AdminProfil
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
            this.lTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tKAdi = new System.Windows.Forms.TextBox();
            this.tAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tTel = new System.Windows.Forms.TextBox();
            this.tAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tEskiSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tYeniSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bDuzenle = new System.Windows.Forms.Button();
            this.bResimSec = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dTpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tKisiselBilgiler = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSAciklama = new System.Windows.Forms.ToolStripStatusLabel();
            this.pResim = new System.Windows.Forms.PictureBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lTC
            // 
            this.lTC.AutoSize = true;
            this.lTC.BackColor = System.Drawing.Color.Transparent;
            this.lTC.ForeColor = System.Drawing.Color.Black;
            this.lTC.Location = new System.Drawing.Point(32, 3);
            this.lTC.Name = "lTC";
            this.lTC.Size = new System.Drawing.Size(109, 21);
            this.lTC.TabIndex = 1;
            this.lTC.Text = "12345678901";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(167, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı adı : ";
            // 
            // tKAdi
            // 
            this.tKAdi.Enabled = false;
            this.tKAdi.Location = new System.Drawing.Point(277, 13);
            this.tKAdi.MaxLength = 25;
            this.tKAdi.Name = "tKAdi";
            this.tKAdi.Size = new System.Drawing.Size(170, 29);
            this.tKAdi.TabIndex = 0;
            // 
            // tAdiSoyadi
            // 
            this.tAdiSoyadi.Location = new System.Drawing.Point(276, 48);
            this.tAdiSoyadi.MaxLength = 50;
            this.tAdiSoyadi.Name = "tAdiSoyadi";
            this.tAdiSoyadi.Size = new System.Drawing.Size(170, 29);
            this.tAdiSoyadi.TabIndex = 1;
            this.tAdiSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tAdiSoyadi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(178, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adı soyadı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(198, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon : ";
            // 
            // tTel
            // 
            this.tTel.Location = new System.Drawing.Point(276, 83);
            this.tTel.MaxLength = 11;
            this.tTel.Name = "tTel";
            this.tTel.Size = new System.Drawing.Size(170, 29);
            this.tTel.TabIndex = 2;
            this.tTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tTel_KeyPress);
            // 
            // tAdres
            // 
            this.tAdres.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tAdres.Location = new System.Drawing.Point(276, 120);
            this.tAdres.MaxLength = 255;
            this.tAdres.Multiline = true;
            this.tAdres.Name = "tAdres";
            this.tAdres.Size = new System.Drawing.Size(170, 81);
            this.tAdres.TabIndex = 3;
            this.tAdres.Text = "\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(209, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adres : ";
            // 
            // tEskiSifre
            // 
            this.tEskiSifre.Location = new System.Drawing.Point(100, 357);
            this.tEskiSifre.MaxLength = 50;
            this.tEskiSifre.Name = "tEskiSifre";
            this.tEskiSifre.PasswordChar = '*';
            this.tEskiSifre.Size = new System.Drawing.Size(170, 29);
            this.tEskiSifre.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(13, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Eski şifre : ";
            // 
            // tYeniSifre
            // 
            this.tYeniSifre.Location = new System.Drawing.Point(100, 392);
            this.tYeniSifre.MaxLength = 50;
            this.tYeniSifre.Name = "tYeniSifre";
            this.tYeniSifre.PasswordChar = '*';
            this.tYeniSifre.Size = new System.Drawing.Size(170, 29);
            this.tYeniSifre.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(10, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Yeni şifre : ";
            // 
            // bDuzenle
            // 
            this.bDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDuzenle.ForeColor = System.Drawing.Color.Cornsilk;
            this.bDuzenle.Location = new System.Drawing.Point(277, 358);
            this.bDuzenle.Name = "bDuzenle";
            this.bDuzenle.Size = new System.Drawing.Size(170, 63);
            this.bDuzenle.TabIndex = 8;
            this.bDuzenle.Text = "Düzenlemeyi bitir";
            this.bDuzenle.UseVisualStyleBackColor = false;
            this.bDuzenle.Click += new System.EventHandler(this.bDuzenle_Click);
            // 
            // bResimSec
            // 
            this.bResimSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bResimSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bResimSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bResimSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bResimSec.ForeColor = System.Drawing.Color.Cornsilk;
            this.bResimSec.Location = new System.Drawing.Point(11, 178);
            this.bResimSec.Name = "bResimSec";
            this.bResimSec.Size = new System.Drawing.Size(150, 35);
            this.bResimSec.TabIndex = 9;
            this.bResimSec.Text = "Resim seç";
            this.bResimSec.UseVisualStyleBackColor = false;
            this.bResimSec.Click += new System.EventHandler(this.bResimSec_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(51, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Max (20 MB)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(157, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Doğum tarihi : ";
            // 
            // dTpDogumTarihi
            // 
            this.dTpDogumTarihi.Location = new System.Drawing.Point(275, 207);
            this.dTpDogumTarihi.Name = "dTpDogumTarihi";
            this.dTpDogumTarihi.Size = new System.Drawing.Size(171, 29);
            this.dTpDogumTarihi.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.tKisiselBilgiler);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(14, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 109);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "E-posta";
            // 
            // tKisiselBilgiler
            // 
            this.tKisiselBilgiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tKisiselBilgiler.Location = new System.Drawing.Point(3, 25);
            this.tKisiselBilgiler.Name = "tKisiselBilgiler";
            this.tKisiselBilgiler.Size = new System.Drawing.Size(429, 81);
            this.tKisiselBilgiler.TabIndex = 0;
            this.tKisiselBilgiler.Text = "";
            this.tKisiselBilgiler.TextChanged += new System.EventHandler(this.tKisiselBilgiler_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAciklama});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(454, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSAciklama
            // 
            this.tSAciklama.BackColor = System.Drawing.Color.Transparent;
            this.tSAciklama.Name = "tSAciklama";
            this.tSAciklama.Size = new System.Drawing.Size(277, 17);
            this.tSAciklama.Text = "Bu program ömer ve fatih tarafından tasarlanmıştır.";
            // 
            // pResim
            // 
            this.pResim.BackColor = System.Drawing.Color.Transparent;
            this.pResim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pResim.Image = global::OtelOtomasyonV1.Properties.Resources.ResimYükleme;
            this.pResim.Location = new System.Drawing.Point(11, 27);
            this.pResim.Name = "pResim";
            this.pResim.Size = new System.Drawing.Size(150, 150);
            this.pResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pResim.TabIndex = 0;
            this.pResim.TabStop = false;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // AdminProfil
            // 
            this.AcceptButton = this.bDuzenle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::OtelOtomasyonV1.Properties.Resources.mavi_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 451);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dTpDogumTarihi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bResimSec);
            this.Controls.Add(this.bDuzenle);
            this.Controls.Add(this.tYeniSifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tEskiSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tAdres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tTel);
            this.Controls.Add(this.tAdiSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tKAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lTC);
            this.Controls.Add(this.pResim);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "profil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.profil_FormClosing);
            this.Load += new System.EventHandler(this.profil_Load);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bDuzenle;
        public System.Windows.Forms.Label lTC;
        public System.Windows.Forms.TextBox tKAdi;
        public System.Windows.Forms.TextBox tAdiSoyadi;
        public System.Windows.Forms.TextBox tTel;
        public System.Windows.Forms.TextBox tAdres;
        public System.Windows.Forms.TextBox tEskiSifre;
        public System.Windows.Forms.TextBox tYeniSifre;
        private System.Windows.Forms.Button bResimSec;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker dTpDogumTarihi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSAciklama;
        public System.Windows.Forms.RichTextBox tKisiselBilgiler;
        private System.Windows.Forms.OpenFileDialog ofd;
        public System.Windows.Forms.PictureBox pResim;
    }
}