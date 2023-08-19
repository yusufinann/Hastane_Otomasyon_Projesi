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

namespace Hastane_Otomasyon_Projesi
{
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlBaglantisi bgl =new SqlBaglantisi();
        public string tc;
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            //**** Randevu Listesi ****
            DataTable dt = new DataTable(); //Sanal bir veri tablosu oluşturduk.

            //DataAdapter benim DataGridView e verileri aktarmak için kullandığım Commandım.
            SqlDataAdapter da = new SqlDataAdapter("select*from Tbl_Randevular", bgl.baglanti());
            da.Fill(dt);//DataAdapterın içini tablodan gelecek olan değerle doldur.
            dataGridView1.DataSource = dt; //DataGridView'in veri kaynağı = dt den gelen tablo.


        }
    }
}
