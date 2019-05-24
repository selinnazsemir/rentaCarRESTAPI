namespace AracTakipOtomasyonu.Forms
{
    partial class YoneticiCalisanListele
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
            this.dt_CalListele = new System.Windows.Forms.DataGridView();
            this.btn_CalisanListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_CalListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_CalListele
            // 
            this.dt_CalListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_CalListele.Location = new System.Drawing.Point(12, 12);
            this.dt_CalListele.Name = "dt_CalListele";
            this.dt_CalListele.ReadOnly = true;
            this.dt_CalListele.Size = new System.Drawing.Size(776, 296);
            this.dt_CalListele.TabIndex = 0;
            // 
            // btn_CalisanListele
            // 
            this.btn_CalisanListele.Location = new System.Drawing.Point(196, 349);
            this.btn_CalisanListele.Name = "btn_CalisanListele";
            this.btn_CalisanListele.Size = new System.Drawing.Size(313, 23);
            this.btn_CalisanListele.TabIndex = 1;
            this.btn_CalisanListele.Text = "Calisanları Listele";
            this.btn_CalisanListele.UseVisualStyleBackColor = true;
            this.btn_CalisanListele.Click += new System.EventHandler(this.btn_CalisanListele_Click);
            // 
            // YoneticiCalisanListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CalisanListele);
            this.Controls.Add(this.dt_CalListele);
            this.Name = "YoneticiCalisanListele";
            this.Text = "YoneticiCalisanListele";
            this.Load += new System.EventHandler(this.YoneticiCalisanListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_CalListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_CalListele;
        private System.Windows.Forms.Button btn_CalisanListele;
    }
}