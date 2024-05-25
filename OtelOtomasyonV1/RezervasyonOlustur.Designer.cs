namespace OtelOtomasyonV1
{
    partial class RezervasyonOlustur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSAciklama = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGvTumRezervasyon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bMusteriSil = new System.Windows.Forms.Button();
            this.bDuzenle = new System.Windows.Forms.Button();
            this.bMusteriEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tTC = new System.Windows.Forms.TextBox();
            this.dTpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dTpBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cOda = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGvSecilenOdaRezervasyonlari = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dGvRezervasyonuOlanKisiler = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvTumRezervasyon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvSecilenOdaRezervasyonlari)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvRezervasyonuOlanKisiler)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAciklama});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
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
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::OtelOtomasyonV1.Properties.Resources._20220115_BULANIK1;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dGvTumRezervasyon);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(2, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 502);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tüm Rezervasyon Listesi";
            // 
            // dGvTumRezervasyon
            // 
            this.dGvTumRezervasyon.AllowUserToAddRows = false;
            this.dGvTumRezervasyon.AllowUserToDeleteRows = false;
            this.dGvTumRezervasyon.AllowUserToResizeColumns = false;
            this.dGvTumRezervasyon.AllowUserToResizeRows = false;
            this.dGvTumRezervasyon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvTumRezervasyon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGvTumRezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvTumRezervasyon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGvTumRezervasyon.EnableHeadersVisualStyles = false;
            this.dGvTumRezervasyon.Location = new System.Drawing.Point(3, 22);
            this.dGvTumRezervasyon.Name = "dGvTumRezervasyon";
            this.dGvTumRezervasyon.ReadOnly = true;
            this.dGvTumRezervasyon.RowHeadersVisible = false;
            this.dGvTumRezervasyon.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dGvTumRezervasyon.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGvTumRezervasyon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvTumRezervasyon.ShowCellErrors = false;
            this.dGvTumRezervasyon.ShowCellToolTips = false;
            this.dGvTumRezervasyon.ShowEditingIcon = false;
            this.dGvTumRezervasyon.ShowRowErrors = false;
            this.dGvTumRezervasyon.Size = new System.Drawing.Size(584, 477);
            this.dGvTumRezervasyon.StandardTab = true;
            this.dGvTumRezervasyon.TabIndex = 11;
            this.dGvTumRezervasyon.VirtualMode = true;
            this.dGvTumRezervasyon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGvSecilenOdaRezervasyonlari_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::OtelOtomasyonV1.Properties.Resources._20220115_BULANIK1;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.bMusteriSil);
            this.groupBox2.Controls.Add(this.bDuzenle);
            this.groupBox2.Controls.Add(this.bMusteriEkle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tTC);
            this.groupBox2.Controls.Add(this.dTpBaslangic);
            this.groupBox2.Controls.Add(this.dTpBitis);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cOda);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(0, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 199);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni rezervasyon ekle, varolan rezervasyonu düzenle";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(421, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 120);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tüm rezervasyon listesnden seçtiğimiz rezervasyon sol taraftaki alanlara gelmekte" +
    "dir.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 27;
            this.button1.Text = "Müşteriyi göster";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bMusteriSil
            // 
            this.bMusteriSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMusteriSil.AutoSize = true;
            this.bMusteriSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bMusteriSil.BackColor = System.Drawing.Color.DarkRed;
            this.bMusteriSil.Enabled = false;
            this.bMusteriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMusteriSil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bMusteriSil.ForeColor = System.Drawing.Color.White;
            this.bMusteriSil.Location = new System.Drawing.Point(416, 161);
            this.bMusteriSil.Name = "bMusteriSil";
            this.bMusteriSil.Size = new System.Drawing.Size(163, 31);
            this.bMusteriSil.TabIndex = 27;
            this.bMusteriSil.Text = "Seçilen rezervasyonu sil";
            this.bMusteriSil.UseVisualStyleBackColor = false;
            this.bMusteriSil.Click += new System.EventHandler(this.bMusteriSil_Click);
            // 
            // bDuzenle
            // 
            this.bDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDuzenle.AutoSize = true;
            this.bDuzenle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bDuzenle.BackColor = System.Drawing.Color.RoyalBlue;
            this.bDuzenle.Enabled = false;
            this.bDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDuzenle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bDuzenle.ForeColor = System.Drawing.Color.Cornsilk;
            this.bDuzenle.Location = new System.Drawing.Point(152, 161);
            this.bDuzenle.Name = "bDuzenle";
            this.bDuzenle.Size = new System.Drawing.Size(127, 31);
            this.bDuzenle.TabIndex = 26;
            this.bDuzenle.Text = "Düzenlemeyi bitir";
            this.bDuzenle.UseVisualStyleBackColor = false;
            this.bDuzenle.Click += new System.EventHandler(this.bDuzenle_Click);
            // 
            // bMusteriEkle
            // 
            this.bMusteriEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMusteriEkle.AutoSize = true;
            this.bMusteriEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMusteriEkle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bMusteriEkle.ForeColor = System.Drawing.Color.FloralWhite;
            this.bMusteriEkle.Location = new System.Drawing.Point(286, 161);
            this.bMusteriEkle.Name = "bMusteriEkle";
            this.bMusteriEkle.Size = new System.Drawing.Size(124, 31);
            this.bMusteriEkle.TabIndex = 25;
            this.bMusteriEkle.Text = "Yeni müşteri ekle";
            this.bMusteriEkle.UseVisualStyleBackColor = false;
            this.bMusteriEkle.Click += new System.EventHandler(this.bMusteriEkle_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(75, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Müşteri TC :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tTC
            // 
            this.tTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tTC.BackColor = System.Drawing.SystemColors.Window;
            this.tTC.Location = new System.Drawing.Point(167, 126);
            this.tTC.MaxLength = 11;
            this.tTC.Name = "tTC";
            this.tTC.Size = new System.Drawing.Size(247, 26);
            this.tTC.TabIndex = 15;
            // 
            // dTpBaslangic
            // 
            this.dTpBaslangic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dTpBaslangic.Location = new System.Drawing.Point(167, 62);
            this.dTpBaslangic.Name = "dTpBaslangic";
            this.dTpBaslangic.Size = new System.Drawing.Size(247, 26);
            this.dTpBaslangic.TabIndex = 2;
            this.dTpBaslangic.ValueChanged += new System.EventHandler(this.dTpBaslangic_ValueChanged);
            // 
            // dTpBitis
            // 
            this.dTpBitis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dTpBitis.Location = new System.Drawing.Point(168, 94);
            this.dTpBitis.Name = "dTpBitis";
            this.dTpBitis.Size = new System.Drawing.Size(247, 26);
            this.dTpBitis.TabIndex = 2;
            this.dTpBitis.ValueChanged += new System.EventHandler(this.dTpBitis_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(41, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rezervasyon bitiş :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rezervasyon başlangıç :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(95, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oda seç :";
            // 
            // cOda
            // 
            this.cOda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cOda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cOda.FormattingEnabled = true;
            this.cOda.Location = new System.Drawing.Point(168, 29);
            this.cOda.Name = "cOda";
            this.cOda.Size = new System.Drawing.Size(247, 27);
            this.cOda.TabIndex = 0;
            this.cOda.SelectedIndexChanged += new System.EventHandler(this.cOda_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::OtelOtomasyonV1.Properties.Resources._20220115_BULANIK1;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.dGvSecilenOdaRezervasyonlari);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(596, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 387);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seçilen odanın rezervasyon tarihleri";
            // 
            // dGvSecilenOdaRezervasyonlari
            // 
            this.dGvSecilenOdaRezervasyonlari.AllowUserToAddRows = false;
            this.dGvSecilenOdaRezervasyonlari.AllowUserToDeleteRows = false;
            this.dGvSecilenOdaRezervasyonlari.AllowUserToResizeColumns = false;
            this.dGvSecilenOdaRezervasyonlari.AllowUserToResizeRows = false;
            this.dGvSecilenOdaRezervasyonlari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvSecilenOdaRezervasyonlari.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGvSecilenOdaRezervasyonlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvSecilenOdaRezervasyonlari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGvSecilenOdaRezervasyonlari.EnableHeadersVisualStyles = false;
            this.dGvSecilenOdaRezervasyonlari.Location = new System.Drawing.Point(3, 22);
            this.dGvSecilenOdaRezervasyonlari.Name = "dGvSecilenOdaRezervasyonlari";
            this.dGvSecilenOdaRezervasyonlari.ReadOnly = true;
            this.dGvSecilenOdaRezervasyonlari.RowHeadersVisible = false;
            this.dGvSecilenOdaRezervasyonlari.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dGvSecilenOdaRezervasyonlari.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGvSecilenOdaRezervasyonlari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvSecilenOdaRezervasyonlari.ShowCellErrors = false;
            this.dGvSecilenOdaRezervasyonlari.ShowCellToolTips = false;
            this.dGvSecilenOdaRezervasyonlari.ShowEditingIcon = false;
            this.dGvSecilenOdaRezervasyonlari.ShowRowErrors = false;
            this.dGvSecilenOdaRezervasyonlari.Size = new System.Drawing.Size(403, 362);
            this.dGvSecilenOdaRezervasyonlari.StandardTab = true;
            this.dGvSecilenOdaRezervasyonlari.TabIndex = 12;
            this.dGvSecilenOdaRezervasyonlari.VirtualMode = true;
            this.dGvSecilenOdaRezervasyonlari.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGvSecilenOdaRezervasyonlari_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = global::OtelOtomasyonV1.Properties.Resources._20220115_BULANIK1;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.dGvRezervasyonuOlanKisiler);
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(593, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 310);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bugün rezervasyonu olan kişiler";
            // 
            // dGvRezervasyonuOlanKisiler
            // 
            this.dGvRezervasyonuOlanKisiler.AllowUserToAddRows = false;
            this.dGvRezervasyonuOlanKisiler.AllowUserToDeleteRows = false;
            this.dGvRezervasyonuOlanKisiler.AllowUserToResizeColumns = false;
            this.dGvRezervasyonuOlanKisiler.AllowUserToResizeRows = false;
            this.dGvRezervasyonuOlanKisiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvRezervasyonuOlanKisiler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGvRezervasyonuOlanKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvRezervasyonuOlanKisiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGvRezervasyonuOlanKisiler.EnableHeadersVisualStyles = false;
            this.dGvRezervasyonuOlanKisiler.Location = new System.Drawing.Point(3, 22);
            this.dGvRezervasyonuOlanKisiler.Name = "dGvRezervasyonuOlanKisiler";
            this.dGvRezervasyonuOlanKisiler.ReadOnly = true;
            this.dGvRezervasyonuOlanKisiler.RowHeadersVisible = false;
            this.dGvRezervasyonuOlanKisiler.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dGvRezervasyonuOlanKisiler.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGvRezervasyonuOlanKisiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvRezervasyonuOlanKisiler.ShowCellErrors = false;
            this.dGvRezervasyonuOlanKisiler.ShowCellToolTips = false;
            this.dGvRezervasyonuOlanKisiler.ShowEditingIcon = false;
            this.dGvRezervasyonuOlanKisiler.ShowRowErrors = false;
            this.dGvRezervasyonuOlanKisiler.Size = new System.Drawing.Size(406, 285);
            this.dGvRezervasyonuOlanKisiler.StandardTab = true;
            this.dGvRezervasyonuOlanKisiler.TabIndex = 13;
            this.dGvRezervasyonuOlanKisiler.VirtualMode = true;
            this.dGvRezervasyonuOlanKisiler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGvSecilenOdaRezervasyonlari_CellClick);
            // 
            // rezervasyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = global::OtelOtomasyonV1.Properties.Resources._20220115_BULANIK1;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "rezervasyonlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rezervasyonlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rezervasyonlar_FormClosing);
            this.Load += new System.EventHandler(this.rezervasyonlar_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGvTumRezervasyon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGvSecilenOdaRezervasyonlari)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGvRezervasyonuOlanKisiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSAciklama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.DataGridView dGvTumRezervasyon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTpBaslangic;
        private System.Windows.Forms.DateTimePicker dTpBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tTC;
        public System.Windows.Forms.Button bMusteriEkle;
        public System.Windows.Forms.Button bDuzenle;
        public System.Windows.Forms.Button bMusteriSil;
        public System.Windows.Forms.ComboBox cOda;
        public System.Windows.Forms.DataGridView dGvSecilenOdaRezervasyonlari;
        public System.Windows.Forms.DataGridView dGvRezervasyonuOlanKisiler;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button button1;
    }
}