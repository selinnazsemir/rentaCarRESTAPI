using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    public interface IKiralikBilgileriRepository : IBaseRepository<KiralikBilgileri>
    {
        List<KiralikBilgileri> AracIdyeGoreKiralikBilgisiGetir(int id);
        List<KiralikBilgileri> FirmaIdyeGoreKiralikBilgisiGetir(int id);
        List<KiralikBilgileri> MusteriIdyeGoreKiralikBilgisiGetir(int id);
        List<KiralikBilgileri> AracKmIdyeGoreKiralikBilgisiGetir(int id);
    }
}
