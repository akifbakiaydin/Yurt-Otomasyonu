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
    public partial class FrmGıder : Form
    {
        public FrmGıder()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand komut = new SqlCommand("insert into Gıderler (Elektrik, Su , Dogalgaz, internet, Gıda, Personel, Diger) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", TxtElektirik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", Txtİnternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGıda.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Kaydedildi!");
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Başarısız Kaydedilemedi");
                throw;
            }
            
        }
    }
}
