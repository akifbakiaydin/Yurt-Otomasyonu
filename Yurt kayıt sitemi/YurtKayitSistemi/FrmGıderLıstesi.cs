using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmGıderLıstesi : Form
    {
        public FrmGıderLıstesi()
        {
            InitializeComponent();
        }

        private void FrmGıderLıstesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet6.Gıderler' table. You can move, or remove it, as needed.
            this.gıderlerTableAdapter.Fill(this.yurtOtomasyonDataSet6.Gıderler);

        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            FrmGıderGuncelle frg = new FrmGıderGuncelle();
            secilen = GıderListesiDataGrid.SelectedCells[0].RowIndex;
            frg.id = GıderListesiDataGrid.Rows[secilen].Cells[0].Value.ToString();
            frg.elektrik = GıderListesiDataGrid.Rows[secilen].Cells[1].Value.ToString();
            frg.su= GıderListesiDataGrid.Rows[secilen].Cells[2].Value.ToString();
            frg.dogalgaz = GıderListesiDataGrid.Rows[secilen].Cells[3].Value.ToString();
            frg.internet = GıderListesiDataGrid.Rows[secilen].Cells[4].Value.ToString();
            frg.gıda = GıderListesiDataGrid.Rows[secilen].Cells[5].Value.ToString();
            frg.personel = GıderListesiDataGrid.Rows[secilen].Cells[6].Value.ToString();
            frg.diger = GıderListesiDataGrid.Rows[secilen].Cells[7].Value.ToString();

            frg.Show();

        }
    }
}

