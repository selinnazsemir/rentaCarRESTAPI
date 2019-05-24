using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace DataAccessLayer.Veritabani
{
    public class Baglanti
    {
        public static SqlConnection sqlConnection = new SqlConnection("server=.; Initial Catalog=AracTakipOtomasyonu; Integrated Security=SSPI; MultipleActiveResultSets=True");
        public static void BaglantiKontrol()
        {
            if(sqlConnection.State == ConnectionState.Closed)
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı kurulamadı,\r\n Açıklama: " + ex.Message , "Hata");
                }
            }
        }
        public static DataTable VeriGetir(string strSql)
        {
            DataTable dataTable = new DataTable();
            try
            {
                BaglantiKontrol();
                SqlCommand sqlCommand = new SqlCommand(strSql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dataTable.Load(sqlDataReader);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Veritabanından veri çekilemedi,\r\n Açıklama: " + ex.Message + "\r\nSql: +" + strSql, "Hata");
            }
            return dataTable;
        }
        public static void VeriSil(string tabloAdi, int kayitId, string anahtarIsmi)
        {
            string strSql = @"UPDATE {0} SET SilindiMi = 1 WHERE {1} = {2};";
            string.Format(strSql, tabloAdi, anahtarIsmi, kayitId);
            try
            {
                BaglantiKontrol();
                SqlCommand sqlCommand = new SqlCommand(strSql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından veri silinemedi.,\r\n Açıklama: " + ex.Message + "\r\nSql: +" + strSql, "Hata");
            }
        }
        public static void VeriGuncelle(string strSql)
        {
            try
            {
                BaglantiKontrol();
                SqlCommand sqlCommand = new SqlCommand(strSql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanında veri güncellenemedi.,\r\n Açıklama: " + ex.Message + "\r\nSql: +" + strSql, "Hata");
            }
        }
        public static bool VeriVarmi(string strSql)
        {
            try
            {
                BaglantiKontrol();
                SqlCommand sqlCommand = new SqlCommand(strSql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından veri okunamadı.,\r\n Açıklama: " + ex.Message + "\r\nSql: +" + strSql, "Hata");
            }
            return false;
        }
        public static bool GetData(string a)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                try
                {
                    sqlConnection.Open();
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("EXEC OrtalamakmGunTariheGore '" + a + "'", sqlConnection);
                    SqlDataReader dr = cmd.ExecuteReader();

                    dt.Load(dr);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı kurulamadı,\r\n Açıklama: " + ex.Message, "Hata");
                }
            }

            return true;
        }
    }
}
