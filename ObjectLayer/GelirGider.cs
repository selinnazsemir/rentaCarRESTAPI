using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLayer
{
    public class GelirGider
    {
        public string AracMarka { get; set; }
        public string AracModel { get; set; }
        public decimal AracGunlukFiyat { get; set; }
        public decimal Vergi { get; set; }
        public decimal AracGunlukKar{get;set;}
        public decimal ToplamGelirGider { get; set; }
    }
}
