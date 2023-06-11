
namespace YurtKayitSistemi
{
    partial class FrmOgrKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.MskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MskDogum = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbBolum = new System.Windows.Forms.ComboBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.MskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.Color.OldLace;
            this.TxtOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.Location = new System.Drawing.Point(145, 28);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(222, 30);
            this.TxtOgrAd.TabIndex = 1;
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.Color.OldLace;
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSoyad.Location = new System.Drawing.Point(147, 89);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(220, 30);
            this.TxtOgrSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC:";
            // 
            // MskTC
            // 
            this.MskTC.BackColor = System.Drawing.Color.OldLace;
            this.MskTC.Location = new System.Drawing.Point(149, 138);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(218, 22);
            this.MskTC.TabIndex = 5;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // MskOgrTelefon
            // 
            this.MskOgrTelefon.BackColor = System.Drawing.Color.OldLace;
            this.MskOgrTelefon.Location = new System.Drawing.Point(149, 190);
            this.MskOgrTelefon.Mask = "(999) 000-0000";
            this.MskOgrTelefon.Name = "MskOgrTelefon";
            this.MskOgrTelefon.Size = new System.Drawing.Size(218, 22);
            this.MskOgrTelefon.TabIndex = 7;
            this.MskOgrTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskOgrTelefon_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MskDogum
            // 
            this.MskDogum.BackColor = System.Drawing.Color.OldLace;
            this.MskDogum.Location = new System.Drawing.Point(147, 230);
            this.MskDogum.Mask = "00/00/0000";
            this.MskDogum.Name = "MskDogum";
            this.MskDogum.Size = new System.Drawing.Size(220, 22);
            this.MskDogum.TabIndex = 9;
            this.MskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci Bölüm";
            // 
            // CmbBolum
            // 
            this.CmbBolum.BackColor = System.Drawing.Color.OldLace;
            this.CmbBolum.FormattingEnabled = true;
            this.CmbBolum.Location = new System.Drawing.Point(147, 281);
            this.CmbBolum.Name = "CmbBolum";
            this.CmbBolum.Size = new System.Drawing.Size(220, 24);
            this.CmbBolum.TabIndex = 11;
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.OldLace;
            this.TxtMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(145, 332);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(222, 30);
            this.TxtMail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(18, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mail:";
            // 
            // CmbOdaNo
            // 
            this.CmbOdaNo.BackColor = System.Drawing.Color.OldLace;
            this.CmbOdaNo.FormattingEnabled = true;
            this.CmbOdaNo.Location = new System.Drawing.Point(147, 381);
            this.CmbOdaNo.Name = "CmbOdaNo";
            this.CmbOdaNo.Size = new System.Drawing.Size(220, 24);
            this.CmbOdaNo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Oda No:";
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.BackColor = System.Drawing.Color.OldLace;
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(147, 428);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(222, 30);
            this.TxtVeliAdSoyad.TabIndex = 17;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label41.Location = new System.Drawing.Point(15, 434);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(125, 24);
            this.label41.TabIndex = 16;
            this.label41.Text = "Veli Ad Soyad:";
            // 
            // MskVeliTelefon
            // 
            this.MskVeliTelefon.BackColor = System.Drawing.Color.OldLace;
            this.MskVeliTelefon.Location = new System.Drawing.Point(149, 481);
            this.MskVeliTelefon.Mask = "(999) 000-0000";
            this.MskVeliTelefon.Name = "MskVeliTelefon";
            this.MskVeliTelefon.Size = new System.Drawing.Size(224, 22);
            this.MskVeliTelefon.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(17, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Veli Telefon:";
            // 
            // RchAdres
            // 
            this.RchAdres.BackColor = System.Drawing.Color.OldLace;
            this.RchAdres.Location = new System.Drawing.Point(149, 521);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(224, 84);
            this.RchAdres.TabIndex = 20;
            this.RchAdres.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(15, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Adres:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKaydet.Location = new System.Drawing.Point(220, 637);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(153, 37);
            this.BtnKaydet.TabIndex = 22;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(427, 711);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RchAdres);
            this.Controls.Add(this.MskVeliTelefon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtVeliAdSoyad);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.CmbOdaNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbBolum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MskDogum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MskOgrTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrKayit";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.MaskedTextBox MskOgrTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskDogum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbBolum;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbOdaNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.MaskedTextBox MskVeliTelefon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox RchAdres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label11;
    }
}

