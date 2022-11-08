using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basitKatilim
{
    internal class Egitmen: Temel
    {
        public int Maas { get; set; }
        public string Unvan { get; set; }
        int MaasHesapla()
        {
            return Convert.ToInt32(Maas * .70);
        }

    }
}
