using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using veriT;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;

namespace OtelOtomasyonV1
{
    public partial class SifremiUnuttum : Form
    {
        


        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp-mail.outlook.com";
            sc.EnableSsl = true;

            sc.Credentials = new NetworkCredential("fatih_sultan_41@hotmail.com", "41_izmit");

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("fatih_sultan_41@hotmail.com", "Ekranda Görünecek İsim");

            mail.To.Add("alici1@mail.com");
            mail.To.Add("alici2@mail.com");

            mail.CC.Add("alici3@mail.com");
            mail.CC.Add("alici4@mail.com");

            mail.Subject = "E-Posta Konusu"; mail.IsBodyHtml = true; mail.Body = "E-Posta İçeriği";

           

            sc.Send(mail);

        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            programAyarlari.fgiris.Show();
            this.Hide();
            
        }
    }
}
