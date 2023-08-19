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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        public string sekreterTCno;
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = sekreterTCno;

            //Ad Soyad
            SqlCommand komut=new SqlCommand("select SekreterAdSoyad from Tbl_Sekreterler where SekreterTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları DataGride Akatarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları DataGride Akatarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select DoktorAd,DoktorSoyad from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Bransşlar comboboxının içini dolduralım:
            SqlCommand komut2 = new SqlCommand("select Branslar from Tbl_Branslar ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {     //111.Ders
            SqlCommand komut = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTC) values(@r1,@r2,@r3,@r4,@r5)", bgl.baglanti());

            komut.Parameters.AddWithValue("@r1", MskTxtTarih.Text);
            komut.Parameters.AddWithValue("@r2", MskTxtSaat.Text);
            komut.Parameters.AddWithValue("@r3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@r4", CmbDoktorlar.Text);
            komut.Parameters.AddWithValue("@r5", MskTxtTc.Text);
           
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Kaydı Yapıldı.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);    
            

        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktorlar.Items.Clear();

            SqlCommand komutbrans = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@k1 ", bgl.baglanti());
            komutbrans.Parameters.AddWithValue("@k1",CmbBrans.Text);
            SqlDataReader dr=komutbrans.ExecuteReader();
            while(dr.Read())
            {
                CmbDoktorlar.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();   
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular values(@s1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@s1", RcTxtSikayet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();
            fr.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans fr =new FrmBrans();
            fr.Show();
        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr= new FrmRandevuListesi();
            fr.Show();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr =new FrmDuyurular();
            fr.Show();
        }
    }
}
