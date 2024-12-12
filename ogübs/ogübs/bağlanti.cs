using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ogübs
{
    public class bağlanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-LN04JT2\\SQLEXPRESS;Initial Catalog=ogrenci_bilgi_sistemi;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
