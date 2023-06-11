
namespace YurtKayitSistemi
{
    partial class FrmBolumler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.PcbBolumEkle = new System.Windows.Forms.PictureBox();
            this.PcbBolumSil = new System.Windows.Forms.PictureBox();
            this.PcbBolumDuzenle = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtBolumİd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtBolumAd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet = new YurtKayitSistemi.YurtOtomasyonDataSet();
            this.bolumlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbBolumEkle
            // 
            this.PcbBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumEkle.Image")));
            this.PcbBolumEkle.Location = new System.Drawing.Point(37, 25);
            this.PcbBolumEkle.Name = "PcbBolumEkle";
            this.PcbBolumEkle.Size = new System.Drawing.Size(68, 74);
            this.PcbBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumEkle.TabIndex = 0;
            this.PcbBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumEkle, "Bölüm Ekle");
            this.PcbBolumEkle.Click += new System.EventHandler(this.PcbBolumEkle_Click);
            // 
            // PcbBolumSil
            // 
            this.PcbBolumSil.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumSil.Image")));
            this.PcbBolumSil.Location = new System.Drawing.Point(168, 25);
            this.PcbBolumSil.Name = "PcbBolumSil";
            this.PcbBolumSil.Size = new System.Drawing.Size(68, 74);
            this.PcbBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumSil.TabIndex = 1;
            this.PcbBolumSil.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumSil, "Bölüm Sil");
            this.PcbBolumSil.Click += new System.EventHandler(this.PcbBolumSil_Click);
            // 
            // PcbBolumDuzenle
            // 
            this.PcbBolumDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumDuzenle.Image")));
            this.PcbBolumDuzenle.Location = new System.Drawing.Point(304, 25);
            this.PcbBolumDuzenle.Name = "PcbBolumDuzenle";
            this.PcbBolumDuzenle.Size = new System.Drawing.Size(68, 74);
            this.PcbBolumDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumDuzenle.TabIndex = 2;
            this.PcbBolumDuzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumDuzenle, "Bölüm Güncelle");
            this.PcbBolumDuzenle.Click += new System.EventHandler(this.PcbBolumDuzenle_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(32, 146);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(99, 25);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Bölüm İD";
            // 
            // TxtBolumİd
            // 
            this.TxtBolumİd.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtBolumİd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBolumİd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtBolumİd.BorderThickness = 3;
            this.TxtBolumİd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBolumİd.Enabled = false;
            this.TxtBolumİd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumİd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBolumİd.isPassword = false;
            this.TxtBolumİd.Location = new System.Drawing.Point(152, 137);
            this.TxtBolumİd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtBolumİd.Name = "TxtBolumİd";
            this.TxtBolumİd.Size = new System.Drawing.Size(313, 34);
            this.TxtBolumİd.TabIndex = 4;
            this.TxtBolumİd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtBolumAd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBolumAd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtBolumAd.BorderThickness = 3;
            this.TxtBolumAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBolumAd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBolumAd.isPassword = false;
            this.TxtBolumAd.Location = new System.Drawing.Point(152, 197);
            this.TxtBolumAd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(313, 34);
            this.TxtBolumAd.TabIndex = 6;
            this.TxtBolumAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(26, 206);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(105, 25);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Bölüm Ad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIDDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(599, 423);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            this.bolumAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonDataSet;
            // 
            // yurtOtomasyonDataSet
            // 
            this.yurtOtomasyonDataSet.DataSetName = "YurtOtomasyonDataSet";
            this.yurtOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 690);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.TxtBolumİd);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.PcbBolumDuzenle);
            this.Controls.Add(this.PcbBolumSil);
            this.Controls.Add(this.PcbBolumEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "FrmBolumler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbBolumEkle;
        private System.Windows.Forms.PictureBox PcbBolumSil;
        private System.Windows.Forms.PictureBox PcbBolumDuzenle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtBolumİd;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtBolumAd;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonDataSet yurtOtomasyonDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtOtomasyonDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}