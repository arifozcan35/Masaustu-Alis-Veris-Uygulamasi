using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veresiye_Urun_Satis_Otomasyonu
{
    public partial class sifremi_unuttum : Form
    {
        public sifremi_unuttum()
        {
            InitializeComponent();
        }

        string rastgeleKod;
        public static string to;

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-20S2QFH\\SQLEXPRESS;Initial Catalog=VeresiyeUrunSatis;Integrated Security=True");

        private void sifremi_unuttum_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string from, sifre, mailMesajı;
            Random rnd = new Random();
            rastgeleKod = (rnd.Next(999999)).ToString();
            MailMessage message= new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "zcanarif@gmail.com";
            // sifre = "arif23";
            sifre = "crrwjzassscuxwfj";
            mailMesajı = "Doğrulama şifreniz : " + rastgeleKod;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mailMesajı;
            message.Subject = "Şifre Yenileme";
            SmtpClient smtp= new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port= 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, sifre);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Doğrulama Kodu Gönderildi");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            if(rastgeleKod == (txtDogrulama.Text).ToString()) 
            {
                to = txtEmail.Text;
                Form1 fr1 = new Form1();
                fr1.Show();
                this.Hide();

                baglanti.Open();
                SqlCommand sifreYenileme = new SqlCommand("UPDATE TBL_SIFREMI_UNUTTUM SET sifre=@p1", baglanti);
                //SqlCommand sifreYenileme = new SqlCommand("UPDATE[dbo].[TBL_SIFREMI_UNUTTUM] SET[kullanici_adi] = '\"+rasgeleSayi+\"' WHERE kullanici_adi = '\"+zcanarif@gmail.com+\"'", baglanti);
                //UPDATE[dbo].[TBL_SIFREMI_UNUTTUM] SET[kullanici_adi] = '"+rasgeleSayi+"' WHERE kullanici_adi = '"++"'

                sifreYenileme.Parameters.AddWithValue("@p1", rastgeleKod);
                sifreYenileme.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Şifre Başarıyla Değiştirildi");


            }
            else
            {
                MessageBox.Show("Yanlış Kod!");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }
    }
}
