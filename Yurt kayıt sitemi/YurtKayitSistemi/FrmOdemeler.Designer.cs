
namespace YurtKayitSistemi
{
    partial class FrmOdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeler));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOgrid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtOdenen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKalan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnOdemeAl = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrKalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet2 = new YurtKayitSistemi.YurtOtomasyonDataSet2();
            this.borclarTableAdapter = new YurtKayitSistemi.YurtOtomasyonDataSet2TableAdapters.BorclarTableAdapter();
            this.TxtAd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtOdenenAy = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci id:";
            // 
            // TxtOgrid
            // 
            this.TxtOgrid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtOgrid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtOgrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtOgrid.HintForeColor = System.Drawing.Color.Empty;
            this.TxtOgrid.HintText = "";
            this.TxtOgrid.isPassword = false;
            this.TxtOgrid.LineFocusedColor = System.Drawing.Color.AliceBlue;
            this.TxtOgrid.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtOgrid.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.TxtOgrid.LineThickness = 3;
            this.TxtOgrid.Location = new System.Drawing.Point(127, 9);
            this.TxtOgrid.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOgrid.Name = "TxtOgrid";
            this.TxtOgrid.Size = new System.Drawing.Size(252, 34);
            this.TxtOgrid.TabIndex = 3;
            this.TxtOgrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtOdenen
            // 
            this.TxtOdenen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtOdenen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtOdenen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtOdenen.HintForeColor = System.Drawing.Color.Empty;
            this.TxtOdenen.HintText = "";
            this.TxtOdenen.isPassword = false;
            this.TxtOdenen.LineFocusedColor = System.Drawing.Color.AliceBlue;
            this.TxtOdenen.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtOdenen.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.TxtOdenen.LineThickness = 3;
            this.TxtOdenen.Location = new System.Drawing.Point(127, 198);
            this.TxtOdenen.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOdenen.Name = "TxtOdenen";
            this.TxtOdenen.Size = new System.Drawing.Size(252, 34);
            this.TxtOdenen.TabIndex = 5;
            this.TxtOdenen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ödenen:";
            // 
            // TxtKalan
            // 
            this.TxtKalan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtKalan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtKalan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtKalan.HintForeColor = System.Drawing.Color.Empty;
            this.TxtKalan.HintText = "";
            this.TxtKalan.isPassword = false;
            this.TxtKalan.LineFocusedColor = System.Drawing.Color.AliceBlue;
            this.TxtKalan.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtKalan.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.TxtKalan.LineThickness = 3;
            this.TxtKalan.Location = new System.Drawing.Point(127, 253);
            this.TxtKalan.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(252, 34);
            this.TxtKalan.TabIndex = 7;
            this.TxtKalan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kalan Borç:";
            // 
            // BtnOdemeAl
            // 
            this.BtnOdemeAl.ActiveBorderThickness = 1;
            this.BtnOdemeAl.ActiveCornerRadius = 20;
            this.BtnOdemeAl.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnOdemeAl.ActiveForecolor = System.Drawing.Color.White;
            this.BtnOdemeAl.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnOdemeAl.BackColor = System.Drawing.Color.LightPink;
            this.BtnOdemeAl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOdemeAl.BackgroundImage")));
            this.BtnOdemeAl.ButtonText = "Ödeme Al";
            this.BtnOdemeAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOdemeAl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdemeAl.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnOdemeAl.IdleBorderThickness = 1;
            this.BtnOdemeAl.IdleCornerRadius = 20;
            this.BtnOdemeAl.IdleFillColor = System.Drawing.Color.White;
            this.BtnOdemeAl.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnOdemeAl.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnOdemeAl.Location = new System.Drawing.Point(149, 686);
            this.BtnOdemeAl.Margin = new System.Windows.Forms.Padding(5);
            this.BtnOdemeAl.Name = "BtnOdemeAl";
            this.BtnOdemeAl.Size = new System.Drawing.Size(213, 43);
            this.BtnOdemeAl.TabIndex = 8;
            this.BtnOdemeAl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnOdemeAl.Click += new System.EventHandler(this.BtnOdemeAl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrKalanBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borclarBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(0, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 248);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrKalanBorcDataGridViewTextBoxColumn
            // 
            this.ogrKalanBorcDataGridViewTextBoxColumn.DataPropertyName = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.HeaderText = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrKalanBorcDataGridViewTextBoxColumn.Name = "ogrKalanBorcDataGridViewTextBoxColumn";
            this.ogrKalanBorcDataGridViewTextBoxColumn.Width = 125;
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "Borclar";
            this.borclarBindingSource.DataSource = this.yurtOtomasyonDataSet2;
            // 
            // yurtOtomasyonDataSet2
            // 
            this.yurtOtomasyonDataSet2.DataSetName = "YurtOtomasyonDataSet2";
            this.yurtOtomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // TxtAd
            // 
            this.TxtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtAd.HintForeColor = System.Drawing.Color.Empty;
            this.TxtAd.HintText = "";
            this.TxtAd.isPassword = false;
            this.TxtAd.LineFocusedColor = System.Drawing.Color.AliceBlue;
            this.TxtAd.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtAd.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.TxtAd.LineThickness = 3;
            this.TxtAd.Location = new System.Drawing.Point(127, 59);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(252, 34);
            this.TxtAd.TabIndex = 11;
            this.TxtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtAd.OnValueChanged += new System.EventHandler(this.TxtAd_OnValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adı:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSoyad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSoyad.HintForeColor = System.Drawing.Color.Empty;
            this.TxtSoyad.HintText = "";
            this.TxtSoyad.isPassword = false;
            this.TxtSoyad.LineFocusedColor = System.Drawing.Color.AliceBlue;
            this.TxtSoyad.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtSoyad.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.TxtSoyad.LineThickness = 3;
            this.TxtSoyad.Location = new System.Drawing.Point(127, 123);
            this.TxtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(252, 34);
            this.TxtSoyad.TabIndex = 13;
            this.TxtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Soyadı:";
            // 
            // TxtOdenenAy
            // 
            this.TxtOdenenAy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtOdenenAy.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtOdenenAy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtOdenenAy.HintForeColor = System.Drawing.Color.Empty;
            this.TxtOdenenAy.HintText = "";
            this.TxtOdenenAy.isPassword = false;
            this.TxtOdenenAy.LineFocusedColor = System.Drawing.Color.AliceBlue;
            this.TxtOdenenAy.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtOdenenAy.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.TxtOdenenAy.LineThickness = 3;
            this.TxtOdenenAy.Location = new System.Drawing.Point(127, 315);
            this.TxtOdenenAy.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOdenenAy.Name = "TxtOdenenAy";
            this.TxtOdenenAy.Size = new System.Drawing.Size(252, 34);
            this.TxtOdenenAy.TabIndex = 15;
            this.TxtOdenenAy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ödeme Ay";
            // 
            // FrmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(553, 752);
            this.Controls.Add(this.TxtOdenenAy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnOdemeAl);
            this.Controls.Add(this.TxtKalan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOdenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOgrid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdemeler";
            this.Text = "Odemeler";
            this.Load += new System.EventHandler(this.FrmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtOgrid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtOdenen;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtKalan;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnOdemeAl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonDataSet2 yurtOtomasyonDataSet2;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private YurtOtomasyonDataSet2TableAdapters.BorclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKalanBorcDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtAd;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtSoyad;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtOdenenAy;
        private System.Windows.Forms.Label label6;
    }
}