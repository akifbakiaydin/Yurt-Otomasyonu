﻿using System;
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
    public partial class FrmGelirİstatistik : Form
    {
        public FrmGelirİstatistik()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmGelirİstatistik_Load(object sender, EventArgs e)
        {
            //kasadsaki toplam tutar
            SqlCommand komut = new SqlCommand("Select Sum(OdemeMıktar) from Kasa",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                LblPara.Text = oku[0].ToString() + "TL";
            }
            bgl.baglanti().Close();

            // tekrarsız olarak ayları listeleme
            SqlCommand komut2 = new SqlCommand("Select distinct(OdemeAy) from Kasa",bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbAy.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            // Grafiklere veritabından veri çekme ÖNEMLİ!!!!!!!!!!!!!!!!!!!!111
            SqlCommand komut3 = new SqlCommand("select OdemeAy,sum (OdemeMıktar) from kasa group by OdemeAy", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while(oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3 [0],oku3[1]);  //X PARAMETRE AY Y PARAMETRE sütün
            }
            bgl.baglanti().Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" Select sum (OdemeMıktar) from Kasa where OdemeAy=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbAy.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblAyKazanc.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();

        }
    }
}
