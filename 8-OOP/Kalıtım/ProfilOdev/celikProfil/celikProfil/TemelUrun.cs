using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celikProfil
{
    internal class TemelUrun:IUrun
    {
        public int Id { get; set; }
        public string UrunAd { get; set; }
        public double Yukseklik { get; set; }

        public double Fire()
        {
            return Convert.ToDouble(Hacim() * .30);
        }

        public double Hacim()
        {
            return TabanAlan() * Yukseklik;
        }

        //public double TabanAlan()
        //{
        //    throw new NotImplementedException();
        //}

        public virtual double TabanAlan()
        {
            return Math.Pow(Yukseklik, 2);
            //Pow dakı 2 karesi demek..
        }
    }
}
