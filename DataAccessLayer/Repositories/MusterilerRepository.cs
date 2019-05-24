using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer.Veritabani;
using ObjectLayer;


namespace DataAccessLayer.Repositories
{
    public class MusterilerRepository : IMusterilerRepository
    {
        public DataTable AdIleMusteriGetir(string id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Musteriler WHERE MusteriAd LIKE '%" + id + "%' AND SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable EhliyetNOIleMusteriGetir(int id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Musteriler WHERE MusteriEhliyetNo='" + id + "'AND SilindiMi=0 ";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Ekle(Musteriler obje)
        {
            try
            {
                Baglanti.BaglantiKontrol();
                var strSql = @"
                        INSERT INTO[dbo].[Musteriler]
                        ([MusteriAd]
                         ,[MusteriSoyad]
                        ,[MusteriEhliyetNo]
                        ,[MusteriTCKNo]
                        ,[MusteriTelNo]
                        ,[MusteriEmail])
                        VALUES
                        ('" + obje.MusteriAd + "','" + obje.MusteriSoyad + "', '" + obje.MusteriEhliyetNo
                        + "', '" + obje.MusteriTCKNo + "', '" + obje.MusteriTelNo + "','" + obje.MusteriEmail + "');";

                SqlCommand sqlCommand = new SqlCommand(strSql, Baglanti.sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
            return false;
        }

        public bool Guncelle(Musteriler obje)
        {
            try
            {
                string strSql = @"UPDATE Musteriler SET MusteriAd = '" + obje.MusteriAd + "', MusteriSoyad = '" + obje.MusteriSoyad
                                + "', MusteriEhliyetNo = '" + obje.MusteriEhliyetNo + "', MusteriTCKNo = '" + obje.MusteriTCKNo + "', MusteriTelNo = '" + obje.MusteriTelNo
                                + "', MusteriEmail = '" + obje.MusteriEmail +"' WHERE MusteriId = '" + obje.MusteriId + "'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable IdyeGoreGetir(int Id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Musteriler WHERE MusteriId='" + Id + "' AND SilindiMi=0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable MusteridekiAraclar(int id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM MusteridekiAraclar";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Sil(Musteriler obje)
        {
            try
            {
                string strSql = "UPDATE Musteriler SET SilindiMi = 1 WHERE MusteriId = '" + obje.MusteriId + "'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable SoyAdIleMusteriGetir(string id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Musteriler WHERE LIKE '%" + id + "%' AND SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable TCKNOIleMusteriGetir(int id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Musteriler WHERE MusteriTCKNo='" + id + "' AND SilindiMi=0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable TumVeriyiGetir()
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Musteriler WHERE SilindiMi=0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }
    }
}
