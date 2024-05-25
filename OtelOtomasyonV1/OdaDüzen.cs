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
    public partial class OdaDüzen : Form
    {
        public OdaDüzen()
        {
            InitializeComponent();
        }

        private void odaAyarlari_Load(object sender, EventArgs e)
        {
            comboBox_katNumarasi.SelectedIndex = comboBox_yatakSayisi.SelectedIndex = comboBox_genisYatakSayisi.SelectedIndex = 0;
            programAyarlari.formBasligi(this, tSAciklama);
        }

        private void odaAyarlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            comboBox_katNumarasi.SelectedIndex = comboBox_yatakSayisi.SelectedIndex = comboBox_genisYatakSayisi.SelectedIndex = 0;
            tOda.Text = tOdaFiyati.Text = "";
            checkBox_suit.Checked = checkBox_klima.Checked = checkBox_televizyon.Checked = checkBox_temiz.Checked = checkBox_kapali.Checked = false;
            e.Cancel = true;
            this.Hide();
            programAyarlari.fmain.Show();
        }

        private void dGvOdaAyarlari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tOda.Text = dGvOdaAyarlari.SelectedRows[0].Cells[0].Value.ToString();
                comboBox_katNumarasi.Text = dGvOdaAyarlari.SelectedRows[0].Cells[1].Value.ToString();
                comboBox_yatakSayisi.Text = dGvOdaAyarlari.SelectedRows[0].Cells[2].Value.ToString();
                comboBox_genisYatakSayisi.Text = dGvOdaAyarlari.SelectedRows[0].Cells[3].Value.ToString();
                checkBox_suit.Checked = Convert.ToBoolean(dGvOdaAyarlari.SelectedRows[0].Cells[4].Value);
                checkBox_klima.Checked = Convert.ToBoolean(dGvOdaAyarlari.SelectedRows[0].Cells[5].Value);
                checkBox_televizyon.Checked = Convert.ToBoolean(dGvOdaAyarlari.SelectedRows[0].Cells[6].Value);
                checkBox_temiz.Checked = Convert.ToBoolean(dGvOdaAyarlari.SelectedRows[0].Cells[7].Value);
                checkBox_kapali.Checked = Convert.ToBoolean(dGvOdaAyarlari.SelectedRows[0].Cells[8].Value);
                tOdaFiyati.Text = dGvOdaAyarlari.SelectedRows[0].Cells[9].Value.ToString();
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                islemler.veriEkle("ODA", "O_NU,O_KAT_NU,O_YATAK_SAYISI,O_GENIS_YATAK_SAYISI,O_SUIT,O_KLIMA,O_TELEVIZYON,O_TEMIZ,O_KAPALI,O_FIYATI", tOda.Text + "," + comboBox_katNumarasi.Text + "," + comboBox_yatakSayisi.Text + "," + comboBox_genisYatakSayisi.Text + "," + checkBox_suit.Checked + "," + checkBox_klima.Checked + "," + checkBox_televizyon.Checked + "," + checkBox_temiz.Checked + "," + checkBox_kapali.Checked + "," + tOdaFiyati.Text);
                programAyarlari.tabloDoldur("ODA", programAyarlari.fodaAyarlari.dGvOdaAyarlari);
            }
            catch (Exception)
            {
                MessageBox.Show("Aynı oda ismi adı mevcut veya bu oda şuan eklenememektedir.\nLütfen daha sonra tekrar deneyiniz.", "Bir hatayla karşılaşıldı.");
            }
        }

        private void bDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                islemler.varsaKosulluVeriGuncelle("ODA", "O_NU = " + tOda.Text + ",O_KAT_NU = " + comboBox_katNumarasi.Text + ",O_YATAK_SAYISI = " + comboBox_yatakSayisi.Text + ",O_GENIS_YATAK_SAYISI = " + comboBox_genisYatakSayisi.Text + ",O_SUIT = " + checkBox_suit.Checked + ",O_KLIMA = " + checkBox_klima.Checked + ",O_TELEVIZYON = " + checkBox_televizyon.Checked + ",O_TEMIZ = " + checkBox_temiz.Checked + ",O_KAPALI = " + checkBox_kapali.Checked + ",O_FIYATI = " + tOdaFiyati.Text, "O_NU = " + tOda.Text);
                programAyarlari.tabloDoldur("ODA", programAyarlari.fodaAyarlari.dGvOdaAyarlari);
            }
            catch (Exception)
            {
                MessageBox.Show("Aynı oda ismi adı mevcut veya bu oda şuan eklenememektedir.\nLütfen daha sonra tekrar deneyiniz.", "Bir hatayla karşılaşıldı.");
            }
        }
    }
}
