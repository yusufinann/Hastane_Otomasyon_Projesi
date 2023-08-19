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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;//veri taşıma işlemi için.
        
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            //**** TC yazdırma ****
            LblTc.Text = tc ;

            //**** Ad Soyad çekme ****
            SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text);//parametre1 tc den gelen değer.Yani LblTc de yazan değere eşit olan ad soyadı getircek.
            SqlDataReader dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //**** Randevu Geçmişi ****
            DataTable dt =new DataTable(); //Sanal bir veri tablosu oluşturduk.
            //DataAdapter benim DataGridView e verileri aktarmak için kullandığım Commandım.
            SqlDataAdapter da = new SqlDataAdapter("select*from Tbl_Randevular where HastaTC='"+LblTc.Text+"'", bgl.baglanti());
            da.Fill(dt);//DataAdapterın içini tablodan gelecek olan değerle doldur.
            dataGridView1.DataSource = dt; //DataGridView'in veri kaynağı = dt den gelen tablo.

            //**** Branşları Çekme ****
            SqlCommand komut2 = new SqlCommand("select Branslar from Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
          

        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();  //A'dan Z'ye C# 108.Ders  Branşa göre combobax'a doktorları ekleyelim:
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@k1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@k1", CmbBrans.Text);
            SqlDataReader dr3= komut3.ExecuteReader();  
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Önemli***   Aktif Randevular bölümündeki hastanın alabilceği randevu durumları görüntülenecek
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from Tbl_Randevular where RandevuBrans='" + CmbBrans.Text + "'"+"and RandevuDoktor='"+CmbDoktor.Text+"' and RandevuDurum=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle frm=new FrmHastaBilgiDuzenle();
            frm.TCno = LblTc.Text;
            frm.Show();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            //Hasta Randevu id sine göre uygun bulunan randevuyu alacak
            SqlCommand komut =new SqlCommand("update Tbl_Randevular set RandevuDurum=1 ,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTc.Text);    
            komut.Parameters.AddWithValue("@p2",RcTxtSikayet.Text); 
            komut.Parameters.AddWithValue("@p3",TxtRandevuid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Randevu alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Herhamgi bir hücreye basınca Randevu id yi textboxa atsın.
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtRandevuid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        

        }
    }
}
