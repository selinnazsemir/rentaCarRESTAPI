using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IKiralikBilgileriRepository : IBaseRepository<KiralikBilgileri>
    {
        DataTable AracIdyeGoreKiralikBilgisiGetir(int id);
        DataTable FirmaIdyeGoreKiralikBilgisiGetir(int id);
        DataTable MusteriIdyeGoreKiralikBilgisiGetir(int id);
        DataTable AracKmIdyeGoreKiralikBilgisiGetir(int id);
    }
}
