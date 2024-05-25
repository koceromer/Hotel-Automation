namespace OtelOtomasyonV1
{
    partial class OdaSimge
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lBos = new System.Windows.Forms.Label();
            this.lDolu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lToplam = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.lDoluluk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dolu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(296, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Boş";
            // 
            // lBos
            // 
            this.lBos.AutoSize = true;
            this.lBos.BackColor = System.Drawing.Color.Green;
            this.lBos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBos.Location = new System.Drawing.Point(262, 32);
            this.lBos.Name = "lBos";
            this.lBos.Size = new System.Drawing.Size(42, 32);
            this.lBos.TabIndex = 3;
            this.lBos.Text = "XX";
            this.lBos.Click += new System.EventHandler(this.lBos_Click);
            // 
            // lDolu
            // 
            this.lDolu.AutoSize = true;
            this.lDolu.BackColor = System.Drawing.Color.Red;
            this.lDolu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lDolu.Location = new System.Drawing.Point(12, 32);
            this.lDolu.Name = "lDolu";
            this.lDolu.Size = new System.Drawing.Size(42, 32);
            this.lDolu.TabIndex = 4;
            this.lDolu.Text = "XX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(172, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oda";
            // 
            // lToplam
            // 
            this.lToplam.AutoSize = true;
            this.lToplam.BackColor = System.Drawing.SystemColors.WindowText;
            this.lToplam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lToplam.Location = new System.Drawing.Point(136, 32);
            this.lToplam.Name = "lToplam";
            this.lToplam.Size = new System.Drawing.Size(42, 32);
            this.lToplam.TabIndex = 6;
            this.lToplam.Text = "XX";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(350, 29);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Value = 50;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 89);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "seriler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(350, 182);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(94, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Doluluk oranı :";
            // 
            // lDoluluk
            // 
            this.lDoluluk.AutoSize = true;
            this.lDoluluk.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lDoluluk.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lDoluluk.Location = new System.Drawing.Point(204, 65);
            this.lDoluluk.Name = "lDoluluk";
            this.lDoluluk.Size = new System.Drawing.Size(56, 27);
            this.lDoluluk.TabIndex = 9;
            this.lDoluluk.Text = "%10";
            // 
            // OdaSimge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.lDoluluk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lBos);
            this.Controls.Add(this.lToplam);
            this.Controls.Add(this.lDolu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "OdaSimge";
            this.Opacity = 0.9D;
            this.Text = "dolulukOrani";
            this.Load += new System.EventHandler(this.miniOda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lBos;
        public System.Windows.Forms.Label lDolu;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lToplam;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lDoluluk;

    }
}