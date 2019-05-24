using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IAraclarRepository : IBaseRepository<Araclar>
    {
        DataTable MarkayaGoreGetir(string marka);
        DataTable ModeleGoreGetir(string model);
        DataTable YilaGoreGetir(int yil);
        DataTable AracGunlukFiyataGoreGetir(decimal fiyat);
        DataTable FirmaIdyeGoreGetir(int id);
        DataTable KiralandiMiyeGoreGetir();

        DataTable GelirGider();
        DataTable ToplamGelirGider();
        DataTable Ortalama(string baslangicTarihi);
        bool KiralananıSal(int id);
        DataTable VergiHesapla();
        DataTable KiralanmayanlariGetir();
        DataTable KiralananlariGetir();
        bool Kirala(int id);
    }
}
