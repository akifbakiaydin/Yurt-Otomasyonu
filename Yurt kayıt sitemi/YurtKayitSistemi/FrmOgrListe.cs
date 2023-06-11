using System;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmOgrListe : Form
    {
        public FrmOgrListe()
        {
            InitializeComponent();
        }

        private void FrmOgrListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet5.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonDataSet5.Ogrenci);

        }
        int secilen;

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //veritabanından idyi çekme (listeden)
            secilen = OgrListeDataGrid.SelectedCells[0].RowIndex;
            FrmOgrDuzenle fr = new FrmOgrDuzenle(); //diğer formu açmak için nesne ürettik
            fr.id = OgrListeDataGrid.Rows[secilen].Cells[0].Value.ToString(); //secilen public degere atama yaptık
            fr.ad = OgrListeDataGrid.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = OgrListeDataGrid.Rows[secilen].Cells[2].Value.ToString();
            fr.tc = OgrListeDataGrid.Rows[secilen].Cells[3].Value.ToString();
            fr.telefon = OgrListeDataGrid.Rows[secilen].Cells[4].Value.ToString();
            fr.dogum = OgrListeDataGrid.Rows[secilen].Cells[5].Value.ToString();
            fr.bolum = OgrListeDataGrid.Rows[secilen].Cells[6].Value.ToString();
            fr.mail = OgrListeDataGrid.Rows[secilen].Cells[7].Value.ToString();
            fr.odano = OgrListeDataGrid.Rows[secilen].Cells[8].Value.ToString();
            fr.veliad = OgrListeDataGrid.Rows[secilen].Cells[9].Value.ToString();
            fr.velitel = OgrListeDataGrid.Rows[secilen].Cells[10].Value.ToString();
            fr.adres = OgrListeDataGrid.Rows[secilen].Cells[11].Value.ToString();
            fr.Show(); //diğer formu açtık diğerine veri aktarmak için böyle yaptık

        }

        private void OgrListeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
