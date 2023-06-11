using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YurtKayitSistemi
{
    public partial class FrmNotEkle : Form
    {
        public FrmNotEkle()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kayıt Yeri Seçin :";
            saveFileDialog1.Filter= "Metin Dosyası | *.txt "; // düz çizginin yanıdna yıldızla kısıtlama getirdik sadece txt dosyası
            saveFileDialog1.InitialDirectory = "C:\\Yurt Notlar"; // Başlangıçta nereden başlayacağı İnitialDirectory
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName); //Akışı yazan yazma işlemini gerçekleştiren sınıf
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Kaydedildi !");
        }
    }
}
