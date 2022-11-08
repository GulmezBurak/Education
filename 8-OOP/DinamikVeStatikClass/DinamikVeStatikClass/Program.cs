using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinamikVeStatikClass;

namespace DinamikVeStatikClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Topkapı üni statiktir.
            Ogrenci o = new Ogrenci();
            o.Ad = "Şamil";
            Universite.Unvan = "Topkapı Üniversitesi";
            Universite.Ilce = "Fatih";
            Console.WriteLine("");
            // Console c = new Console();
            Random r = new Random();
        }
    }
}
