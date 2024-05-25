namespace OtelOtomasyonV1
{
    partial class OdaDüzen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSAciklama = new System.Windows.Forms.ToolStripStatusLabel();
            this.tOda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_katNumarasi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_yatakSayisi = new System.Windows.Forms.ComboBox();
            this.comboBox_genisYatakSayisi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_suit = new System.Windows.Forms.CheckBox();
            this.checkBox_klima = new System.Windows.Forms.CheckBox();
            this.checkBox_televizyon = new System.Windows.Forms.CheckBox();
            this.checkBox_temiz = new System.Windows.Forms.CheckBox();
            this.checkBox_kapali = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tOdaFiyati = new System.Windows.Forms.TextBox();
            this.bDuzenle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dGvOdaAyarlari = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvOdaAyarlari)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAciklama});
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSAciklama
            // 
            this.tSAciklama.BackColor = System.Drawing.Color.Transparent;
            this.tSAciklama.Name = "tSAciklama";
            this.tSAciklama.Size = new System.Drawing.Size(277, 17);
            this.tSAciklama.Text = "Bu program ömer ve fatih tarafından tasarlanmıştır.";
            // 
            // tOda
            // 
            this.tOda.Location = new System.Drawing.Point(184, 81);
            this.tOda.MaxLength = 20;
            this.tOda.Name = "tOda";
            this.tOda.Size = new System.Drawing.Size(217, 29);
            this.tOda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Oda numarası giriniz :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 59);
            this.label2.TabIndex = 12;
            this.label2.Text = "YENİ ODA EKLE VEYA DÜZENLE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kat numarası :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_katNumarasi
            // 
            this.comboBox_katNumarasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_katNumarasi.FormattingEnabled = true;
            this.comboBox_katNumarasi.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_katNumarasi.Location = new System.Drawing.Point(184, 116);
            this.comboBox_katNumarasi.Name = "comboBox_katNumarasi";
            this.comboBox_katNumarasi.Size = new System.Drawing.Size(217, 29);
            this.comboBox_katNumarasi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(16, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yatak sayısı :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_yatakSayisi
            // 
            this.comboBox_yatakSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_yatakSayisi.FormattingEnabled = true;
            this.comboBox_yatakSayisi.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_yatakSayisi.Location = new System.Drawing.Point(184, 151);
            this.comboBox_yatakSayisi.Name = "comboBox_yatakSayisi";
            this.comboBox_yatakSayisi.Size = new System.Drawing.Size(217, 29);
            this.comboBox_yatakSayisi.TabIndex = 2;
            // 
            // comboBox_genisYatakSayisi
            // 
            this.comboBox_genisYatakSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_genisYatakSayisi.FormattingEnabled = true;
            this.comboBox_genisYatakSayisi.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_genisYatakSayisi.Location = new System.Drawing.Point(184, 186);
            this.comboBox_genisYatakSayisi.Name = "comboBox_genisYatakSayisi";
            this.comboBox_genisYatakSayisi.Size = new System.Drawing.Size(217, 29);
            this.comboBox_genisYatakSayisi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(16, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Geniş yatak sayısı :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox_suit
            // 
            this.checkBox_suit.AutoSize = true;
            this.checkBox_suit.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_suit.ForeColor = System.Drawing.Color.Cornsilk;
            this.checkBox_suit.Location = new System.Drawing.Point(184, 222);
            this.checkBox_suit.Name = "checkBox_suit";
            this.checkBox_suit.Size = new System.Drawing.Size(56, 25);
            this.checkBox_suit.TabIndex = 4;
            this.checkBox_suit.Text = "Suit";
            this.checkBox_suit.UseVisualStyleBackColor = false;
            // 
            // checkBox_klima
            // 
            this.checkBox_klima.AutoSize = true;
            this.checkBox_klima.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_klima.ForeColor = System.Drawing.Color.Cornsilk;
            this.checkBox_klima.Location = new System.Drawing.Point(257, 222);
            this.checkBox_klima.Name = "checkBox_klima";
            this.checkBox_klima.Size = new System.Drawing.Size(68, 25);
            this.checkBox_klima.TabIndex = 5;
            this.checkBox_klima.Text = "Klima";
            this.checkBox_klima.UseVisualStyleBackColor = false;
            // 
            // checkBox_televizyon
            // 
            this.checkBox_televizyon.AutoSize = true;
            this.checkBox_televizyon.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_televizyon.ForeColor = System.Drawing.Color.Cornsilk;
            this.checkBox_televizyon.Location = new System.Drawing.Point(184, 253);
            this.checkBox_televizyon.Name = "checkBox_televizyon";
            this.checkBox_televizyon.Size = new System.Drawing.Size(100, 25);
            this.checkBox_televizyon.TabIndex = 7;
            this.checkBox_televizyon.Text = "Televizyon";
            this.checkBox_televizyon.UseVisualStyleBackColor = false;
            // 
            // checkBox_temiz
            // 
            this.checkBox_temiz.AutoSize = true;
            this.checkBox_temiz.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_temiz.ForeColor = System.Drawing.Color.Cornsilk;
            this.checkBox_temiz.Location = new System.Drawing.Point(331, 222);
            this.checkBox_temiz.Name = "checkBox_temiz";
            this.checkBox_temiz.Size = new System.Drawing.Size(68, 25);
            this.checkBox_temiz.TabIndex = 6;
            this.checkBox_temiz.Text = "Temiz";
            this.checkBox_temiz.UseVisualStyleBackColor = false;
            // 
            // checkBox_kapali
            // 
            this.checkBox_kapali.AutoSize = true;
            this.checkBox_kapali.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_kapali.ForeColor = System.Drawing.Color.Cornsilk;
            this.checkBox_kapali.Location = new System.Drawing.Point(304, 253);
            this.checkBox_kapali.Name = "checkBox_kapali";
            this.checkBox_kapali.Size = new System.Drawing.Size(71, 25);
            this.checkBox_kapali.TabIndex = 8;
            this.checkBox_kapali.Text = "Kapalı";
            this.checkBox_kapali.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(6, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Oda fiyatı giriniz :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tOdaFiyati
            // 
            this.tOdaFiyati.Location = new System.Drawing.Point(184, 284);
            this.tOdaFiyati.MaxLength = 20;
            this.tOdaFiyati.Name = "tOdaFiyati";
            this.tOdaFiyati.Size = new System.Drawing.Size(217, 29);
            this.tOdaFiyati.TabIndex = 9;
            // 
            // bDuzenle
            // 
            this.bDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDuzenle.ForeColor = System.Drawing.Color.Cornsilk;
            this.bDuzenle.Location = new System.Drawing.Point(184, 362);
            this.bDuzenle.Name = "bDuzenle";
            this.bDuzenle.Size = new System.Drawing.Size(217, 37);
            this.bDuzenle.TabIndex = 11;
            this.bDuzenle.Text = "Oda düzenlemeyi bitir";
            this.bDuzenle.UseVisualStyleBackColor = false;
            this.bDuzenle.Click += new System.EventHandler(this.bDuzenle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(184, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Yeni odayı ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGvOdaAyarlari
            // 
            this.dGvOdaAyarlari.AllowUserToAddRows = false;
            this.dGvOdaAyarlari.AllowUserToDeleteRows = false;
            this.dGvOdaAyarlari.AllowUserToResizeColumns = false;
            this.dGvOdaAyarlari.AllowUserToResizeRows = false;
            this.dGvOdaAyarlari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvOdaAyarlari.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGvOdaAyarlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvOdaAyarlari.EnableHeadersVisualStyles = false;
            this.dGvOdaAyarlari.Location = new System.Drawing.Point(407, 12);
            this.dGvOdaAyarlari.Name = "dGvOdaAyarlari";
            this.dGvOdaAyarlari.ReadOnly = true;
            this.dGvOdaAyarlari.RowHeadersVisible = false;
            this.dGvOdaAyarlari.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dGvOdaAyarlari.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGvOdaAyarlari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvOdaAyarlari.ShowCellErrors = false;
            this.dGvOdaAyarlari.ShowCellToolTips = false;
            this.dGvOdaAyarlari.ShowEditingIcon = false;
            this.dGvOdaAyarlari.ShowRowErrors = false;
            this.dGvOdaAyarlari.Size = new System.Drawing.Size(589, 387);
            this.dGvOdaAyarlari.StandardTab = true;
            this.dGvOdaAyarlari.TabIndex = 21;
            this.dGvOdaAyarlari.VirtualMode = true;
            this.dGvOdaAyarlari.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGvOdaAyarlari_CellClick);
            // 
            // odaAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = global::OtelOtomasyonV1.Properties.Resources.mavi_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 431);
            this.Controls.Add(this.dGvOdaAyarlari);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bDuzenle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tOdaFiyati);
            this.Controls.Add(this.checkBox_kapali);
            this.Controls.Add(this.checkBox_temiz);
            this.Controls.Add(this.checkBox_televizyon);
            this.Controls.Add(this.checkBox_klima);
            this.Controls.Add(this.checkBox_suit);
            this.Controls.Add(this.comboBox_genisYatakSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_yatakSayisi);
            this.Controls.Add(this.comboBox_katNumarasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tOda);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "odaAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "odaAyarlari";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.odaAyarlari_FormClosing);
            this.Load += new System.EventHandler(this.odaAyarlari_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvOdaAyarlari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSAciklama;
        private System.Windows.Forms.TextBox tOda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_katNumarasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_yatakSayisi;
        private System.Windows.Forms.ComboBox comboBox_genisYatakSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_suit;
        private System.Windows.Forms.CheckBox checkBox_klima;
        private System.Windows.Forms.CheckBox checkBox_televizyon;
        private System.Windows.Forms.CheckBox checkBox_temiz;
        private System.Windows.Forms.CheckBox checkBox_kapali;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tOdaFiyati;
        private System.Windows.Forms.Button bDuzenle;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dGvOdaAyarlari;
    }
}