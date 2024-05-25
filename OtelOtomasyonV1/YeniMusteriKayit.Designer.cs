namespace OtelOtomasyonV1
{
    partial class YeniMusteriKayit
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSAciklama = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBeraberindekiler = new System.Windows.Forms.TextBox();
            this.tTel = new System.Windows.Forms.TextBox();
            this.tAdres = new System.Windows.Forms.TextBox();
            this.tAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dTpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelOdaNu = new System.Windows.Forms.Label();
            this.tMusteriTC = new System.Windows.Forms.TextBox();
            this.labelRezervasyon = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAciklama});
            this.statusStrip1.Location = new System.Drawing.Point(0, 312);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSAciklama
            // 
            this.tSAciklama.BackColor = System.Drawing.Color.Transparent;
            this.tSAciklama.Name = "tSAciklama";
            this.tSAciklama.Size = new System.Drawing.Size(277, 17);
            this.tSAciklama.Text = "Bu program ömer ve fatih tarafından tasarlanmıştır.";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(254, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Müşteri kayıtlı ise işaretleyiniz. ";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::OtelOtomasyonV1.Properties.Resources.mavi_;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 276);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tBeraberindekiler);
            this.groupBox1.Controls.Add(this.tTel);
            this.groupBox1.Controls.Add(this.tAdres);
            this.groupBox1.Controls.Add(this.tAdiSoyadi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni müşteri bilgileri";
            // 
            // tBeraberindekiler
            // 
            this.tBeraberindekiler.Location = new System.Drawing.Point(142, 100);
            this.tBeraberindekiler.Name = "tBeraberindekiler";
            this.tBeraberindekiler.Size = new System.Drawing.Size(190, 26);
            this.tBeraberindekiler.TabIndex = 2;
            // 
            // tTel
            // 
            this.tTel.Location = new System.Drawing.Point(142, 65);
            this.tTel.Name = "tTel";
            this.tTel.Size = new System.Drawing.Size(190, 26);
            this.tTel.TabIndex = 1;
            // 
            // tAdres
            // 
            this.tAdres.Location = new System.Drawing.Point(397, 33);
            this.tAdres.Multiline = true;
            this.tAdres.Name = "tAdres";
            this.tAdres.Size = new System.Drawing.Size(176, 93);
            this.tAdres.TabIndex = 3;
            // 
            // tAdiSoyadi
            // 
            this.tAdiSoyadi.Location = new System.Drawing.Point(142, 30);
            this.tAdiSoyadi.Name = "tAdiSoyadi";
            this.tAdiSoyadi.Size = new System.Drawing.Size(190, 26);
            this.tAdiSoyadi.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Beraberindekiler :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label2.Location = new System.Drawing.Point(69, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label3.Location = new System.Drawing.Point(338, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adres :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı soyadı :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dTpCikisTarihi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelOdaNu);
            this.groupBox2.Controls.Add(this.tMusteriTC);
            this.groupBox2.Location = new System.Drawing.Point(3, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 126);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oda kayıt işlemleri";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(342, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Müşteriyi ekle ve oda kaydı";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dTpCikisTarihi
            // 
            this.dTpCikisTarihi.Location = new System.Drawing.Point(126, 63);
            this.dTpCikisTarihi.Name = "dTpCikisTarihi";
            this.dTpCikisTarihi.Size = new System.Drawing.Size(200, 26);
            this.dTpCikisTarihi.TabIndex = 6;
            this.dTpCikisTarihi.ValueChanged += new System.EventHandler(this.dTpCikisTarihi_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label8.Location = new System.Drawing.Point(27, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Çıkış tarihi :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label5.Location = new System.Drawing.Point(20, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Müşteri TC :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOdaNu
            // 
            this.labelOdaNu.AutoSize = true;
            this.labelOdaNu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelOdaNu.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.labelOdaNu.Location = new System.Drawing.Point(379, 4);
            this.labelOdaNu.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.labelOdaNu.Name = "labelOdaNu";
            this.labelOdaNu.Size = new System.Drawing.Size(147, 21);
            this.labelOdaNu.TabIndex = 11;
            this.labelOdaNu.Text = "Oda numarası 100";
            this.labelOdaNu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tMusteriTC
            // 
            this.tMusteriTC.Location = new System.Drawing.Point(126, 31);
            this.tMusteriTC.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tMusteriTC.MaxLength = 11;
            this.tMusteriTC.Name = "tMusteriTC";
            this.tMusteriTC.Size = new System.Drawing.Size(200, 26);
            this.tMusteriTC.TabIndex = 4;
            // 
            // labelRezervasyon
            // 
            this.labelRezervasyon.AutoSize = true;
            this.labelRezervasyon.BackColor = System.Drawing.Color.Transparent;
            this.labelRezervasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRezervasyon.Location = new System.Drawing.Point(17, 277);
            this.labelRezervasyon.Name = "labelRezervasyon";
            this.labelRezervasyon.Size = new System.Drawing.Size(229, 19);
            this.labelRezervasyon.TabIndex = 7;
            this.labelRezervasyon.Text = "Oda rezervasyonu bulunmamaktadır.";
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(345, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Odaya ait rezervasyonlar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // musteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::OtelOtomasyonV1.Properties.Resources.mavi_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 334);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelRezervasyon);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "musteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "musteriEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.musteriEkle_FormClosing);
            this.Load += new System.EventHandler(this.musteriEkle_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSAciklama;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBeraberindekiler;
        private System.Windows.Forms.TextBox tTel;
        private System.Windows.Forms.TextBox tAdres;
        private System.Windows.Forms.TextBox tAdiSoyadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tMusteriTC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labelOdaNu;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label labelRezervasyon;
        public System.Windows.Forms.DateTimePicker dTpCikisTarihi;
    }
}