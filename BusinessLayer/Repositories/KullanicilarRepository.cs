using System;
using System.Collections.Generic;
using System.Data;
using ObjectLayer;

namespace BusinessLayer.Repositories
{
    public class KullanicilarRepository : IKullanicilarRepository
    {
        DataAccessLayer.Repositories.KullanicilarRepository repo = new DataAccessLayer.Repositories.KullanicilarRepository();
        public List<Kullanicilar> AdaGoreKullaniciGetir(string id)
        {
            List<Kullanicilar> kullanicilar = null;
            Kullanicilar kullanici = null;
            DataTable dt = repo.AdaGoreKullaniciGetir(id);
            if (dt != null)
            {
                kullanicilar = new List<Kullanicilar>();
                for (int i = 0; i < dt.Rows.Count; i++) 
                {
                    kullanici = new Kullanicilar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        KullaniciAd = dt.Rows[i]["KullaniciAd"].ToString(),
                        KullaniciAdi = dt.Rows[i]["KullaniciAdi"].ToString(),
                        KullaniciParola = dt.Rows[i]["KullaniciParola"].ToString(),
                        KullaniciSoyad = dt.Rows[i]["KullaniciSoyad"].ToString(),
                        RolId = Convert.ToInt32(dt.Rows[i]["RolId"]),
                        KullaniciId = Convert.ToInt32(dt.Rows[i]["KullaniciId"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    kullanicilar.Add(kullanici);
                }
            }
            return kullanicilar;
        }

        public bool Ekle(Kullanicilar obje)
        {
            return repo.Ekle(obje);
        }

        public List<Kullanicilar> FirmaIdyeGoreKullaniciGetir(int id)
        {
            DataTable dt = null;
            Kullanicilar kullanici = null;
            List<Kullanicilar> kullanicilar = null;
            dt = repo.FirmaIdyeGoreKullaniciGetir(id);
            if (dt != null)
            {
                kullanicilar = new List<Kullanicilar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    kullanici = new Kullanicilar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        KullaniciAd = dt.Rows[i]["KullaniciAd"].ToString(),
                        KullaniciAdi = dt.Rows[i]["KullaniciAdi"].ToString(),
                        KullaniciParola = dt.Rows[i]["KullaniciParola"].ToString(),
                        KullaniciSoyad = dt.Rows[i]["KullaniciSoyad"].ToString(),
                        RolId = Convert.ToInt32(dt.Rows[i]["RolId"]),
                        KullaniciId = Convert.ToInt32(dt.Rows[i]["KullaniciId"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    kullanicilar.Add(kullanici);
                }
            }
            return kullanicilar;
        }

        public bool Guncelle(Kullanicilar obje)
        {
            return repo.Guncelle(obje);
        }

        public Kullanicilar IdyeGoreGetir(int Id)
        {
            DataTable dt = null;
            Kullanicilar kullanici = null;
            dt = repo.IdyeGoreGetir(Id);
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    kullanici = new Kullanicilar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        KullaniciAd = dt.Rows[i]["KullaniciAd"].ToString(),
                        KullaniciAdi = dt.Rows[i]["KullaniciAdi"].ToString(),
                        KullaniciParola = dt.Rows[i]["KullaniciParola"].ToString(),
                        KullaniciSoyad = dt.Rows[i]["KullaniciSoyad"].ToString(),
                        RolId = Convert.ToInt32(dt.Rows[i]["RolId"]),
                        KullaniciId = Convert.ToInt32(dt.Rows[i]["KullaniciId"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                }
            }
            return kullanici;
        }

        public List<Kullanicilar> RolIdyeGoreKullaniciGetir(int id)
        {
            DataTable dt = null;
            Kullanicilar kullanici = null;
            List<Kullanicilar> kullanicilar = null;
            dt = repo.RolIdyeGoreKullaniciGetir(id);
            if (dt != null)
            {
                kullanicilar = new List<Kullanicilar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    kullanici = new Kullanicilar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        KullaniciAd = dt.Rows[i]["KullaniciAd"].ToString(),
                        KullaniciAdi = dt.Rows[i]["KullaniciAdi"].ToString(),
                        KullaniciParola = dt.Rows[i]["KullaniciParola"].ToString(),
                        KullaniciSoyad = dt.Rows[i]["KullaniciSoyad"].ToString(),
                        RolId = Convert.ToInt32(dt.Rows[i]["RolId"]),
                        KullaniciId = Convert.ToInt32(dt.Rows[i]["KullaniciId"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    kullanicilar.Add(kullanici);
                }
            }
            return kullanicilar;
        }

        public bool Sil(Kullanicilar obje)
        {
            return repo.Sil(obje);
        }

        public List<Kullanicilar> SoyadaGoreKullaniciGetir(string id)
        {
            List<Kullanicilar> kullanicilar = null;
            Kullanicilar kullanici = null;
            DataTable dt = null;
            dt = repo.SoyadaGoreKullaniciGetir(id);
            if (dt != null)
            {
                kullanicilar = new List<Kullanicilar>();
                for (int i = 0; i <dt.Rows.Count; i++)
                {
                    kullanici = new Kullanicilar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        KullaniciAd = dt.Rows[i]["KullaniciAd"].ToString(),
                        KullaniciAdi = dt.Rows[i]["KullaniciAdi"].ToString(),
                        KullaniciParola = dt.Rows[i]["KullaniciParola"].ToString(),
                        KullaniciSoyad = dt.Rows[i]["KullaniciSoyad"].ToString(),
                        RolId = Convert.ToInt32(dt.Rows[i]["RolId"]),
                        KullaniciId = Convert.ToInt32(dt.Rows[i]["KullaniciId"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    kullanicilar.Add(kullanici);
                }
            }
            return kullanicilar;
        }

        public List<Kullanicilar> TumVeriyiGetir()
        {
            List<Kullanicilar> kullanicilar = null;
            Kullanicilar kullanici = null;
            DataTable dt = null;
            dt = repo.TumVeriyiGetir();
            if (dt != null)
            {
                kullanicilar = new List<Kullanicilar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    kullanici = new Kullanicilar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        KullaniciAd = dt.Rows[i]["KullaniciAd"].ToString(),
                        KullaniciAdi = dt.Rows[i]["KullaniciAdi"].ToString(),
                        KullaniciParola = dt.Rows[i]["KullaniciParola"].ToString(),
                        KullaniciSoyad = dt.Rows[i]["KullaniciSoyad"].ToString(),
                        RolId = Convert.ToInt32(dt.Rows[i]["RolId"]),
                        KullaniciId = Convert.ToInt32(dt.Rows[i]["KullaniciId"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    kullanicilar.Add(kullanici);
                }
            }
            return kullanicilar;
        }
    }
}
