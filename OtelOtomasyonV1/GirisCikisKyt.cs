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
    public partial class GirisCikisKyt : Form
    {
        public GirisCikisKyt()
        {
            InitializeComponent();
        }

        private void kayitlar_Load(object sender, EventArgs e)
        {
            programAyarlari.formBasligi(this, tSAciklama);// Form başlığını yazdırdık.
        }

        private void kayitlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            programAyarlari.fmain.Show();
        }

        private void dGvGirisK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
