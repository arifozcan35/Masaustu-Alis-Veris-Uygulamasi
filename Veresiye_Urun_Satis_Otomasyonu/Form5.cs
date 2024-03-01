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

namespace Veresiye_Urun_Satis_Otomasyonu
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public string secilenPersonel;
        public string sayi;

        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-20S2QFH\SQLEXPRESS;Initial Catalog=VeresiyeUrunSatis;Integrated Security=True");

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            //secilenPersonel = fr3.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            lblDetayAdSoyad.Text = secilenPersonel;

            SqlBaglantisi sb = new SqlBaglantisi();

            SqlCommand komut = new SqlCommand("SELECT * FROM TBL_VERESIYE WHERE PERADSOYAD=@p1", sb.baglanti());
            komut.Parameters.AddWithValue("@p1", secilenPersonel);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblDetayAdSoyad.Text = dr[1].ToString();
                lblDetayTel.Text = dr[4].ToString();
                lblDetayMeslek.Text = dr[2].ToString();
                lblDetayBorc.Text = ((Int32)(Convert.ToInt32(dr[3])*95/100)).ToString() + " TL";
                //lblDetayBorc.Text = ((Convert.ToInt32(dr[3])  - (Int32)(Convert.ToInt32(dr[3])*(5.0/100))).ToString());

            }
            sb.baglanti().Close();
        }
    }
}
