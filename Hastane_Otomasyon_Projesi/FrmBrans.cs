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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //Tbl_Branslar Sql Tablomuza insert işlemi ile Branş Ekleyelim:
            SqlCommand komut=new SqlCommand("insert into Tbl_Branslar (Branslar) values(@p1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void FrmBrans_Load(object sender, EventArgs e)
        {
            //Branş formundaki dataGridView e Tbl_Branslar Tablosundan veri çekelim:
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut  = new SqlCommand("delete from Tbl_Branslar where Bransid=@b1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", TxtBransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close(); 
            MessageBox.Show(TxtBransAd.Text + " Branşı Silindi" ,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtBransid.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtBransAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();   
                
        }
    }
}
