using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// WebService1 için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class VeriEkle : System.Web.Services.WebService
    {
        BusinessLayer.Repositories.KullanicilarRepository repo = new BusinessLayer.Repositories.KullanicilarRepository();
        BusinessLayer.Repositories.AraclarRepository aracRepo = new BusinessLayer.Repositories.AraclarRepository();
        //Şehir getir, firma getir, araç getir, araç km log getir, kullanıcı getir, müşteri getir, kiralik bilgi getir
        //Firma ekle, araç ekle, araç km log ekle, kullanıcı ekle, müşteri ekle, kiralık bilgi ekle
        [WebMethod]
        public bool KullaniciEkle(string KullaniciAd, string KullaniciSoyad, int FirmaId, string KullaniciAdi, string KullaniciParola, int RolId)
        {
            Kullanicilar kullanici = new Kullanicilar()
            {
                FirmaId = FirmaId,
                KullaniciAd = KullaniciAd,
                KullaniciAdi = KullaniciAdi,
                KullaniciParola = HelperLayer.Helper.MD5eDonustur(KullaniciParola),
                KullaniciSoyad = KullaniciSoyad,
                RolId = RolId
            };
            return repo.Ekle(kullanici);
        }
        [WebMethod]
        public List<Araclar> Araclar()
        {
            List<Araclar> a = new List<Araclar>();
            a = aracRepo.TumVeriyiGetir();
            return a;
        }
    }
}
