using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veriT;

namespace OtelOtomasyonV1
{
    public partial class ProgramAyar : Form
    {
        public ProgramAyar()
        {
            InitializeComponent();
        }

        private void ayarlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            programAyarlari.fmain.Show();
            e.Cancel = true;
        }

        private void ayarlar_Load(object sender, EventArgs e)
        {
            programAyarlari.formBasligi(this, tSAciklama);// Form başlığını yazdırdık.
        }

        private void bArkaPlan_Click(object sender, EventArgs e)
        {
           colorDialog1.ShowDialog();
        }

        private void bSifirla_Click(object sender, EventArgs e)
        {
            tPAdi.Text = "Otel Takip Programı";
            tSurumu.Text = "S1";
            tYapimci.Text = "Fatih Ömer";
            tTel.Text = "05372921615";
           
        }

        private void bAyarlariUygula_Click(object sender, EventArgs e)
        {           
            programAyarlari.pAdi = tPAdi.Text;
            programAyarlari.pSurumu = tSurumu.Text;
            programAyarlari.pYapimci = tYapimci.Text;
            programAyarlari.pYapimciTel = tTel.Text;
           

            MessageBox.Show("Ayarlar güncellendi. Güncelleme başarılı.", "Ayarlar değişti.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void bGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            programAyarlari.fmain.Show();
        }
    }
}
