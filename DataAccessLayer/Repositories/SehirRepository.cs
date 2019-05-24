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
    public class SehirRepository : ISehirRepository
    {
        public DataTable AdaGoreGetir(string ad)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Sehirler WHERE SehirAdi LIKE '%" + ad + "%' AND SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Ekle(Sehirler obje)
        {
            try
            {
                Baglanti.BaglantiKontrol();
                var strSql = @"    
                               INSERT INTO [dbo].[Sehirler]
                                                ([SehirAdi])
                                 VALUES
                                       ('" + obje.SehirAdi + "');";
                SqlCommand sqlCommand = new SqlCommand(strSql, Baglanti.sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { }
            return false;
        }

        public bool Guncelle(Sehirler obje)
        {
            try
            {
                string strSql = @"UPDATE Sehirler SET SehirAdi = '" + obje.SehirAdi +", SilindiMi = '" + obje.SilindiMi + "' WHERE SehirId = '" + obje.SehirId + "'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable IdyeGoreGetir(int Id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Sehirler WHERE SehirId='" + Id + "' AND SilindiMi=0 ";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Sil(Sehirler obje)
        {
            try
            {
                string strSql = "UPDATE Sehirler SET SilindiMi = 1 WHERE SehirId = '" + obje.SehirId + "'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable TumVeriyiGetir()
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Sehirler WHERE SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }
    }
}
