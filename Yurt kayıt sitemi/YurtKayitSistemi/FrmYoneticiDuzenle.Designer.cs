
namespace YurtKayitSistemi
{
    partial class FrmYoneticiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYoneticiDuzenle));
            this.TxtYoneticiid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKaydetYonDuzen = new System.Windows.Forms.Button();
            this.BtnSilYonDuzen = new System.Windows.Forms.Button();
            this.BtnGuncelleYonDuzen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yoneticiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet8 = new YurtKayitSistemi.YurtOtomasyonDataSet8();
            this.adminTableAdapter = new YurtKayitSistemi.YurtOtomasyonDataSet8TableAdapters.AdminTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtYoneticiid
            // 
            this.TxtYoneticiid.BackColor = System.Drawing.Color.OldLace;
            this.TxtYoneticiid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYoneticiid.Location = new System.Drawing.Point(153, 25);
            this.TxtYoneticiid.Name = "TxtYoneticiid";
            this.TxtYoneticiid.Size = new System.Drawing.Size(222, 30);
            this.TxtYoneticiid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yönetici id:";
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.BackColor = System.Drawing.Color.OldLace;
            this.TxtKullaniciAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAd.Location = new System.Drawing.Point(153, 81);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Size = new System.Drawing.Size(222, 30);
            this.TxtKullaniciAd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı ad:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.OldLace;
            this.TxtSifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(153, 152);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(222, 30);
            this.TxtSifre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre:";
            // 
            // BtnKaydetYonDuzen
            // 
            this.BtnKaydetYonDuzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydetYonDuzen.Location = new System.Drawing.Point(27, 236);
            this.BtnKaydetYonDuzen.Name = "BtnKaydetYonDuzen";
            this.BtnKaydetYonDuzen.Size = new System.Drawing.Size(105, 33);
            this.BtnKaydetYonDuzen.TabIndex = 8;
            this.BtnKaydetYonDuzen.Text = "Kaydet";
            this.BtnKaydetYonDuzen.UseVisualStyleBackColor = true;
            this.BtnKaydetYonDuzen.Click += new System.EventHandler(this.BtnKaydetYonDuzen_Click);
            // 
            // BtnSilYonDuzen
            // 
            this.BtnSilYonDuzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSilYonDuzen.Location = new System.Drawing.Point(176, 236);
            this.BtnSilYonDuzen.Name = "BtnSilYonDuzen";
            this.BtnSilYonDuzen.Size = new System.Drawing.Size(105, 33);
            this.BtnSilYonDuzen.TabIndex = 9;
            this.BtnSilYonDuzen.Text = "Sil";
            this.BtnSilYonDuzen.UseVisualStyleBackColor = true;
            this.BtnSilYonDuzen.Click += new System.EventHandler(this.BtnSilYonDuzen_Click);
            // 
            // BtnGuncelleYonDuzen
            // 
            this.BtnGuncelleYonDuzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelleYonDuzen.Location = new System.Drawing.Point(318, 236);
            this.BtnGuncelleYonDuzen.Name = "BtnGuncelleYonDuzen";
            this.BtnGuncelleYonDuzen.Size = new System.Drawing.Size(127, 33);
            this.BtnGuncelleYonDuzen.TabIndex = 10;
            this.BtnGuncelleYonDuzen.Text = "Güncelle";
            this.BtnGuncelleYonDuzen.UseVisualStyleBackColor = true;
            this.BtnGuncelleYonDuzen.Click += new System.EventHandler(this.BtnGuncelleYonDuzen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yoneticiidDataGridViewTextBoxColumn,
            this.yoneticiAdDataGridViewTextBoxColumn,
            this.yoneticiSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(418, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yoneticiidDataGridViewTextBoxColumn
            // 
            this.yoneticiidDataGridViewTextBoxColumn.DataPropertyName = "Yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.HeaderText = "Yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiidDataGridViewTextBoxColumn.Name = "yoneticiidDataGridViewTextBoxColumn";
            this.yoneticiidDataGridViewTextBoxColumn.ReadOnly = true;
            this.yoneticiidDataGridViewTextBoxColumn.Width = 125;
            // 
            // yoneticiAdDataGridViewTextBoxColumn
            // 
            this.yoneticiAdDataGridViewTextBoxColumn.DataPropertyName = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.HeaderText = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiAdDataGridViewTextBoxColumn.Name = "yoneticiAdDataGridViewTextBoxColumn";
            this.yoneticiAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // yoneticiSifreDataGridViewTextBoxColumn
            // 
            this.yoneticiSifreDataGridViewTextBoxColumn.DataPropertyName = "YoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.HeaderText = "YoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiSifreDataGridViewTextBoxColumn.Name = "yoneticiSifreDataGridViewTextBoxColumn";
            this.yoneticiSifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.yurtOtomasyonDataSet8;
            // 
            // yurtOtomasyonDataSet8
            // 
            this.yurtOtomasyonDataSet8.DataSetName = "YurtOtomasyonDataSet8";
            this.yurtOtomasyonDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // FrmYoneticiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(520, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelleYonDuzen);
            this.Controls.Add(this.BtnSilYonDuzen);
            this.Controls.Add(this.BtnKaydetYonDuzen);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtYoneticiid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYoneticiDuzenle";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtYoneticiid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKullaniciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnKaydetYonDuzen;
        private System.Windows.Forms.Button BtnSilYonDuzen;
        private System.Windows.Forms.Button BtnGuncelleYonDuzen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonDataSet8 yurtOtomasyonDataSet8;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private YurtOtomasyonDataSet8TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSifreDataGridViewTextBoxColumn;
    }
}