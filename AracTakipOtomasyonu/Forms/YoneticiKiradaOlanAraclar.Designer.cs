namespace AracTakipOtomasyonu.Forms
{
    partial class YoneticiKiradaOlanAraclar
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
            this.dt_KiradaOlanAraclar = new System.Windows.Forms.DataGridView();
            this.btn_KiradaOlanAraclar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_KiradaOlanAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_KiradaOlanAraclar
            // 
            this.dt_KiradaOlanAraclar.AllowUserToAddRows = false;
            this.dt_KiradaOlanAraclar.AllowUserToDeleteRows = false;
            this.dt_KiradaOlanAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_KiradaOlanAraclar.Location = new System.Drawing.Point(12, 12);
            this.dt_KiradaOlanAraclar.Name = "dt_KiradaOlanAraclar";
            this.dt_KiradaOlanAraclar.ReadOnly = true;
            this.dt_KiradaOlanAraclar.Size = new System.Drawing.Size(776, 340);
            this.dt_KiradaOlanAraclar.TabIndex = 0;
            // 
            // btn_KiradaOlanAraclar
            // 
            this.btn_KiradaOlanAraclar.Location = new System.Drawing.Point(194, 377);
            this.btn_KiradaOlanAraclar.Name = "btn_KiradaOlanAraclar";
            this.btn_KiradaOlanAraclar.Size = new System.Drawing.Size(325, 23);
            this.btn_KiradaOlanAraclar.TabIndex = 1;
            this.btn_KiradaOlanAraclar.Text = "KiradakiAraclar";
            this.btn_KiradaOlanAraclar.UseVisualStyleBackColor = true;
            this.btn_KiradaOlanAraclar.Click += new System.EventHandler(this.btn_KiradaOlanAraclar_Click);
            // 
            // YoneticiKiradaOlanAraclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_KiradaOlanAraclar);
            this.Controls.Add(this.dt_KiradaOlanAraclar);
            this.Name = "YoneticiKiradaOlanAraclar";
            this.Text = "YoneticiKiradaOlanAraclar";
            this.Load += new System.EventHandler(this.YoneticiKiradaOlanAraclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_KiradaOlanAraclar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_KiradaOlanAraclar;
        private System.Windows.Forms.Button btn_KiradaOlanAraclar;
    }
}