using BusinessLayer.Repositories;
using ObjectLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracTakipOtomasyonu.Forms
{
    public partial class YoneticiKiralamayiBitir : Form
    {
        public YoneticiKiralamayiBitir()
        {
            InitializeComponent();
        }
        public List<Araclar> araclar;
        AraclarRepository arac = new AraclarRepository();
        public List<Musteriler> musteriler;
        int aracid;
        public List<GelirGider> gelirgider;
        private void btn_KiralaBitir_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.MusteriId = musteriler.Find(x => x.MusteriAd == comboBox1.SelectedItem.ToString()).MusteriId;
            arac.KiralananıSal(aracid);
            gelirgider = arac.GelirGiderler();
            textBox1.Text = gelirgider[0].AracGunlukKar.ToString();

            MessageBox.Show("Arac Bırakıldı");
          
        }

        private void YoneticiKiralamayiBitir_Load(object sender, EventArgs e)
        {
            araclar = arac.KiralananlariGetir();
            dataGridView1.DataSource = araclar;
            MusterilerRepository a = new MusterilerRepository();
            musteriler = a.TumVeriyiGetir();
            for (int i = 0; i < musteriler.Count; i++)
            {
                comboBox1.Items.Add(musteriler[i].MusteriAd);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aracid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            MessageBox.Show(aracid.ToString());
        }
    }
}
