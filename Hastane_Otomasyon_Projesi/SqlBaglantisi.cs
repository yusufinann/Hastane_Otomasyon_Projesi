using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Hastane_Otomasyon_Projesi
{
    internal class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
         
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-M1F4IS3\\SQLEXPRESS01;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
