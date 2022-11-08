using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basitKatilim
{
    internal class Temel : IInsan, IAdres
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public char Cinsiyet { get; set; }
        public string Cadde { get; set; }
        public string Sokak { get; set; }
        public string Ilce { get; set; }
        public string Sehir { get; set; }
        public int KapiNo { get; set; }

        public List<string> AdresAl()
        {

            List<string> adres = new List<string>();
            adres.Add(FullName());
            adres.Add(Cadde);
            adres.Add(Sokak);
            adres.Add("No: " + KapiNo);
            adres.Add($"{Ilce}/{Sehir}");
            return adres;

        }

        public string FullName()
        {
            if (Cinsiyet == 'E')
            {
                return $"Sn Bay {Ad} {Soyad}";
            }
            else return $"Sn Bayan {Ad} {Soyad}";
            
        }

        public int YasHesapla()
        {
            return DateTime.Now.Year - DogumTarihi.Year;
        }
    }
}
