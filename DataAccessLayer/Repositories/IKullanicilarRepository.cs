using ObjectLayer;
using System.Data;

namespace DataAccessLayer.Repositories
{
    public interface IKullanicilarRepository : IBaseRepository<Kullanicilar>
    {
        DataTable AdaGoreKullaniciGetir(string id);
        DataTable SoyadaGoreKullaniciGetir(string id);
        DataTable FirmaIdyeGoreKullaniciGetir(int id);
        DataTable RolIdyeGoreKullaniciGetir(int id);
    }
}
