namespace AracTakipOtomasyonu.Forms
{
    partial class YoneticiAracListesi
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
            this.dt_AracListele = new System.Windows.Forms.DataGridView();
            this.btn_Listele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_AracListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_AracListele
            // 
            this.dt_AracListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_AracListele.Location = new System.Drawing.Point(12, 12);
            this.dt_AracListele.Name = "dt_AracListele";
            this.dt_AracListele.ReadOnly = true;
            this.dt_AracListele.Size = new System.Drawing.Size(602, 309);
            this.dt_AracListele.TabIndex = 0;
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(208, 374);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(301, 23);
            this.btn_Listele.TabIndex = 1;
            this.btn_Listele.Text = "Arac Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // YoneticiAracListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 513);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.dt_AracListele);
            this.Name = "YoneticiAracListesi";
            this.Text = "YoneticiAracListesi";
            ((System.ComponentModel.ISupportInitialize)(this.dt_AracListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_AracListele;
        private System.Windows.Forms.Button btn_Listele;
    }
}