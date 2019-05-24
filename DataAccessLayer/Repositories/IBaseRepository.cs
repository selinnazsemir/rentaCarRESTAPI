using System.Collections.Generic;
using System.Data;
namespace DataAccessLayer.Repositories
{
    public interface IBaseRepository<Object> where Object : class
    {

        bool Ekle(Object obje);
        bool Sil(Object obje);
        bool Guncelle(Object obje);
        DataTable TumVeriyiGetir();
        DataTable IdyeGoreGetir(int Id);
    }
}
