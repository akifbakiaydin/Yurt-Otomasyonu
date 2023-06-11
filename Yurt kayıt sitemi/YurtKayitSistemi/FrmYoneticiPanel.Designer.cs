
namespace YurtKayitSistemi
{
    partial class FrmYoneticiPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYoneticiPanel));
            this.TxtYoneticiİd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYoneticiAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYoneticiSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtOtomasyonDataSet7 = new YurtKayitSistemi.YurtOtomasyonDataSet7();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new YurtKayitSistemi.YurtOtomasyonDataSet7TableAdapters.AdminTableAdapter();
            this.yoneticiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtYoneticiİd
            // 
            this.TxtYoneticiİd.BackColor = System.Drawing.Color.OldLace;
            this.TxtYoneticiİd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYoneticiİd.Location = new System.Drawing.Point(167, 27);
            this.TxtYoneticiİd.Name = "TxtYoneticiİd";
            this.TxtYoneticiİd.Size = new System.Drawing.Size(222, 30);
            this.TxtYoneticiİd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yönetici id";
            // 
            // txtYoneticiAd
            // 
            this.txtYoneticiAd.BackColor = System.Drawing.Color.OldLace;
            this.txtYoneticiAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiAd.Location = new System.Drawing.Point(167, 81);
            this.txtYoneticiAd.Name = "txtYoneticiAd";
            this.txtYoneticiAd.Size = new System.Drawing.Size(222, 30);
            this.txtYoneticiAd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Ad:";
            // 
            // txtYoneticiSifre
            // 
            this.txtYoneticiSifre.BackColor = System.Drawing.Color.OldLace;
            this.txtYoneticiSifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiSifre.Location = new System.Drawing.Point(167, 133);
            this.txtYoneticiSifre.Name = "txtYoneticiSifre";
            this.txtYoneticiSifre.Size = new System.Drawing.Size(222, 30);
            this.txtYoneticiSifre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanıcı Şifre:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(36, 215);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(120, 39);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(185, 215);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(120, 39);
            this.BtnSil.TabIndex = 9;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(332, 215);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(120, 39);
            this.BtnGuncelle.TabIndex = 10;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(36, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(416, 204);
            this.dataGridView1.TabIndex = 11;
            // 
            // yurtOtomasyonDataSet7
            // 
            this.yurtOtomasyonDataSet7.DataSetName = "YurtOtomasyonDataSet7";
            this.yurtOtomasyonDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.yurtOtomasyonDataSet7;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
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
            // FrmYoneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(483, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.txtYoneticiSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYoneticiAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtYoneticiİd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYoneticiPanel";
            this.Text = "FrmYoneticiPanel";
            this.Load += new System.EventHandler(this.FrmYoneticiPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtYoneticiİd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYoneticiAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYoneticiSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonDataSet7 yurtOtomasyonDataSet7;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private YurtOtomasyonDataSet7TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSifreDataGridViewTextBoxColumn;
    }
}