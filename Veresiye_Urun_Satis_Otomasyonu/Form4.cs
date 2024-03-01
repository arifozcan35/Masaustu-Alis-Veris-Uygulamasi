using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veresiye_Urun_Satis_Otomasyonu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void btnFiyatGuncelle_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(cmbUrunler.Text))
            //{
            //    MessageBox.Show("Lütfen fiyatını değiştirmek istediğiniz ürünü seçiniz!");
            //}
            //else 
            //{ 
            //    SqlBaglantisi sb = new SqlBaglantisi();

            //    int urunFiyat = Convert.ToInt32(txtYeniFiyat.Text);

            //    guncelle(urunFiyat, cmbUrunler.Text);


            //    sb.baglanti().Close();

            //}

            try
            {
                SqlBaglantisi sb = new SqlBaglantisi();

                int urunFiyat = Convert.ToInt32(txtYeniFiyat.Text);

                guncelle(urunFiyat, cmbUrunler.Text);


                sb.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün seçmediniz veya fiyat girmediniz!");

            }

        }
        public void guncelle(int fiyat , string isim)
        {

            SqlBaglantisi sb = new SqlBaglantisi();

            SqlCommand komut4 = new SqlCommand("UPDATE TBL_VERESİYE_FİYAT SET FIYAT=@P1 WHERE URUN=@P2", sb.baglanti());

            komut4.Parameters.AddWithValue("@P1", fiyat);
            komut4.Parameters.AddWithValue("@P2", isim);


            komut4.ExecuteNonQuery();
            sb.baglanti().Close();
            MessageBox.Show("Fiyat Güncellendi.");

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlBaglantisi sb = new SqlBaglantisi();
            SqlCommand urunKomut = new SqlCommand("SELECT * FROM TBL_VERESİYE_FİYAT", sb.baglanti());
            SqlDataReader urunOku = urunKomut.ExecuteReader();
            cmbUrunler.DataSource = null;
            while (urunOku.Read())
            {
                cmbUrunler.Items.Add(urunOku["URUN"]);
            }
            sb.baglanti().Close();




            // TODO: This line of code loads data into the 'veresiyeUrunSatisDataSet.TBL_VERESİYE_FİYAT' table. You can move, or remove it, as needed.
            this.tBL_VERESİYE_FİYATTableAdapter.Fill(this.VeresiyeVeriTabaniDataSet.TBL_VERESİYE_FİYAT);

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            this.Hide();
        }
    }
}
