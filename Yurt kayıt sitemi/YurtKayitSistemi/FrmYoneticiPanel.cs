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
    public partial class FrmYoneticiPanel : Form
    {
        public FrmYoneticiPanel()
        {
            InitializeComponent();
        }

        private void FrmYoneticiPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet7.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.yurtOtomasyonDataSet7.Admin);

        }
    }
}
