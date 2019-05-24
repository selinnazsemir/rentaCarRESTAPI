using ObjectLayer;
using System.Data;

namespace DataAccessLayer.Repositories
{
    public interface IFirmalarRepository : IBaseRepository<Firmalar>
    {
        DataTable AdIleFirmaGetir(string ad);
        DataTable AdIleFirmaIdGetir(string ad);
        DataTable SehirIleFirmaGetir(string sehir);
    }
}
