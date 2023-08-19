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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl =new SqlBaglantisi();
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d4,DoktorSifre=@d5 where DoktorTC=@d3", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", MskTxtTc.Text);
            komut.Parameters.AddWithValue("@d4", CmbBrans.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string Doktortcno;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTxtTc.Text=Doktortcno;
            //**** Branşları branş comboboxına Çekme ****
            SqlCommand komut = new SqlCommand("select Branslar from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbBrans.Items.Add(dr[0]);
            }

            
            SqlCommand komut2 = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC=@k1 ", bgl.baglanti()); 
            komut2.Parameters.AddWithValue("@k1", MskTxtTc.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                TxtAd.Text = dr2[1].ToString();
                TxtSoyad.Text = dr2[2].ToString();
                CmbBrans.Text = dr2[3].ToString();
            //    MskTxtTc.Text = dr2[4].ToString();
                TxtSifre.Text = dr2[5].ToString();   
            }

          
            bgl.baglanti().Close();
            


        }
    }
}
