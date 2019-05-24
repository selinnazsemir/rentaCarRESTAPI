using ObjectLayer;
using System.Data;

namespace DataAccessLayer.Repositories
{
    public interface IAracKmRepository : IBaseRepository<AracKmler>
    {
        DataTable AracIdyeGoreGetir(int id);
    }
}
