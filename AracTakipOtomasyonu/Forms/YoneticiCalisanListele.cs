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
    public partial class YoneticiCalisanListele : Form
    {
        public List<Kullanicilar> kullanicilar;

        public YoneticiCalisanListele()
        {
            InitializeComponent();
        }

        private void YoneticiCalisanListele_Load(object sender, EventArgs e)
        {

        }

        private void btn_CalisanListele_Click(object sender, EventArgs e)
        {
           
            KullanicilarRepository kullanici = new KullanicilarRepository();
            kullanicilar = kullanici.RolIdyeGoreKullaniciGetir(1);
            for (int i = 0; i < kullanicilar.Count; i++)
            {
                dt_CalListele.DataSource = kullanicilar;
            }
        }
    }
}
