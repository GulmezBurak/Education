using PersonelProje.Data;

namespace PersonelProje.Models
{
    public class PersonelModel
    {
        public Personel Personel { get; set; }
        public List<Sehir> Sehirler { get; set; }
        public List<Ulke> Ulkeler { get; set; }
        public string Baslik { get; set; }
        public string BtnText { get; set; }
        public string BtnClass { get; set; }

    }
}
