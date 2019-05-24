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
    public partial class YoneticiAracKiralayanlar : Form
    {
        public List<Musteriler> musteriler;
        public List<Araclar> araclar;

        public YoneticiAracKiralayanlar()
        {
            InitializeComponent();
        }

        private void btn_MusteridekiKiralikAraclar_Click(object sender, EventArgs e)
        {
            //sor sor sor
            MusterilerRepository arac = new MusterilerRepository();
            Musteriler m = new Musteriler();
            m.MusteriId = musteriler.Find(x => x.MusteriAd == cmb_MusteriSec.SelectedItem.ToString()).MusteriId;
            dt_MusteridekiKiralikAraclar.DataSource = arac.MusteridekiAraclar(m.MusteriId); 
        }

        private void YoneticiAracKiralayanlar_Load(object sender, EventArgs e)
        {
            MusterilerRepository b = new MusterilerRepository();
            musteriler = b.TumVeriyiGetir();
            for (int i = 0; i < musteriler.Count; i++)
            {
                cmb_MusteriSec.Items.Add(musteriler[i].MusteriAd);
            }
        }
    }
}
