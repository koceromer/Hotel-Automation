namespace OtelOtomasyonV1
{
    partial class OdaKontrol
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bMusteriEkle = new System.Windows.Forms.Button();
            this.bTemizeGec = new System.Windows.Forms.Button();
            this.bMusteriCikisi = new System.Windows.Forms.Button();
            this.bRezervasyon = new System.Windows.Forms.Button();
            this.lSecilenOda = new System.Windows.Forms.Label();
            this.lBos = new System.Windows.Forms.Label();
            this.lDolu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAciklama});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSAciklama
            // 
            this.tSAciklama.BackColor = System.Drawing.Color.Transparent;
            this.tSAciklama.Name = "tSAciklama";
            this.tSAciklama.Size = new System.Drawing.Size(348, 20);
            this.tSAciklama.Text = "Bu program ömer ve fatih tarafından tasarlanmıştır.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bMusteriEkle);
            this.panel1.Controls.Add(this.bTemizeGec);
            this.panel1.Controls.Add(this.bMusteriCikisi);
            this.panel1.Controls.Add(this.bRezervasyon);
            this.panel1.Controls.Add(this.lSecilenOda);
            this.panel1.Controls.Add(this.lBos);
            this.panel1.Controls.Add(this.lDolu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 39);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bMusteriEkle
            // 
            this.bMusteriEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMusteriEkle.AutoSize = true;
            this.bMusteriEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bMusteriEkle.Enabled = false;
            this.bMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMusteriEkle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bMusteriEkle.ForeColor = System.Drawing.Color.FloralWhite;
            this.bMusteriEkle.Location = new System.Drawing.Point(526, 2);
            this.bMusteriEkle.Name = "bMusteriEkle";
            this.bMusteriEkle.Size = new System.Drawing.Size(114, 35);
            this.bMusteriEkle.TabIndex = 1;
            this.bMusteriEkle.Text = "Müşteri Ekle";
            this.bMusteriEkle.UseVisualStyleBackColor = false;
            this.bMusteriEkle.Click += new System.EventHandler(this.bMusteriEkle_Click);
            // 
            // bTemizeGec
            // 
            this.bTemizeGec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTemizeGec.AutoSize = true;
            this.bTemizeGec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bTemizeGec.BackColor = System.Drawing.Color.Gray;
            this.bTemizeGec.Enabled = false;
            this.bTemizeGec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTemizeGec.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bTemizeGec.ForeColor = System.Drawing.Color.Cornsilk;
            this.bTemizeGec.Location = new System.Drawing.Point(626, 2);
            this.bTemizeGec.Name = "bTemizeGec";
            this.bTemizeGec.Size = new System.Drawing.Size(108, 35);
            this.bTemizeGec.TabIndex = 1;
            this.bTemizeGec.Text = "Temize Geç";
            this.bTemizeGec.UseVisualStyleBackColor = false;
            this.bTemizeGec.Click += new System.EventHandler(this.bTemizeGec_Click);
            // 
            // bMusteriCikisi
            // 
            this.bMusteriCikisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMusteriCikisi.AutoSize = true;
            this.bMusteriCikisi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bMusteriCikisi.BackColor = System.Drawing.Color.DarkRed;
            this.bMusteriCikisi.Enabled = false;
            this.bMusteriCikisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMusteriCikisi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bMusteriCikisi.ForeColor = System.Drawing.Color.White;
            this.bMusteriCikisi.Location = new System.Drawing.Point(842, 3);
            this.bMusteriCikisi.Name = "bMusteriCikisi";
            this.bMusteriCikisi.Size = new System.Drawing.Size(154, 35);
            this.bMusteriCikisi.TabIndex = 1;
            this.bMusteriCikisi.Text = "Müşteri Çıkışı Yap";
            this.bMusteriCikisi.UseVisualStyleBackColor = false;
            this.bMusteriCikisi.Click += new System.EventHandler(this.bMusteriCikisi_Click);
            // 
            // bRezervasyon
            // 
            this.bRezervasyon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRezervasyon.AutoSize = true;
            this.bRezervasyon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bRezervasyon.BackColor = System.Drawing.Color.DarkOrange;
            this.bRezervasyon.Enabled = false;
            this.bRezervasyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRezervasyon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bRezervasyon.ForeColor = System.Drawing.Color.FloralWhite;
            this.bRezervasyon.Location = new System.Drawing.Point(715, 3);
            this.bRezervasyon.Name = "bRezervasyon";
            this.bRezervasyon.Size = new System.Drawing.Size(148, 35);
            this.bRezervasyon.TabIndex = 1;
            this.bRezervasyon.Text = "Rezervasyon yap";
            this.bRezervasyon.UseVisualStyleBackColor = false;
            this.bRezervasyon.Click += new System.EventHandler(this.button1_Click);
            // 
            // lSecilenOda
            // 
            this.lSecilenOda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSecilenOda.AutoSize = true;
            this.lSecilenOda.BackColor = System.Drawing.Color.Gainsboro;
            this.lSecilenOda.ForeColor = System.Drawing.Color.DarkBlue;
            this.lSecilenOda.Location = new System.Drawing.Point(377, 7);
            this.lSecilenOda.Name = "lSecilenOda";
            this.lSecilenOda.Size = new System.Drawing.Size(162, 28);
            this.lSecilenOda.TabIndex = 0;
            this.lSecilenOda.Text = "Son seçilen oda : ";
            // 
            // lBos
            // 
            this.lBos.AutoSize = true;
            this.lBos.BackColor = System.Drawing.Color.ForestGreen;
            this.lBos.ForeColor = System.Drawing.Color.Cornsilk;
            this.lBos.Location = new System.Drawing.Point(131, 9);
            this.lBos.Name = "lBos";
            this.lBos.Size = new System.Drawing.Size(65, 28);
            this.lBos.TabIndex = 0;
            this.lBos.Text = "label1";
            // 
            // lDolu
            // 
            this.lDolu.AutoSize = true;
            this.lDolu.BackColor = System.Drawing.Color.Firebrick;
            this.lDolu.ForeColor = System.Drawing.Color.Cornsilk;
            this.lDolu.Location = new System.Drawing.Point(12, 9);
            this.lDolu.Name = "lDolu";
            this.lDolu.Size = new System.Drawing.Size(65, 28);
            this.lDolu.TabIndex = 0;
            this.lDolu.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::OtelOtomasyonV1.Properties.Resources._20220115_BULANIK1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 665);
            this.panel2.TabIndex = 5;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // odalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "odalar";
            this.Text = "odalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.odalar_FormClosing);
            this.Load += new System.EventHandler(this.odalar_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lDolu;
        public System.Windows.Forms.Label lBos;
        public System.Windows.Forms.Label lSecilenOda;
        public System.Windows.Forms.Button bMusteriCikisi;
        public System.Windows.Forms.Button bMusteriEkle;
        public System.Windows.Forms.Button bTemizeGec;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripStatusLabel tSAciklama;
        public System.Windows.Forms.Button bRezervasyon;



    }
}