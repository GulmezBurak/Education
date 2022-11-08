using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm2.Data
{
    internal class Urun
    {
        public int Id { get; set; }
        public string UrunAd { get; set; }
        public decimal Fiyat { get; set; }
        public override string ToString()
        {
            return UrunAd + " " + Fiyat;
        }
    }
}
