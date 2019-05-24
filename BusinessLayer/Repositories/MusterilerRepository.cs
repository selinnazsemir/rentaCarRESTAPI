using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLayer.Repositories
{
    public class MusterilerRepository : IMusterilerRepository
    {
        DataAccessLayer.Repositories.MusterilerRepository repo = new DataAccessLayer.Repositories.MusterilerRepository();
        public List<Musteriler> AdIleMusteriGetir(string id)
        {
            List<Musteriler> musteriler = null;
            Musteriler musteri = null;
            DataTable dt = repo.AdIleMusteriGetir(id);
            if (dt != null)
            {
                musteriler = new List<Musteriler>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    musteri = new Musteriler()
                    {
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"]),
                        MusteriAd = dt.Rows[i]["MusteriAd"].ToString(),
                        MusteriSoyad = dt.Rows[i]["MusteriSoyad"].ToString(),
                        MusteriEhliyetNo = Convert.ToInt32(dt.Rows[i]["MusteriEhliyetNo"]),
                        MusteriEmail = dt.Rows[i]["MusteriEmai"].ToString(),
                        MusteriTelNo = dt.Rows[i]["MusteriTelNo"].ToString(),
                        MusteriTCKNo = Convert.ToInt32(dt.Rows[i]["MusteriTCKNo"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    musteriler.Add(musteri);
                }
            }
            return musteriler;
        }

        public Musteriler EhliyetNOIleMusteriGetir(int id)
        {

            Musteriler musteri = null;
            DataTable dt = null;
            dt = repo.EhliyetNOIleMusteriGetir(id);
            if (dt != null)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    musteri = new Musteriler()
                    {
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"]),
                        MusteriAd = dt.Rows[i]["MusteriAd"].ToString(),
                        MusteriSoyad = dt.Rows[i]["MusteriSoyad"].ToString(),
                        MusteriEhliyetNo = Convert.ToInt32(dt.Rows[i]["MusteriEhliyetNo"]),
                        MusteriEmail = dt.Rows[i]["MusteriEmai"].ToString(),
                        MusteriTelNo = dt.Rows[i]["MusteriTelNo"].ToString(),
                        MusteriTCKNo = Convert.ToInt32(dt.Rows[i]["MusteriTCKNo"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };

                }
            }
            return musteri;
        }

        public bool Ekle(Musteriler obje)
        {
            return repo.Ekle(obje);
        }

        public bool Guncelle(Musteriler obje)
        {
            return repo.Guncelle(obje);
        }

        public Musteriler IdyeGoreGetir(int Id)
        {
            Musteriler musteri = null;
            DataTable dt = null;
            dt = repo.IdyeGoreGetir(Id);
            if (dt != null)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    musteri = new Musteriler()
                    {
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"]),
                        MusteriAd = dt.Rows[i]["MusteriAd"].ToString(),
                        MusteriSoyad = dt.Rows[i]["MusteriSoyad"].ToString(),
                        MusteriEhliyetNo = Convert.ToInt32(dt.Rows[i]["MusteriEhliyetNo"]),
                        MusteriEmail = dt.Rows[i]["MusteriEmail"].ToString(),
                        MusteriTelNo = dt.Rows[i]["MusteriTelNo"].ToString(),
                        MusteriTCKNo = Convert.ToInt32(dt.Rows[i]["MusteriTCKNo"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };

                }
                
            }
            return musteri;
        }

        public List<MusteridekiAraclar> MusteridekiAraclar(int id)
        {
            List<MusteridekiAraclar> araclar = null;
            MusteridekiAraclar arac = null;
            DataTable dt = null;
            dt = repo.MusteridekiAraclar(id);
            if (dt != null)
            {
                araclar = new List<MusteridekiAraclar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arac = new MusteridekiAraclar()
                    {
                        AracMarka= dt.Rows[i]["AracMarka"].ToString(),
                        AracModel= dt.Rows[i]["AracModel"].ToString(),
                        AracPlakaNo= dt.Rows[i]["AracPlakaNo"].ToString(),
                        AracYil = Convert.ToInt32(dt.Rows[i]["AracYil"]),
                        KiralikZamanBaslangic= Convert.ToDateTime(dt.Rows[i]["KiralikZamanBaslangic"]),
                        KiralikZamanBitis = Convert.ToDateTime(dt.Rows[i]["KiralikZamanBitis"]),
                        KalanGun= Convert.ToInt32(dt.Rows[i]["KalanGun"])
                    };
                    araclar.Add(arac);
                }
            }
            return araclar;
        }//İso KArşıme Sor

        public bool Sil(Musteriler obje)
        {
            return repo.Sil(obje);
        }

        public List<Musteriler> SoyAdIleMusteriGetir(string id)
        {
            List<Musteriler> musteriler = null;
            Musteriler musteri = null;
            DataTable dt = repo.SoyAdIleMusteriGetir(id);
            if (dt != null)
            {
                musteriler = new List<Musteriler>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    musteri = new Musteriler()
                    {
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"]),
                        MusteriAd = dt.Rows[i]["MusteriAd"].ToString(),
                        MusteriSoyad = dt.Rows[i]["MusteriSoyad"].ToString(),
                        MusteriEhliyetNo = Convert.ToInt32(dt.Rows[i]["MusteriEhliyetNo"]),
                        MusteriEmail = dt.Rows[i]["MusteriEmai"].ToString(),
                        MusteriTelNo = dt.Rows[i]["MusteriTelNo"].ToString(),
                        MusteriTCKNo = Convert.ToInt32(dt.Rows[i]["MusteriTCKNo"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    musteriler.Add(musteri);
                }
            }
            return musteriler;
        }

        public Musteriler TCKNOIleMusteriGetir(int id)
        {
            Musteriler musteri = null;
            DataTable dt = null;
            dt = repo.TCKNOIleMusteriGetir(id);
            if (dt != null)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    musteri = new Musteriler()
                    {
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"]),
                        MusteriAd = dt.Rows[i]["MusteriAd"].ToString(),
                        MusteriSoyad = dt.Rows[i]["MusteriSoyad"].ToString(),
                        MusteriEhliyetNo = Convert.ToInt32(dt.Rows[i]["MusteriEhliyetNo"]),
                        MusteriEmail = dt.Rows[i]["MusteriEmai"].ToString(),
                        MusteriTelNo = dt.Rows[i]["MusteriTelNo"].ToString(),
                        MusteriTCKNo = Convert.ToInt32(dt.Rows[i]["MusteriTCKNo"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };

                }
            }
            return musteri;
        }

        public List<Musteriler> TumVeriyiGetir()
        {
            List<Musteriler> musteriler = null;
            Musteriler musteri = null;
            DataTable dt = null;
            dt = repo.TumVeriyiGetir();
            if (dt != null)
            {
                musteriler = new List<Musteriler>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    musteri = new Musteriler()
                    {
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"]),
                        MusteriAd = dt.Rows[i]["MusteriAd"].ToString(),
                        MusteriSoyad = dt.Rows[i]["MusteriSoyad"].ToString(),
                        MusteriEhliyetNo = Convert.ToInt32(dt.Rows[i]["MusteriEhliyetNo"]),
                        MusteriEmail = dt.Rows[i]["MusteriEmail"].ToString(),
                        MusteriTelNo = dt.Rows[i]["MusteriTelNo"].ToString(),
                        MusteriTCKNo = Convert.ToInt32(dt.Rows[i]["MusteriTCKNo"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    musteriler.Add(musteri);
                }
            }
            return musteriler;
        }
    }
}
