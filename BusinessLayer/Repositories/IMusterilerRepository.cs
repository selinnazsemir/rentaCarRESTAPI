using ObjectLayer;
using System.Collections.Generic;

namespace BusinessLayer.Repositories
{
    public interface IMusterilerRepository : IBaseRepository<Musteriler>
    {
        List<MusteridekiAraclar> MusteridekiAraclar(int id);
        Musteriler TCKNOIleMusteriGetir(int id);
        Musteriler EhliyetNOIleMusteriGetir(int id);
        List<Musteriler> AdIleMusteriGetir(string id);
        List<Musteriler> SoyAdIleMusteriGetir(string id);
    }
}

