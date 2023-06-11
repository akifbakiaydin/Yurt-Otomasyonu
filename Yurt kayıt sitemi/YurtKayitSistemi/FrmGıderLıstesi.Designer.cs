
namespace YurtKayitSistemi
{
    partial class FrmGıderLıstesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGıderLıstesi));
            this.GıderListesiDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.yurtOtomasyonDataSet6 = new YurtKayitSistemi.YurtOtomasyonDataSet6();
            this.gıderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gıderlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonDataSet6TableAdapters.GıderlerTableAdapter();
            this.odemeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektrikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogalgazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gıdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GıderListesiDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gıderlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GıderListesiDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GıderListesiDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GıderListesiDataGrid.AutoGenerateColumns = false;
            this.GıderListesiDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GıderListesiDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GıderListesiDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GıderListesiDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GıderListesiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GıderListesiDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeidDataGridViewTextBoxColumn,
            this.elektrikDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.dogalgazDataGridViewTextBoxColumn,
            this.internetDataGridViewTextBoxColumn,
            this.gıdaDataGridViewTextBoxColumn,
            this.personelDataGridViewTextBoxColumn,
            this.digerDataGridViewTextBoxColumn});
            this.GıderListesiDataGrid.DataSource = this.gıderlerBindingSource;
            this.GıderListesiDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GıderListesiDataGrid.DoubleBuffered = true;
            this.GıderListesiDataGrid.EnableHeadersVisualStyles = false;
            this.GıderListesiDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GıderListesiDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.GıderListesiDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.GıderListesiDataGrid.Location = new System.Drawing.Point(0, 0);
            this.GıderListesiDataGrid.Name = "GıderListesiDataGrid";
            this.GıderListesiDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GıderListesiDataGrid.RowHeadersWidth = 51;
            this.GıderListesiDataGrid.RowTemplate.Height = 24;
            this.GıderListesiDataGrid.Size = new System.Drawing.Size(1052, 234);
            this.GıderListesiDataGrid.TabIndex = 0;
            this.GıderListesiDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            // 
            // yurtOtomasyonDataSet6
            // 
            this.yurtOtomasyonDataSet6.DataSetName = "YurtOtomasyonDataSet6";
            this.yurtOtomasyonDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gıderlerBindingSource
            // 
            this.gıderlerBindingSource.DataMember = "Gıderler";
            this.gıderlerBindingSource.DataSource = this.yurtOtomasyonDataSet6;
            // 
            // gıderlerTableAdapter
            // 
            this.gıderlerTableAdapter.ClearBeforeFill = true;
            // 
            // odemeidDataGridViewTextBoxColumn
            // 
            this.odemeidDataGridViewTextBoxColumn.DataPropertyName = "Odemeid";
            this.odemeidDataGridViewTextBoxColumn.HeaderText = "Odemeid";
            this.odemeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeidDataGridViewTextBoxColumn.Name = "odemeidDataGridViewTextBoxColumn";
            this.odemeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // elektrikDataGridViewTextBoxColumn
            // 
            this.elektrikDataGridViewTextBoxColumn.DataPropertyName = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.HeaderText = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elektrikDataGridViewTextBoxColumn.Name = "elektrikDataGridViewTextBoxColumn";
            this.elektrikDataGridViewTextBoxColumn.Width = 125;
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "Su";
            this.suDataGridViewTextBoxColumn.HeaderText = "Su";
            this.suDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            this.suDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogalgazDataGridViewTextBoxColumn
            // 
            this.dogalgazDataGridViewTextBoxColumn.DataPropertyName = "Dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.HeaderText = "Dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogalgazDataGridViewTextBoxColumn.Name = "dogalgazDataGridViewTextBoxColumn";
            this.dogalgazDataGridViewTextBoxColumn.Width = 125;
            // 
            // internetDataGridViewTextBoxColumn
            // 
            this.internetDataGridViewTextBoxColumn.DataPropertyName = "internet";
            this.internetDataGridViewTextBoxColumn.HeaderText = "internet";
            this.internetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.internetDataGridViewTextBoxColumn.Name = "internetDataGridViewTextBoxColumn";
            this.internetDataGridViewTextBoxColumn.Width = 125;
            // 
            // gıdaDataGridViewTextBoxColumn
            // 
            this.gıdaDataGridViewTextBoxColumn.DataPropertyName = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.HeaderText = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gıdaDataGridViewTextBoxColumn.Name = "gıdaDataGridViewTextBoxColumn";
            this.gıdaDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelDataGridViewTextBoxColumn
            // 
            this.personelDataGridViewTextBoxColumn.DataPropertyName = "Personel";
            this.personelDataGridViewTextBoxColumn.HeaderText = "Personel";
            this.personelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelDataGridViewTextBoxColumn.Name = "personelDataGridViewTextBoxColumn";
            this.personelDataGridViewTextBoxColumn.Width = 125;
            // 
            // digerDataGridViewTextBoxColumn
            // 
            this.digerDataGridViewTextBoxColumn.DataPropertyName = "Diger";
            this.digerDataGridViewTextBoxColumn.HeaderText = "Diger";
            this.digerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.digerDataGridViewTextBoxColumn.Name = "digerDataGridViewTextBoxColumn";
            this.digerDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmGıderLıstesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1052, 234);
            this.Controls.Add(this.GıderListesiDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGıderLıstesi";
            this.Text = "Gider Listesi";
            this.Load += new System.EventHandler(this.FrmGıderLıstesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GıderListesiDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gıderlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid GıderListesiDataGrid;
        private YurtOtomasyonDataSet6 yurtOtomasyonDataSet6;
        private System.Windows.Forms.BindingSource gıderlerBindingSource;
        private YurtOtomasyonDataSet6TableAdapters.GıderlerTableAdapter gıderlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogalgazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gıdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digerDataGridViewTextBoxColumn;
    }
}