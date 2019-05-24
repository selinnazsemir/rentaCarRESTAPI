using ObjectLayer;
using System.Data;

namespace DataAccessLayer.Repositories
{
    public interface IMusterilerRepository : IBaseRepository<Musteriler>
    {
        DataTable MusteridekiAraclar(int id);
        DataTable TCKNOIleMusteriGetir(int id);
        DataTable EhliyetNOIleMusteriGetir(int id);
        DataTable AdIleMusteriGetir(string id);
        DataTable SoyAdIleMusteriGetir(string id);
    }
}

