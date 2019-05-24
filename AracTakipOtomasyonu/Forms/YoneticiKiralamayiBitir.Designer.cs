namespace AracTakipOtomasyonu.Forms
{
    partial class YoneticiKiralamayiBitir
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_KiralaBitir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(336, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btn_KiralaBitir
            // 
            this.btn_KiralaBitir.Location = new System.Drawing.Point(250, 384);
            this.btn_KiralaBitir.Name = "btn_KiralaBitir";
            this.btn_KiralaBitir.Size = new System.Drawing.Size(202, 23);
            this.btn_KiralaBitir.TabIndex = 2;
            this.btn_KiralaBitir.Text = "Kiralamayı Bitir";
            this.btn_KiralaBitir.UseVisualStyleBackColor = true;
            this.btn_KiralaBitir.Click += new System.EventHandler(this.btn_KiralaBitir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(537, 386);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 3;
            // 
            // YoneticiKiralamayiBitir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_KiralaBitir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "YoneticiKiralamayiBitir";
            this.Text = "YoneticiKiralamayiBitir";
            this.Load += new System.EventHandler(this.YoneticiKiralamayiBitir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_KiralaBitir;
        private System.Windows.Forms.TextBox textBox1;
    }
}