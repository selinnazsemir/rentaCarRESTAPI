namespace AracTakipOtomasyonu.Forms
{
    partial class YoneticiAracKiralayanlar
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
            this.dt_MusteridekiKiralikAraclar = new System.Windows.Forms.DataGridView();
            this.btn_MusteridekiKiralikAraclar = new System.Windows.Forms.Button();
            this.cmb_MusteriSec = new System.Windows.Forms.ComboBox();
            this.lblMusteriSec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_MusteridekiKiralikAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_MusteridekiKiralikAraclar
            // 
            this.dt_MusteridekiKiralikAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_MusteridekiKiralikAraclar.Location = new System.Drawing.Point(12, 12);
            this.dt_MusteridekiKiralikAraclar.Name = "dt_MusteridekiKiralikAraclar";
            this.dt_MusteridekiKiralikAraclar.ReadOnly = true;
            this.dt_MusteridekiKiralikAraclar.Size = new System.Drawing.Size(776, 300);
            this.dt_MusteridekiKiralikAraclar.TabIndex = 0;
            // 
            // btn_MusteridekiKiralikAraclar
            // 
            this.btn_MusteridekiKiralikAraclar.Location = new System.Drawing.Point(297, 383);
            this.btn_MusteridekiKiralikAraclar.Name = "btn_MusteridekiKiralikAraclar";
            this.btn_MusteridekiKiralikAraclar.Size = new System.Drawing.Size(345, 35);
            this.btn_MusteridekiKiralikAraclar.TabIndex = 1;
            this.btn_MusteridekiKiralikAraclar.Text = "Kiralanan Araçları Gör";
            this.btn_MusteridekiKiralikAraclar.UseVisualStyleBackColor = true;
            this.btn_MusteridekiKiralikAraclar.Click += new System.EventHandler(this.btn_MusteridekiKiralikAraclar_Click);
            // 
            // cmb_MusteriSec
            // 
            this.cmb_MusteriSec.FormattingEnabled = true;
            this.cmb_MusteriSec.Location = new System.Drawing.Point(282, 337);
            this.cmb_MusteriSec.Name = "cmb_MusteriSec";
            this.cmb_MusteriSec.Size = new System.Drawing.Size(372, 21);
            this.cmb_MusteriSec.TabIndex = 2;
            // 
            // lblMusteriSec
            // 
            this.lblMusteriSec.AutoSize = true;
            this.lblMusteriSec.Location = new System.Drawing.Point(117, 340);
            this.lblMusteriSec.Name = "lblMusteriSec";
            this.lblMusteriSec.Size = new System.Drawing.Size(111, 13);
            this.lblMusteriSec.TabIndex = 3;
            this.lblMusteriSec.Text = "Lütfen Müşteri Seçiniz";
            // 
            // YoneticiAracKiralayanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMusteriSec);
            this.Controls.Add(this.cmb_MusteriSec);
            this.Controls.Add(this.btn_MusteridekiKiralikAraclar);
            this.Controls.Add(this.dt_MusteridekiKiralikAraclar);
            this.Name = "YoneticiAracKiralayanlar";
            this.Text = "YoneticiAracKiralayanlar";
            this.Load += new System.EventHandler(this.YoneticiAracKiralayanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_MusteridekiKiralikAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_MusteridekiKiralikAraclar;
        private System.Windows.Forms.Button btn_MusteridekiKiralikAraclar;
        private System.Windows.Forms.ComboBox cmb_MusteriSec;
        private System.Windows.Forms.Label lblMusteriSec;
    }
}