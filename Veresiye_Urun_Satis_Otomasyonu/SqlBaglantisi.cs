using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veresiye_Urun_Satis_Otomasyonu
{
    public class SqlBaglantisi
    {
        
        public SqlConnection baglanti()
        {
        SqlConnection baglan = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\VeresiyeVeriTabani.mdf;Integrated Security=True");
        baglan.Open();
        return baglan;
        }
       
    }
}
