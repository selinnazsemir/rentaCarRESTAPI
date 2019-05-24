using ObjectLayer;
using System.Collections.Generic;

namespace BusinessLayer.Repositories
{
    public interface IKullanicilarRepository : IBaseRepository<Kullanicilar>
    {
        List<Kullanicilar> AdaGoreKullaniciGetir(string id);
        List<Kullanicilar> SoyadaGoreKullaniciGetir(string id);
        List<Kullanicilar> FirmaIdyeGoreKullaniciGetir(int id);
        List<Kullanicilar> RolIdyeGoreKullaniciGetir(int id);
    }
}
