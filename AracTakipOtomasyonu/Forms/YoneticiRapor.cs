using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Repositories;
using DevExpress.XtraCharts;
using ObjectLayer;
using DataAccessLayer.Veritabani;

namespace AracTakipOtomasyonu.Forms
{
    
    public partial class YoneticiRapor : Form
    {
        public YoneticiRapor()
        {
            InitializeComponent();
        }
        public List<Ortalama> araclar;
        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
        public void LoadData()
        {

            chartControl1.DataSource = Baglanti.GetData(dateTimePicker1.Value.ToString("yyyyMMdd"));
            chartControl1.SeriesDataMember = "OrtalamaKm";
            chartControl1.SeriesDataMember = "OrtalamaGun";

        }


        private void button1_Click(object sender, EventArgs e)
        {
            AraclarRepository arac = new AraclarRepository();
            araclar = arac.OrtalamalariGetir(dateTimePicker1.Value.ToString("yyyyMMdd"));

            MessageBox.Show(dateTimePicker1.Value.ToString());
            LoadData();
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {
            AraclarRepository arac = new AraclarRepository();
            
        }

        private void YoneticiRapor_Load(object sender, EventArgs e)
        {
        
        }
    }
}
