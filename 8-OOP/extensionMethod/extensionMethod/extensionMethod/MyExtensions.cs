using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionMethod
{
    public static class MyExtensions
    {
        public static string IlkHarfBuyuk(this string txt) //'this' stringe ek özellik kat demek
        {
            return txt.Substring(0, 1).ToUpper() + txt.Substring(1);
        }
        public static string AyYaz(this DateTime tar)
        {
            string ayAd = "";
            int ay = tar.Month;
            if (ay == 1)
            {
                ayAd = "Ocak";
            }
            else if (ay == 2)
            {
                ayAd = "Şubat";
            }
            else if (ay == 3)
            {
                ayAd = "Mart";
            }
            else if (ay == 4)
            {
                ayAd = "Nisan";
            }
            else if (ay == 5)
            {
                ayAd = "Mayıs";
            }
            else if (ay == 6)
            {
                ayAd = "Haziran";
            }
            else if (ay == 7)
            {
                ayAd = "Temmuz";
            }
            else if (ay == 8)
            {
                ayAd = "Ağustos";
            }
            else if (ay == 9)
            {
                ayAd = "Eylül";
            }
            else if (ay == 10)
            {
                ayAd = "Ekim";
            }
            else if (ay == 11)
            {
                ayAd = "Kasım";
            }
            else if (ay == 12)
            {
                ayAd = "Aralık";
            }
            return ayAd;

        }
    }
}
