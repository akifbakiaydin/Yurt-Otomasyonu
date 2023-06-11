
namespace YurtKayitSistemi
{
    partial class FrmAdminGiriss
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKullaniciAd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı ad:";
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAd.Location = new System.Drawing.Point(181, 85);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Size = new System.Drawing.Size(177, 30);
            this.TxtKullaniciAd.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(181, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giriş yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtKullaniciSifre
            // 
            this.TxtKullaniciSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciSifre.Location = new System.Drawing.Point(181, 134);
            this.TxtKullaniciSifre.Name = "TxtKullaniciSifre";
            this.TxtKullaniciSifre.Size = new System.Drawing.Size(177, 30);
            this.TxtKullaniciSifre.TabIndex = 4;
            this.TxtKullaniciSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı şifre:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 64);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(55, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = " Öğrenci Kayıt Otomasyon Sistemi";
            // 
            // FrmAdminGiriss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(515, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtKullaniciSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdminGiriss";
            this.Text = "FrmAdminGiriss";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKullaniciAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtKullaniciSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}