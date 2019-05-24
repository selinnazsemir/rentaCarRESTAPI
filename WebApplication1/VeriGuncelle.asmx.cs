using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BusinessLayer.Repositories;

namespace WebApplication1
{
    /// <summary>
    /// KullaniciGuncelle için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class VeriGuncelle : System.Web.Services.WebService
    {
        AraclarRepository repo = new AraclarRepository();
        [WebMethod]
        public bool AracKirala(int id)
        {
            return repo.Kirala(id);
        }
    }
}
