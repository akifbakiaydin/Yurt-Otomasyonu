
namespace YurtKayitSistemi
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.TxtPersonelİd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPersonelAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPersonelGorev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.yurtOtomasyonDataSet9 = new YurtKayitSistemi.YurtOtomasyonDataSet9();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new YurtKayitSistemi.YurtOtomasyonDataSet9TableAdapters.PersonelTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtOtomasyonDataSet10 = new YurtKayitSistemi.YurtOtomasyonDataSet10();
            this.personelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter1 = new YurtKayitSistemi.YurtOtomasyonDataSet10TableAdapters.PersonelTableAdapter();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPersonelİd
            // 
            this.TxtPersonelİd.BackColor = System.Drawing.Color.OldLace;
            this.TxtPersonelİd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelİd.Location = new System.Drawing.Point(163, 27);
            this.TxtPersonelİd.Name = "TxtPersonelİd";
            this.TxtPersonelİd.Size = new System.Drawing.Size(222, 30);
            this.TxtPersonelİd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel id:";
            // 
            // TxtPersonelAd
            // 
            this.TxtPersonelAd.BackColor = System.Drawing.Color.OldLace;
            this.TxtPersonelAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelAd.Location = new System.Drawing.Point(163, 86);
            this.TxtPersonelAd.Name = "TxtPersonelAd";
            this.TxtPersonelAd.Size = new System.Drawing.Size(222, 30);
            this.TxtPersonelAd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Ad:";
            // 
            // TxtPersonelGorev
            // 
            this.TxtPersonelGorev.BackColor = System.Drawing.Color.OldLace;
            this.TxtPersonelGorev.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelGorev.Location = new System.Drawing.Point(163, 153);
            this.TxtPersonelGorev.Name = "TxtPersonelGorev";
            this.TxtPersonelGorev.Size = new System.Drawing.Size(222, 30);
            this.TxtPersonelGorev.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel Görev :";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(19, 230);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(113, 34);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(163, 230);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(113, 34);
            this.BtnSil.TabIndex = 9;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(317, 230);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(113, 34);
            this.BtnGuncelle.TabIndex = 10;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // yurtOtomasyonDataSet9
            // 
            this.yurtOtomasyonDataSet9.DataSetName = "YurtOtomasyonDataSet9";
            this.yurtOtomasyonDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtOtomasyonDataSet9;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurtOtomasyonDataSet10
            // 
            this.yurtOtomasyonDataSet10.DataSetName = "YurtOtomasyonDataSet10";
            this.yurtOtomasyonDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource1
            // 
            this.personelBindingSource1.DataMember = "Personel";
            this.personelBindingSource1.DataSource = this.yurtOtomasyonDataSet10;
            // 
            // personelTableAdapter1
            // 
            this.personelTableAdapter1.ClearBeforeFill = true;
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personelid";
            this.personelidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelidDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            this.personelAdSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            this.personelDepartmanDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtPersonelGorev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPersonelAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPersonelİd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPersonelİd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPersonelAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPersonelGorev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private YurtOtomasyonDataSet9 yurtOtomasyonDataSet9;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtOtomasyonDataSet9TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonDataSet10 yurtOtomasyonDataSet10;
        private System.Windows.Forms.BindingSource personelBindingSource1;
        private YurtOtomasyonDataSet10TableAdapters.PersonelTableAdapter personelTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
    }
}