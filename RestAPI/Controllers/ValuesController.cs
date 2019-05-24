using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Giris;

namespace RestAPI.Controllers
{
    public class ValuesController : ApiController
    {
        Kullanicilar k = null;
        Giris g = new Giris();
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet]
        [Route("Giris")]
        public bool Get(string kadi, string parola)
        {
            k = new Kullanicilar()
            {
                KullaniciAdi = kadi,
                KullaniciParola = HelperLayer.Helper.MD5eDonustur(parola)
            };
            return g.RestGiris(k);
        }


        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
