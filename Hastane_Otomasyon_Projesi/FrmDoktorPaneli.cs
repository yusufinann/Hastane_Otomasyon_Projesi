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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hastane_Otomasyon_Projesi
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();  
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            //Doktor Panelindeki DataGridView e Doktorları çekelim:
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Branş Comboboxının içini dolduralım.Form yüklendiğinde içi dolu gelsin:
            SqlCommand komut = new SqlCommand("select Branslar from Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbBrans.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
           // Doktor Ekleme İşlemi:
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", MskTxtTc.Text);
            komut.Parameters.AddWithValue("@p5", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Doktor Eklendi " , "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Doktor panelinde dataGridView in CellDoubleClick özelliğini kullanalım:
            int secilen = dataGridView1.SelectedCells[0].RowIndex;  
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTxtTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();   



        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Doktor Silme İşlemi:
            SqlCommand komut=new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti()); 
            komut.Parameters.AddWithValue("@p1",MskTxtTc.Text); 
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor silme işlemi gerçekleşti.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Doktor Güncelleme İşlemi:
            SqlCommand komut = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@k1,DoktorSoyad=@k2,DoktorBrans=@k3,DoktorSifre=@k4 where DoktorTC=@k5", bgl.baglanti());
            komut.Parameters.AddWithValue("@k5", MskTxtTc.Text);
            komut.Parameters.AddWithValue("@k1", TxtAd.Text);
            komut.Parameters.AddWithValue("@k2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@k3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@k4", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor güncelelme işlemi gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
