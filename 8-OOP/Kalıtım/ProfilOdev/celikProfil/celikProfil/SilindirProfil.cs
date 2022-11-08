using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celikProfil
{
    internal class SilindirProfil:TemelUrun
    {
        public double Yaricap { get; set; }
        public override double TabanAlan()
        {
            return Math.PI * Math.Pow(Yaricap, 2);
        }
    }
}
