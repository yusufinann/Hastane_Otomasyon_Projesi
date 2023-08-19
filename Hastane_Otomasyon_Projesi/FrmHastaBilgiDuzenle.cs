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
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }

        
        public string TCno; //108.Ders
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmHastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTxtTc.Text= TCno;  //Önce dışardan public string olarak tanımladığımız TCno ile Formlar arası veri taşıma yaptık
          
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTxtTc.Text);//parametre1 tc den gelen değer.Yani LblTc de yazan değere eşit olan ad soyadı getircek.
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTxtTelefon.Text = dr[4].ToString(); ;
                TxtSifre.Text = dr[5].ToString();
                CmbCinsiyet.Text = dr[6].ToString(); ;
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti() );
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", MskTxtTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", MskTxtTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Gerçekleşmiştir. " , "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
