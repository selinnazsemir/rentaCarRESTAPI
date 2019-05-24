using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectLayer;

namespace BusinessLayer.Repositories
{
    public class SehirlerRepository : ISehirRepository
    {
        DataAccessLayer.Repositories.SehirRepository repo = new DataAccessLayer.Repositories.SehirRepository();
        public List<Sehirler> AdaGoreGetir(string ad)
        {
            List<Sehirler> sehirler = null;
            Sehirler sehir = null;
            DataTable dt = repo.AdaGoreGetir(ad);
            if (dt != null)
            {
                sehirler = new List<Sehirler>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sehir = new Sehirler()
                    {
                        SehirId = Convert.ToInt32(dt.Rows[i]["SehirId"]),
                        SehirAdi = dt.Rows[i]["SehirAdi"].ToString(),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    sehirler.Add(sehir);
                }
            }
            return sehirler;
        }

        public bool Ekle(Sehirler obje)
        {
            return repo.Ekle(obje);
        }

        public bool Guncelle(Sehirler obje)
        {
            return repo.Guncelle(obje);
        }

        public Sehirler IdyeGoreGetir(int Id)
        {
            
            Sehirler sehir = null;
            DataTable dt = repo.IdyeGoreGetir(Id);
            if (dt != null)
            {
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sehir = new Sehirler()
                    {
                        SehirId = Convert.ToInt32(dt.Rows[i]["SehirId"]),
                        SehirAdi = dt.Rows[i]["SehirAdi"].ToString(),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    
                }
            }
            return sehir;
        }

        public bool Sil(Sehirler obje)
        {
            return repo.Sil(obje);
        }

        public List<Sehirler> TumVeriyiGetir()
        {
            List<Sehirler> sehirler = null;
            Sehirler sehir = null;
            DataTable dt = null;
            dt = repo.TumVeriyiGetir();
            if (dt != null)
            {
                sehirler = new List<Sehirler>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sehir = new Sehirler()
                    {
                        SehirId = Convert.ToInt32(dt.Rows[i]["SehirId"]),
                        SehirAdi = dt.Rows[i]["SehirAdi"].ToString(),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    sehirler.Add(sehir);
                }
            }
            return sehirler;
        }
    }
}
