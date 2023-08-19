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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr =new FrmDoktorBilgiDuzenle();
            fr.Doktortcno = LblTc.Text;  //Doktor Bilgi Düzenleme Formuna veri taşıma.
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr =new FrmDuyurular();
            fr.Show();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        public string DoktorTc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = DoktorTc;

            //*Doktor Ad SOyadını çekelim:
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTC=@t1", bgl.baglanti());
            komut.Parameters.AddWithValue("@t1", LblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();   
            while(dr.Read())
            {
                LblAdSoyad.Text = dr[0]+ " " + dr[1];
            }

            bgl.baglanti().Close();

            //Randevu listesi  **** where şartını datatable içinde kullanalım.****
            DataTable dt=new DataTable();
            SqlDataAdapter da =new SqlDataAdapter("select*from Tbl_Randevular where RandevuDoktor='"+LblAdSoyad.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

          
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RcTxtSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
