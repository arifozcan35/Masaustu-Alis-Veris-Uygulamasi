using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Collections;

namespace Veresiye_Urun_Satis_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string girisSifre;



        private void btnGirisYap_Click(object sender, EventArgs e)
        {


            //SqlBaglantisi sb = new SqlBaglantisi();

            //SqlCommand yeniSifre = new SqlCommand("SELECT * FROM TBL_SIFREMI_UNUTTUM WHERE kullanici_adi='zcanarif@gmail.com'", sb.baglanti());


            //SqlDataReader sifreOku = yeniSifre.ExecuteReader();

            ////girisSifre = sifreOku["sifre"].ToString();


            //while (sifreOku.Read())
            //{
            //    girisSifre = sifreOku["sifre"].ToString();
            //}
            //sifreOku.Close();


            //if (txtGirisKullaniciAdi.Text == "zcanarif@gmail.com" && txtGirisSifre.Text == girisSifre)
            //{
            //    Form2 fr2 = new Form2();
            //    fr2.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı adı veya şifreyi hatalı girdiniz!");
            //    txtGirisKullaniciAdi.Clear();
            //    txtGirisSifre.Clear();
            //}

            //sb.baglanti().Close();

            try
            {
                SqlBaglantisi sb = new SqlBaglantisi();

                SqlCommand yeniSifre = new SqlCommand("SELECT * FROM TBL_SIFREMI_UNUTTUM WHERE kullanici_adi='zcanarif@gmail.com'", sb.baglanti());


                SqlDataReader sifreOku = yeniSifre.ExecuteReader();

                //girisSifre = sifreOku["sifre"].ToString();


                while (sifreOku.Read())
                {
                    girisSifre = sifreOku["sifre"].ToString();
                }
                sifreOku.Close();


                if (txtGirisKullaniciAdi.Text == "zcanarif@gmail.com" && txtGirisSifre.Text == girisSifre)
                {
                    Form2 fr2 = new Form2();
                    fr2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifreyi hatalı girdiniz!");
                    txtGirisKullaniciAdi.Clear();
                    txtGirisSifre.Clear();
                }

                sb.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("E-posta adresi ve şifre girmeniz gerekmektedir!");
            }


        }
        private void lblSifremiUnuttum_Click(object sender, EventArgs e)
        {
            sifremi_unuttum su = new sifremi_unuttum();
            su.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
