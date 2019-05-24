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
    public partial class YoneticiCalisanGuncelle : Form
    {
        public YoneticiCalisanGuncelle()
        {
            InitializeComponent();
        }
        public List<Kullanicilar> kullanici;
        public static Kullanicilar k = null;
        public static Kullanicilar t = null;
        KullanicilarRepository calisan = new KullanicilarRepository();
        private void YoneticiCalisanGuncelle_Load(object sender, EventArgs e)
        {
            kullanici = calisan.RolIdyeGoreKullaniciGetir((int)KullaniciRolleri.Calisan);
            dt_CalısanlarıGor.DataSource = kullanici;
        }
        private void dt_CalısanlarıGor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            k = calisan.IdyeGoreGetir(Convert.ToInt32(dt_CalısanlarıGor.SelectedRows[0].Cells[0].Value));
            txt_CalisanAd.Text = k.KullaniciAd;
            txt_CalisanAdi.Text = k.KullaniciAd;
            txt_CalisanSoyad.Text = k.KullaniciSoyad;
            txt_CalisanSifre.Text = k.KullaniciParola;
        }

        private void btn_CalisanGuncelle_Click(object sender, EventArgs e)
        {
            t = new Kullanicilar()
            {
                FirmaId = k.FirmaId,
                KullaniciAd = txt_CalisanAd.Text,
                KullaniciAdi = txt_CalisanAdi.Text,
                KullaniciParola = HelperLayer.Helper.MD5eDonustur(txt_CalisanSifre.Text),
                KullaniciSoyad = txt_CalisanSoyad.Text,
                RolId = k.RolId,
                KullaniciId = k.KullaniciId
            };
            
                calisan.Guncelle(t);
        }
    }
}
