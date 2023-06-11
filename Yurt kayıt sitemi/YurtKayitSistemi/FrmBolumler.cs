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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl= new SqlBaglantim();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler);

        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {
            try //Veri tabanına yeni bölüm ekleme komutları eğer varsa try catch kullandık
            {
                
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut1.ExecuteNonQuery(); //degisiklikleri kaydediyor burası
                bgl.baglanti().Close();
                MessageBox.Show("BÖLÜM EKLENDİ");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler); //bölümleri listelemesi için
            }
            catch 
            {
                MessageBox.Show("HATA OLUŞTU YENİDEN DENEYİNİZ");
            }

        }

        private void PcbBolumSil_Click(object sender, EventArgs e)
        {
            try //Veri tabanı ve uygulamadan bölüm silmeyi gerçekleştiriyor
            {
                
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where BolumID=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtBolumİd.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("SİLME İŞLEMİ GERÇEKLEŞTİRİLDİ");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler); //sildikten sonra listelemek için


            }
            catch 
            {
                MessageBox.Show("HATA İŞLEM GERÇEKLEŞMEDİ");
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //hücreye tıklandığında üstteki alana yazma
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); //seçilen satırdaki hücred
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            TxtBolumİd.Text = id;
            TxtBolumAd.Text = bolumad;

        }

        private void PcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("update Bolumler Set BolumAd=@p1 where BolumID=@p2", bgl.baglanti()); //database de güncellenecek yeri belirttik yer ve neyi guncelleyeceğini
                komut2.Parameters.AddWithValue("@p2", TxtBolumİd.Text); //databasedeki hangi parametrelerin hangi txtboxa yazılacağını yazdık
                komut2.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı !");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler); //guncelleden sonra  anında listelemek için
            }
            catch 
            {
                MessageBox.Show("Hata");
            }


        }
    }
}
