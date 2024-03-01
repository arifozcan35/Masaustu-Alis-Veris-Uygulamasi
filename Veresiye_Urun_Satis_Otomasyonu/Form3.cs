using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Veresiye_Urun_Satis_Otomasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veresiyeUrunSatisDataSet5.TBL_VERESIYE' table. You can move, or remove it, as needed.
            this.tBL_VERESIYETableAdapter.Fill(this.veresiyeVeriTabani.TBL_VERESIYE);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tBL_VERESIYETableAdapter.Fill(this.veresiyeVeriTabani.TBL_VERESIYE);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTelefon.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtID.Text) && string.IsNullOrEmpty(txtAdSoyad.Text) && string.IsNullOrEmpty(txtMeslek.Text)) 
            {
                MessageBox.Show("ID, Ad Soyad, Telefon Numarası ve Meslek kısımlarının doldurulması zorunludur!");
            }
            else
            {
                SqlBaglantisi sb = new SqlBaglantisi();

                SqlCommand komut = new SqlCommand("INSERT INTO TBL_VERESIYE (PERID, PERADSOYAD, PERMESLEK, PERBORCDURUM, PERTELEFON) VALUES (@p0, @p1, @p2, @p3, @p4)", sb.baglanti());
                komut.Parameters.AddWithValue("@p0", txtID.Text);
                komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@p2", txtMeslek.Text);
                komut.Parameters.AddWithValue("@p3", label5.Text);
                komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
                komut.ExecuteNonQuery();
                sb.baglanti().Close();

                this.tBL_VERESIYETableAdapter.Fill(this.veresiyeVeriTabani.TBL_VERESIYE);

                MessageBox.Show("Personel Eklendi");
            }
            


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlBaglantisi sb = new SqlBaglantisi();

            SqlCommand komutSil = new SqlCommand("DELETE FROM TBL_VERESIYE WHERE PERADSOYAD=@k1", sb.baglanti());
            komutSil.Parameters.AddWithValue("@k1", txtAdSoyad.Text);
            komutSil.ExecuteNonQuery();

            sb.baglanti().Close();
            this.tBL_VERESIYETableAdapter.Fill(this.veresiyeVeriTabani.TBL_VERESIYE);

            MessageBox.Show("Kayıt Silindi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiyatGuncelle_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAdSoyad.Text))
            {
                MessageBox.Show("Güncelleme yapabilmeniz için tablodan kişi seçmeniz gerekir!");
            }
            else
            {
                SqlBaglantisi sb = new SqlBaglantisi();
                SqlCommand perguncelle = new SqlCommand("update TBL_VERESIYE set PERID=@P0, PERADSOYAD=@P1, PERMESLEK=@P2, PERTELEFON=@P3 WHERE PERID=@P4", sb.baglanti());

                perguncelle.Parameters.AddWithValue("@P0", txtID.Text);
                perguncelle.Parameters.AddWithValue("@P1", txtAdSoyad.Text);
                perguncelle.Parameters.AddWithValue("@P2", txtMeslek.Text);
                perguncelle.Parameters.AddWithValue("@P3", mskTelefon.Text);
                perguncelle.Parameters.AddWithValue("@P4", txtID.Text);

                perguncelle.ExecuteNonQuery();
                sb.baglanti().Close();
                MessageBox.Show("Personel Bilgileri Güncellendi.");
                this.tBL_VERESIYETableAdapter.Fill(this.veresiyeVeriTabani.TBL_VERESIYE);
            }


        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdSoyad.Text))
            {
                MessageBox.Show("Lütfen tablodan bir kişi seçiniz!");
            }
            else
            {
                Form5 fr5 = new Form5();
                fr5.secilenPersonel = txtAdSoyad.Text;
                fr5.Show();
                this.Hide();
            }


        }
    }
}
