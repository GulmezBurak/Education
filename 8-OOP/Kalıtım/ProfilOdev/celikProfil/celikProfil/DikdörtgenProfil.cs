using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celikProfil
{
    internal class DikdörtgenProfil:TemelUrun
    {
        public double KisaKenar { get; set; }
        public double UzunKenar { get; set; }
        public override double TabanAlan()
        {
            return KisaKenar * UzunKenar;
        }
    }
}
