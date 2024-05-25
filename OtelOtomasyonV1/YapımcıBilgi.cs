using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonV1
{
    public partial class YapımcıBilgi : Form
    {
        public YapımcıBilgi()
        {
            InitializeComponent();
        }

        private void surumNotlari_Load(object sender, EventArgs e)
        {
            programAyarlari.formBasligi(this, tSAciklama);// Form başlığını yazdırdık.
            label1.Text = "\nProgram adı : " + programAyarlari.pAdi  + "\nYapımcısı : " + programAyarlari.pYapimci + "\nYapımcısı Telefon : " + programAyarlari.pYapimciTel  +"\n\nYenilikler : " + programAyarlari.pYenilikler;
        }

        private void surumNotlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            programAyarlari.fmain.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
