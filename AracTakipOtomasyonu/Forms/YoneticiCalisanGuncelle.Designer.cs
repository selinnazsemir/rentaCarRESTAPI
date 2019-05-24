namespace AracTakipOtomasyonu.Forms
{
    partial class YoneticiCalisanGuncelle
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
            this.dt_CalısanlarıGor = new System.Windows.Forms.DataGridView();
            this.txt_CalisanSifre = new System.Windows.Forms.TextBox();
            this.btn_CalisanGuncelle = new System.Windows.Forms.Button();
            this.cmb_FirmaId = new System.Windows.Forms.ComboBox();
            this.txt_CalisanAdi = new System.Windows.Forms.TextBox();
            this.txt_CalisanSoyad = new System.Windows.Forms.TextBox();
            this.txt_CalisanAd = new System.Windows.Forms.TextBox();
            this.lblCalisanAd = new System.Windows.Forms.Label();
            this.lblCalisanSoyad = new System.Windows.Forms.Label();
            this.lblCalisanKullaniciAdi = new System.Windows.Forms.Label();
            this.lblKullaniciSifre = new System.Windows.Forms.Label();
            this.lblFirmaID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_CalısanlarıGor)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_CalısanlarıGor
            // 
            this.dt_CalısanlarıGor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_CalısanlarıGor.Location = new System.Drawing.Point(484, 12);
            this.dt_CalısanlarıGor.Name = "dt_CalısanlarıGor";
            this.dt_CalısanlarıGor.ReadOnly = true;
            this.dt_CalısanlarıGor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_CalısanlarıGor.Size = new System.Drawing.Size(304, 426);
            this.dt_CalısanlarıGor.TabIndex = 0;
            this.dt_CalısanlarıGor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CalısanlarıGor_CellClick);
            // 
            // txt_CalisanSifre
            // 
            this.txt_CalisanSifre.Location = new System.Drawing.Point(40, 182);
            this.txt_CalisanSifre.Name = "txt_CalisanSifre";
            this.txt_CalisanSifre.Size = new System.Drawing.Size(271, 20);
            this.txt_CalisanSifre.TabIndex = 11;
            // 
            // btn_CalisanGuncelle
            // 
            this.btn_CalisanGuncelle.Location = new System.Drawing.Point(71, 276);
            this.btn_CalisanGuncelle.Name = "btn_CalisanGuncelle";
            this.btn_CalisanGuncelle.Size = new System.Drawing.Size(202, 23);
            this.btn_CalisanGuncelle.TabIndex = 10;
            this.btn_CalisanGuncelle.Text = "Calışan Güncelle";
            this.btn_CalisanGuncelle.UseVisualStyleBackColor = true;
            this.btn_CalisanGuncelle.Click += new System.EventHandler(this.btn_CalisanGuncelle_Click);
            // 
            // cmb_FirmaId
            // 
            this.cmb_FirmaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FirmaId.FormattingEnabled = true;
            this.cmb_FirmaId.Location = new System.Drawing.Point(40, 227);
            this.cmb_FirmaId.Name = "cmb_FirmaId";
            this.cmb_FirmaId.Size = new System.Drawing.Size(271, 21);
            this.cmb_FirmaId.TabIndex = 9;
            // 
            // txt_CalisanAdi
            // 
            this.txt_CalisanAdi.Location = new System.Drawing.Point(40, 136);
            this.txt_CalisanAdi.Name = "txt_CalisanAdi";
            this.txt_CalisanAdi.Size = new System.Drawing.Size(271, 20);
            this.txt_CalisanAdi.TabIndex = 8;
            // 
            // txt_CalisanSoyad
            // 
            this.txt_CalisanSoyad.Location = new System.Drawing.Point(40, 84);
            this.txt_CalisanSoyad.Name = "txt_CalisanSoyad";
            this.txt_CalisanSoyad.Size = new System.Drawing.Size(271, 20);
            this.txt_CalisanSoyad.TabIndex = 7;
            // 
            // txt_CalisanAd
            // 
            this.txt_CalisanAd.Location = new System.Drawing.Point(40, 34);
            this.txt_CalisanAd.Name = "txt_CalisanAd";
            this.txt_CalisanAd.Size = new System.Drawing.Size(271, 20);
            this.txt_CalisanAd.TabIndex = 6;
            // 
            // lblCalisanAd
            // 
            this.lblCalisanAd.AutoSize = true;
            this.lblCalisanAd.Location = new System.Drawing.Point(367, 37);
            this.lblCalisanAd.Name = "lblCalisanAd";
            this.lblCalisanAd.Size = new System.Drawing.Size(57, 13);
            this.lblCalisanAd.TabIndex = 12;
            this.lblCalisanAd.Text = "Çalışan Ad";
            // 
            // lblCalisanSoyad
            // 
            this.lblCalisanSoyad.AutoSize = true;
            this.lblCalisanSoyad.Location = new System.Drawing.Point(367, 87);
            this.lblCalisanSoyad.Name = "lblCalisanSoyad";
            this.lblCalisanSoyad.Size = new System.Drawing.Size(74, 13);
            this.lblCalisanSoyad.TabIndex = 13;
            this.lblCalisanSoyad.Text = "Çalışan Soyad";
            // 
            // lblCalisanKullaniciAdi
            // 
            this.lblCalisanKullaniciAdi.AutoSize = true;
            this.lblCalisanKullaniciAdi.Location = new System.Drawing.Point(367, 139);
            this.lblCalisanKullaniciAdi.Name = "lblCalisanKullaniciAdi";
            this.lblCalisanKullaniciAdi.Size = new System.Drawing.Size(64, 13);
            this.lblCalisanKullaniciAdi.TabIndex = 14;
            this.lblCalisanKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblKullaniciSifre
            // 
            this.lblKullaniciSifre.AutoSize = true;
            this.lblKullaniciSifre.Location = new System.Drawing.Point(367, 182);
            this.lblKullaniciSifre.Name = "lblKullaniciSifre";
            this.lblKullaniciSifre.Size = new System.Drawing.Size(70, 13);
            this.lblKullaniciSifre.TabIndex = 15;
            this.lblKullaniciSifre.Text = "Kullanıcı Şifre";
            // 
            // lblFirmaID
            // 
            this.lblFirmaID.AutoSize = true;
            this.lblFirmaID.Location = new System.Drawing.Point(367, 230);
            this.lblFirmaID.Name = "lblFirmaID";
            this.lblFirmaID.Size = new System.Drawing.Size(46, 13);
            this.lblFirmaID.TabIndex = 16;
            this.lblFirmaID.Text = "Firma ID";
            // 
            // YoneticiCalisanGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFirmaID);
            this.Controls.Add(this.lblKullaniciSifre);
            this.Controls.Add(this.lblCalisanKullaniciAdi);
            this.Controls.Add(this.lblCalisanSoyad);
            this.Controls.Add(this.lblCalisanAd);
            this.Controls.Add(this.txt_CalisanSifre);
            this.Controls.Add(this.btn_CalisanGuncelle);
            this.Controls.Add(this.cmb_FirmaId);
            this.Controls.Add(this.txt_CalisanAdi);
            this.Controls.Add(this.txt_CalisanSoyad);
            this.Controls.Add(this.txt_CalisanAd);
            this.Controls.Add(this.dt_CalısanlarıGor);
            this.Name = "YoneticiCalisanGuncelle";
            this.Text = "YoneticiCalisanGuncelle";
            this.Load += new System.EventHandler(this.YoneticiCalisanGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_CalısanlarıGor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_CalısanlarıGor;
        private System.Windows.Forms.TextBox txt_CalisanSifre;
        private System.Windows.Forms.Button btn_CalisanGuncelle;
        private System.Windows.Forms.ComboBox cmb_FirmaId;
        private System.Windows.Forms.TextBox txt_CalisanAdi;
        private System.Windows.Forms.TextBox txt_CalisanSoyad;
        private System.Windows.Forms.TextBox txt_CalisanAd;
        private System.Windows.Forms.Label lblCalisanAd;
        private System.Windows.Forms.Label lblCalisanSoyad;
        private System.Windows.Forms.Label lblCalisanKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciSifre;
        private System.Windows.Forms.Label lblFirmaID;
    }
}