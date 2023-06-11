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

namespace YurtKayitSistemi
{
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet2.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen; // hücrede tıkladığımızı textboxlara yazdırıcaz
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TxtAd.Text = ad;
            TxtSoyad.Text = soyad;
            TxtOgrid.Text = id;
            TxtKalan.Text = kalan;

            
        }

        private void BtnOdemeAl_Click(object sender, EventArgs e)
        {
            //Odenen tutari kalan tutardan düsme islemi
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtKalan.Text);
            yeniborc = kalan - odenen;
            TxtKalan.Text = yeniborc.ToString();

            //yeni tutarı veritabanına güncelleme
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where Ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtOgrid.Text);
            komut.Parameters.AddWithValue("@p1", TxtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.borclarTableAdapter.Fill(this.yurtOtomasyonDataSet2.Borclar);
            MessageBox.Show("Borç Ödendi !");

            //Kasa Tablosuna Ekleme Yapma
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy, OdemeMıktar) values (@k1, @k2) ", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", TxtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();



        }

        private void TxtAd_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
