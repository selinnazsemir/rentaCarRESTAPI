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
    public partial class AracOzellikGor : Form
    {
        public List<GelirGider> araclar;
        
        public AracOzellikGor()
        {
            InitializeComponent();
        }

        private void btn_AracOzListele_Click(object sender, EventArgs e)
        {
            AraclarRepository arac = new AraclarRepository();
            araclar = arac.GelirGiderler();
           
            for (int i = 0; i < araclar.Count; i++)
            {
                dt_AracOzGor.DataSource = araclar;
                dt_AracOzGor.Columns[5].Visible = false;
            }
            araclar = arac.ToplamGelirGider();
            txtGelirGider.Text = araclar[0].ToplamGelirGider.ToString();
        }
    }
}
