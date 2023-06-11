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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }

        public string id, ad, soyad, tc, telefon, dogum, bolum;

        private void button1_Click(object sender, EventArgs e)
        {
            
             //ögrenci silme 
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where Ogrid=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", TxtOgrid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");

            // odanın aktif öğrenci sayısını azaltma


            SqlCommand komutoda = new SqlCommand("update  Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Ogrenci set Ograd=@p2, OgrSoyad=@p3, OgrTC=@p4, OgrTelefon=@p5, OgrDogum=@p6, OgrBolum=@p7, OgrMail=@p8, OgrOdaNo=@p9 , OgrVeliAdSoyad=@p10, OgrVeliTelefon=@p11, OgrVeliAdres=@p12 where Ogrid=@p1", bgl.baglanti());


            try
            {
                komut.Parameters.AddWithValue("@p1", TxtOgrid.Text);
                komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text); //hangi bilginin hangi textboxa gireceğini p1 falan gösterdik values değerleri ile
                komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskTC.Text);
                komut.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", MskDogum.Text);
                komut.Parameters.AddWithValue("@p7", CmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", TxtMail.Text);
                komut.Parameters.AddWithValue("@p9", CmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", MskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", RchAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Güncellendi !");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata tekrar deneyiniz ! ");
                throw;
            }
           
        }

        public string mail, odano, veliad, velitel, adres;


        SqlBaglantim bgl = new SqlBaglantim();


        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            TxtOgrid.Text = id;
            TxtOgrDuzenleAd.Text = ad;
            TxtOgrDuzenlSoyad.Text = soyad;
            MskTC.Text = tc;
            MskOgrTelefon.Text = telefon;
            MskDogum.Text = dogum;
            CmbBolum.Text = bolum;
            TxtMail.Text = mail;
            CmbOdaNo.Text = odano;
            TxtVeliAdSoyad.Text = veliad;
            MskVeliTelefon.Text = velitel;
            RchAdres.Text = adres;
             


        }
    }
}
