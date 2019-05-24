using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectLayer;

namespace BusinessLayer.Repositories
{
    public class KiralikBilgileriRepository : IKiralikBilgileriRepository
    {
        DataAccessLayer.Repositories.KiralikBilgileriRepository repo =new DataAccessLayer.Repositories.KiralikBilgileriRepository();
        public List<KiralikBilgileri> AracIdyeGoreKiralikBilgisiGetir(int id)
        {
            List<KiralikBilgileri> kiraliklar = null;
            KiralikBilgileri kiralik = null;
            DataTable dt = repo.AracIdyeGoreKiralikBilgisiGetir(id);
            if (dt != null)
            {
                kiraliklar = new List<KiralikBilgileri>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    kiralik = new KiralikBilgileri()
                    {
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"]),
                        KiralikId = Convert.ToInt32(dt.Rows[i]["KiralikId"]),
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracKmId = Convert.ToInt32(dt.Rows[i]["AracKmId"]),
                        KiralikUcret = Convert.ToInt32(dt.Rows[i]["KiralikUcret"]),
                        KiralikZamanBaslangic = Convert.ToDateTime(dt.Rows[i]["KiralikZamanBaslangic"]),
                        KiralikZamanBitis = Convert.ToDateTime(dt.Rows[i]["KiralikZamanBitis"]),
                        SilindiMi= Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    kiraliklar.Add(kiralik);
                }
            }
            return kiraliklar;
        }

        public List<KiralikBilgileri> AracKmIdyeGoreKiralikBilgisiGetir(int id)
        {
            List<KiralikBilgileri> kiraliklar = null;
            KiralikBilgileri kiralik = null;
            DataTable dt = repo.AracKmIdyeGoreKiralikBilgisiGetir(id);
            if (dt != null)
            {
                kiraliklar = new List<KiralikBilgileri>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    kiralik = new KiralikBilgileri()
                    {
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"]),
                        KiralikId = Convert.ToInt32(dt.Rows[i]["KiralikId"]),
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracKmId = Convert.ToInt32(dt.Rows[i]["AracKmId"]),
                        KiralikUcret = Convert.ToInt32(dt.Rows[i]["KiralikUcret"]),
                        KiralikZamanBaslangic = Convert.ToDateTime(dt.Rows[i]["KiralikZamanBaslangic"]),
                        KiralikZamanBitis = Convert.ToDateTime(dt.Rows[i]["KiralikZamanBitis"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    kiraliklar.Add(kiralik);
                }
            }
            return kiraliklar;
        }

        public bool Ekle(KiralikBilgileri obje)
        {
            return repo.Ekle(obje);
        }

        public List<KiralikBilgileri> FirmaIdyeGoreKiralikBilgisiGetir(int id)
        {
            List<KiralikBilgileri> kiraliklar = null;
            KiralikBilgileri kiralik = null;
            DataTable dt = repo.FirmaIdyeGoreKiralikBilgisiGetir(id);
            if (dt != null)
            {
                kiraliklar = new List<KiralikBilgileri>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    kiralik = new KiralikBilgileri()
                    {
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"]),
                        KiralikId = Convert.ToInt32(dt.Rows[i]["KiralikId"]),
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracKmId = Convert.ToInt32(dt.Rows[i]["AracKmId"]),
                        KiralikUcret = Convert.ToInt32(dt.Rows[i]["KiralikUcret"]),
                        KiralikZamanBaslangic = Convert.ToDateTime(dt.Rows[i]["KiralikZamanBaslangic"]),
                        KiralikZamanBitis = Convert.ToDateTime(dt.Rows[i]["KiralikZamanBitis"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    kiraliklar.Add(kiralik);
                }
            }
            return kiraliklar;
        }

        public bool Guncelle(KiralikBilgileri obje)
        {
            return repo.Guncelle(obje);
        }

        public KiralikBilgileri IdyeGoreGetir(int Id)
        {
           
            KiralikBilgileri kiralik = null;
            DataTable dt = repo.IdyeGoreGetir(Id);
            if (dt != null)
            {
               
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    kiralik = new KiralikBilgileri()
                    {
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"]),
                        KiralikId = Convert.ToInt32(dt.Rows[i]["KiralikId"]),
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracKmId = Convert.ToInt32(dt.Rows[i]["AracKmId"]),
                        KiralikUcret = Convert.ToInt32(dt.Rows[i]["KiralikUcret"]),
                        KiralikZamanBaslangic = Convert.ToDateTime(dt.Rows[i]["KiralikZamanBaslangic"]),
                        KiralikZamanBitis = Convert.ToDateTime(dt.Rows[i]["KiralikZamanBitis"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                   
                }
            }
            return kiralik;
        }

        public List<KiralikBilgileri> MusteriIdyeGoreKiralikBilgisiGetir(int id)
        {
            List<KiralikBilgileri> kiraliklar = null;
            KiralikBilgileri kiralik = null;
            DataTable dt = repo.MusteriIdyeGoreKiralikBilgisiGetir(id);
            if (dt != null)
            {
                kiraliklar = new List<KiralikBilgileri>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    kiralik = new KiralikBilgileri()
                    {
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"]),
                        KiralikId = Convert.ToInt32(dt.Rows[i]["KiralikId"]),
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracKmId = Convert.ToInt32(dt.Rows[i]["AracKmId"]),
                        KiralikUcret = Convert.ToInt32(dt.Rows[i]["KiralikUcret"]),
                        KiralikZamanBaslangic = Convert.ToDateTime(dt.Rows[i]["KiralikZamanBaslangic"]),
                        KiralikZamanBitis = Convert.ToDateTime(dt.Rows[i]["KiralikZamanBitis"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    kiraliklar.Add(kiralik);
                }
            }
            return kiraliklar;
        }

        public bool Sil(KiralikBilgileri obje)
        {
            return repo.Sil(obje);
        }

        public List<KiralikBilgileri> TumVeriyiGetir()
        {
            List<KiralikBilgileri> kiraliklar = null;
            KiralikBilgileri kiralik = null;
            DataTable dt = repo.TumVeriyiGetir();
            if (dt != null)
            {
                kiraliklar = new List<KiralikBilgileri>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    kiralik = new KiralikBilgileri()
                    {
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"]),
                        KiralikId = Convert.ToInt32(dt.Rows[i]["KiralikId"]),
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracKmId = Convert.ToInt32(dt.Rows[i]["AracKmId"]),
                        KiralikUcret = Convert.ToInt32(dt.Rows[i]["KiralikUcret"]),
                        KiralikZamanBaslangic = Convert.ToDateTime(dt.Rows[i]["KiralikZamanBaslangic"]),
                        KiralikZamanBitis = Convert.ToDateTime(dt.Rows[i]["KiralikZamanBitis"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    kiraliklar.Add(kiralik);
                }
            }
            return kiraliklar;
        }
    }
}
