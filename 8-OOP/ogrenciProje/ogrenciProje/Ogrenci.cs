using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciProje
{
    internal class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cadde { get; set; }
        public int Kapino { get; set; }
        public string Ilce { get; set; }
        public string Sehir { get; set; }
        public int Maas { get; set; }
        public string Unvan()
        {
            string unvan;
            if (Cinsiyet == "E")
            {
                unvan = $"Sn Bay {Ad} {Soyad}";
            }
            else unvan = $"Sn Bayan {Ad} {Soyad}";
            return unvan;
        }
        public int Yas()
        {
            DateTime bugun = DateTime.Now;
            int yas = bugun.Year - DogumTarihi.Year;
            DateTime dogumGunu = DateTime.Now.AddYears(yas);
            if (dogumGunu<bugun)
            {
                yas--;
            }
            return yas;
        }
        public List<string> AdresAl()
        {
            List<string> adres = new List<string>();
            adres.Add(Unvan());
            adres.Add(Cadde);
            adres.Add(Kapino.ToString());
            adres.Add(Ilce+"/"+Sehir);
            return adres;
        }

    }
}
