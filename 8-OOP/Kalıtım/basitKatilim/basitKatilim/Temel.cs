using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basitKatilim
{
    internal class Temel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cadde { get; set; }
        public string Sokak { get; set; }
        public string Ilce { get; set; }
        public string Sehir { get; set; }
        public string FullName()
        {
            return Ad + Soyad;
        }
        public List<string> AdresAl()
        {
            List<string> adres = new List<string>();
            adres.Add(FullName());
            adres.Add(Cadde);
            adres.Add(Sokak);
            adres.Add($"{Ilce}-{Sehir}");
            return adres;
        }
    }
}
