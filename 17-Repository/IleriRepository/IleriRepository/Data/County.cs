using System.ComponentModel.DataAnnotations.Schema;

namespace IleriRepository.Data
{
    public class County : BaseInt
    {

        public string CountyName { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        public ICollection<Personel> Personels { get; set; }

    }
}
