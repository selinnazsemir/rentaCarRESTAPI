using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    public interface IFirmalarRepository : IBaseRepository<Firmalar>
    {
       List< Firmalar> AdIleFirmaGetir(string ad);
        List<Firmalar> SehirIleFirmaGetir(string sehir);

    }
}
