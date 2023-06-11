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
    public partial class FrmGıderGuncelle : Form
    {
        public FrmGıderGuncelle()
        {
            InitializeComponent();
        }

        public string elektrik, su, dogalgaz, gıda, diger, internet, personel,id;


        SqlBaglantim bgl = new SqlBaglantim();

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut = new SqlCommand("update Gıderler set Elektrik=@p1, Su=@p2, Dogalgaz=@p3, internet=@p4, Gıda=@p5, Personel=@p6, Diger=@p7 where Odemeid=@p8", bgl.baglanti());

                komut.Parameters.AddWithValue("@p8", TxtGıderİd.Text);
                komut.Parameters.AddWithValue("@p1", TxtElektirik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", Txtİnternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGıda.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("BAŞARIYLA GÜNCELLENDİ.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu Tekrar Deneyin");

                throw;
            }
            
        }

        private void FrmGıderGuncelle_Load(object sender, EventArgs e)
        {
            TxtGıderİd.Text = id;
            TxtElektirik.Text = elektrik;
            TxtDogalgaz.Text = dogalgaz;
            TxtGıda.Text = gıda;
            TxtSu.Text=su;
            TxtPersonel.Text = personel;
            Txtİnternet.Text = internet;
            TxtDiger.Text = diger;
        }
    }
}
