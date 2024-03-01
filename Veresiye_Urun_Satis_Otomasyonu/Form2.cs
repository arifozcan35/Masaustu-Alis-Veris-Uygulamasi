using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;

namespace Veresiye_Urun_Satis_Otomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string isim;

        public int toplam;
        int veriTabaniToplam;

        ArrayList fiyatlar = new ArrayList();


        private void Form2_Load(object sender, EventArgs e)
        {
            txtCay.Text = "0";
            txtPogacaSimit.Text = "0";
            txtKahve.Text = "0";
            txtOyuncak.Text = "0";
            txtCikolata.Text = "0";
            txtTost.Text = "0";
            txtSu.Text = "0";



            // comboboxa sqlden kişileri çekme
            SqlBaglantisi sb = new SqlBaglantisi();

            SqlCommand komut = new SqlCommand("SELECT * FROM TBL_VERESIYE", sb.baglanti());

            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                cmbKisi.Items.Add(oku["PERADSOYAD"]);
            }
            sb.baglanti().Close();



            // fiyat listesine sqlden fiyat çekme

            SqlCommand komut2 = new SqlCommand("SELECT * FROM TBL_VERESİYE_FİYAT", sb.baglanti());


            SqlDataReader oku2 = komut2.ExecuteReader();

            

            while (oku2.Read())
            {
                // dizi global alanda tanımlandı
                fiyatlar.Add(oku2["FIYAT"]);
            }

            lblCay.Text = fiyatlar[0].ToString();
            lblPogacaSimit.Text = fiyatlar[1].ToString();
            lblKahve.Text = fiyatlar[2].ToString();
            lblOyuncak.Text = fiyatlar[3].ToString();
            lblCikolata.Text = fiyatlar[4].ToString();
            lblTost.Text = fiyatlar[5].ToString();
            lblSu.Text = fiyatlar[6].ToString();

            sb.baglanti().Close();


        }

        private void btnArtis_Click(object sender, EventArgs e)
        {


            // + butonu 

            //if(string.IsNullOrEmpty(cmbKisi.Text)) 

            //    { 
            //        MessageBox.Show("Kişi seçmediniz!");
            //    }
            //else
            //    {

            //        SqlBaglantisi sb = new SqlBaglantisi();

            //        SqlCommand komutArtır = new SqlCommand("SELECT PERBORCDURUM FROM TBL_VERESIYE WHERE PERADSOYAD=@P1", sb.baglanti());

            //        komutArtır.Parameters.AddWithValue("@P1", cmbKisi.Text);
            //        SqlDataReader rd = komutArtır.ExecuteReader();

            //        while (rd.Read())
            //        {
            //            lblOncekiBorc.Text = rd[0].ToString();
            //        }

            //        int artisMiktari = Convert.ToInt32(txtArtisMiktar.Text);

            //        veriTabaniToplam = Convert.ToInt32(lblOncekiBorc.Text);
            //        int anaToplam = artisMiktari + veriTabaniToplam;

            //        rd.Close();

            //        updateToplam(anaToplam, cmbKisi.Text);

            //        sb.baglanti().Close();
            //    }

            try
            {
                SqlBaglantisi sb = new SqlBaglantisi();

                SqlCommand komutArtır = new SqlCommand("SELECT PERBORCDURUM FROM TBL_VERESIYE WHERE PERADSOYAD=@P1", sb.baglanti());

                komutArtır.Parameters.AddWithValue("@P1", cmbKisi.Text);
                SqlDataReader rd = komutArtır.ExecuteReader();

                while (rd.Read())
                {
                    lblOncekiBorc.Text = rd[0].ToString();
                }

                int artisMiktari = Convert.ToInt32(txtArtisMiktar.Text);

                veriTabaniToplam = Convert.ToInt32(lblOncekiBorc.Text);
                int anaToplam = artisMiktari + veriTabaniToplam;

                rd.Close();

                updateToplam(anaToplam, cmbKisi.Text);

                sb.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Kişi seçmediniz veya miktar girmediniz!");
            }
        }

        private void btnAzalis_Click(object sender, EventArgs e)
        {


            // - butonu

            //if (string.IsNullOrEmpty(cmbKisi.Text))

            //    {
            //        MessageBox.Show("Kişi seçmediniz!");
            //    }
            //else 
            //    { 

            //        SqlBaglantisi sb = new SqlBaglantisi();
            //        SqlCommand komutAzalt = new SqlCommand("SELECT PERBORCDURUM FROM TBL_VERESIYE WHERE PERADSOYAD=@P1", sb.baglanti());

            //        komutAzalt.Parameters.AddWithValue("@P1", cmbKisi.Text);
            //        SqlDataReader rd = komutAzalt.ExecuteReader();

            //        while (rd.Read())

            //        {
            //            lblOncekiBorc.Text = rd[0].ToString();
            //        }

            //        int azalisFiyati = Convert.ToInt32(txtAzalisMiktar.Text);

            //        veriTabaniToplam = Convert.ToInt32(lblOncekiBorc.Text);

            //        int anaToplam1 = Math.Abs(azalisFiyati - veriTabaniToplam);

            //        rd.Close();

            //        updateToplam(anaToplam1, cmbKisi.Text);

            //        sb.baglanti().Close();
            //    }

            try
            {
                SqlBaglantisi sb = new SqlBaglantisi();
                SqlCommand komutAzalt = new SqlCommand("SELECT PERBORCDURUM FROM TBL_VERESIYE WHERE PERADSOYAD=@P1", sb.baglanti());

                komutAzalt.Parameters.AddWithValue("@P1", cmbKisi.Text);
                SqlDataReader rd = komutAzalt.ExecuteReader();

                while (rd.Read())

                {
                    lblOncekiBorc.Text = rd[0].ToString();
                }

                int azalisFiyati = Convert.ToInt32(txtAzalisMiktar.Text);

                veriTabaniToplam = Convert.ToInt32(lblOncekiBorc.Text);

                int anaToplam1 = Math.Abs(azalisFiyati - veriTabaniToplam);

                rd.Close();

                updateToplam(anaToplam1, cmbKisi.Text);

                sb.baglanti().Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Kişi seçmediniz veya miktar girmediniz!");

            }


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtCay.Text = "0";
            txtPogacaSimit.Text = "0";
            txtKahve.Text = "0";
            txtOyuncak.Text = "0";
            txtCikolata.Text = "0";
            txtTost.Text = "0";
            txtSu.Text = "0";

            txtArtisMiktar.Text = "";

            txtCay.Focus();
        }
        public void updateToplam(int anatoplam,String a)

        {
            Form3 form=new Form3();

            SqlBaglantisi sb = new SqlBaglantisi();

            SqlCommand komutUpdate = new SqlCommand("UPDATE TBL_VERESIYE SET PERBORCDURUM=@P1 WHERE PERADSOYAD=@P2", sb.baglanti());
            
            komutUpdate.Parameters.AddWithValue("@P1",anatoplam);
            komutUpdate.Parameters.AddWithValue("@P2", a);


            komutUpdate.ExecuteNonQuery();
            sb.baglanti().Close();
        }

        private void btnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            this.Hide();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // veritabanından gelen fiyat bilgisi ile ürün miktarını çarparak toplam değeri buluyor

            int toplam2 = 0;
                toplam2 += Convert.ToInt32(fiyatlar[0]) * Convert.ToInt32(txtCay.Text);
                toplam2 += Convert.ToInt32(fiyatlar[1]) * Convert.ToInt32(txtPogacaSimit.Text);
                toplam2 += Convert.ToInt32(fiyatlar[2]) * Convert.ToInt32(txtKahve.Text);
                toplam2 += Convert.ToInt32(fiyatlar[3]) * Convert.ToInt32(txtOyuncak.Text);
                toplam2 += Convert.ToInt32(fiyatlar[4]) * Convert.ToInt32(txtCikolata.Text);
                toplam2 += Convert.ToInt32(fiyatlar[5]) * Convert.ToInt32(txtTost.Text);
                toplam2 += Convert.ToInt32(fiyatlar[6]) * Convert.ToInt32(txtSu.Text);
            
            txtArtisMiktar.Text = toplam2.ToString();
        }

    }


    //public class SqlBaglantisi
    //{
    //    public SqlConnection baglanti()
    //    {
    //        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-20S2QFH\SQLEXPRESS;Initial Catalog=VeresiyeUrunSatis;Integrated Security=True");
    //        baglan.Open();
    //        return baglan;
    //    }
    //}
}



