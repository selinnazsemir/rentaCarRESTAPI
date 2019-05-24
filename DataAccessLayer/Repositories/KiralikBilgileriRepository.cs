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
    public class KiralikBilgileriRepository : IKiralikBilgileriRepository
    {
        public DataTable AracIdyeGoreKiralikBilgisiGetir(int id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM KiralikBilgileri WHERE AracId='" + id + "'AND SilindiMi=0 ";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable AracKmIdyeGoreKiralikBilgisiGetir(int id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM KiralikBilgileri WHERE AracKmId='" + id + "'AND SilindiMi=0 ";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Ekle(KiralikBilgileri obje)
        {
            try
            {
                Baglanti.BaglantiKontrol();
                var strSql = @"    
                             [dbo].[KiralikBilgileri]
                                  ([KiralikId]
                                 ,[AracId]
                                 ,[FirmaId]
                                ,[MusteriId]
                                 ,[KiralikZamanBaslangic]
                                ,[KiralikZamanBitis]
                                ,[AracKmId]
                                ,[KiralikUcret])
                                 VALUES
                                       ('" + obje.AracId + "','" + obje.FirmaId + "', '" + obje.MusteriId
                                           + "', '" + obje.KiralikZamanBaslangic + "', '" + obje.KiralikZamanBitis + "','" + obje.AracKmId + "'"
                                           +",'" + obje.KiralikUcret + "');";
                SqlCommand sqlCommand = new SqlCommand(strSql, Baglanti.sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { }
            return false;
        }

        public DataTable FirmaIdyeGoreKiralikBilgisiGetir(int id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM KiralikBilgileri WHERE FirmaId='" + id + "'AND SilindiMi=0 ";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Guncelle(KiralikBilgileri obje)
        {
            try
            {
                string strSql = @"UPDATE KiralikBilgileri SET AracId = '" + obje.AracId + "', FirmaId = '" + obje.FirmaId
                                + "', MusteriId = '" + obje.MusteriId + "', KiralikZamanBaslangic = '" + obje.KiralikZamanBaslangic  + "', KiralikZamanBitis = '" + obje.KiralikZamanBitis
                                + "', AracKmId = '" + obje.AracKmId + "' WHERE AracKmId = '" + obje.AracKmId + "'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable IdyeGoreGetir(int Id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM KiralikBilgileri WHERE KiralikId='" + Id + "'AND SilindiMi=0 ";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable MusteriIdyeGoreKiralikBilgisiGetir(int id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM KiralikBilgileri WHERE MusteriId='" + id + "'AND SilindiMi=0 ";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Sil(KiralikBilgileri obje)
        {
            try
            {
                string strSql = "UPDATE KiralikBilgileri SET SilindiMi = 1 WHERE KiralikId = '" + obje.KiralikId + "'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable TumVeriyiGetir()
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM KiralikBilgileri WHERE SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }
    }
}
