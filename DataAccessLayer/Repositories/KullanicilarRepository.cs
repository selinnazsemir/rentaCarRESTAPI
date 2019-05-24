using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Veritabani;
using ObjectLayer;

namespace DataAccessLayer.Repositories
{
    public class KullanicilarRepository : IKullanicilarRepository
    {
        public DataTable AdaGoreKullaniciGetir(string id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Kullanicilar WHERE KullaniciAd LIKE '%" + id + "%' AND SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Ekle(Kullanicilar obje)
        {
            try
            {
                Baglanti.BaglantiKontrol();
                var strSql = @"    
                                INSERT INTO [dbo].[Kullanicilar]
                                       ([KullaniciAd]
                                       ,[KullaniciSoyad]
                                       ,[FirmaId]
                                       ,[KullaniciAdi]
                                       ,[KullaniciParola]
                                       ,[RolId])
                                 VALUES
                                       ('" + obje.KullaniciAd + "','" + obje.KullaniciSoyad + "', '" + obje.FirmaId
                                           + "', '" + obje.KullaniciAdi + "', '" + obje.KullaniciParola + "','" + obje.RolId + "');";
                SqlCommand sqlCommand = new SqlCommand(strSql, Baglanti.sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { }
            return false;
        }

        public DataTable FirmaIdyeGoreKullaniciGetir(int id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Kullanicilar WHERE FirmaId='" + id + "' AND SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Guncelle(Kullanicilar obje)
        {
            try
            {
                string strSql = @"UPDATE Kullanicilar SET KullaniciAd = '" + obje.KullaniciAd + "', KullaniciSoyad = '" + obje.KullaniciSoyad
                                + "', FirmaId = '" + obje.FirmaId + "', KullaniciAdi = '" + obje.KullaniciAdi + "', KullaniciParola = '" + obje.KullaniciParola
                                + "', RolId = '" + obje.RolId + "' WHERE KullaniciId = '" + obje.KullaniciId + "'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable IdyeGoreGetir(int Id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Kullanicilar WHERE KullaniciId='" + Id + "' AND SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable RolIdyeGoreKullaniciGetir(int id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Kullanicilar WHERE RolId='" + id + "' AND SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Sil(Kullanicilar obje)
        {
            try
            {
                string strSql = "UPDATE Kullanicilar SET SilindiMi = 1 WHERE KullaniciId = '" + obje.KullaniciId + "'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable SoyadaGoreKullaniciGetir(string id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Kullanicilar WHERE KullaniciSoyad LIKE '%" + id + "%' AND SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable TumVeriyiGetir()
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Kullanicilar WHERE SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }
    }
}
