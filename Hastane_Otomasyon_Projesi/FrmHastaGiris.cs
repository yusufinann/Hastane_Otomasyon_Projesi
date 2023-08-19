using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Hastane_Otomasyon_Projesi
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTxtTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = MskTxtTc.Text; //***Hasta Detay Formunda Tc alanına belirlemiş olduğm tc değişkeni ile Sql tc sini yazdırdık.***
                fr.Show();            // yani formlar arası veri taşıma yaptık
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC && Şİfre");
            }
            bgl.baglanti().Close(); 
        }

        private void LnkUyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr =new FrmHastaKayit();
            fr.Show();  
            
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
 