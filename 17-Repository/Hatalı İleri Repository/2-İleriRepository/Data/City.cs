
namespace _2_İleriRepository.Data
{
    public class City:BaseInt
    {
        public string CityName { get; set; }
        public ICollection<County> Counties { get; set; }
    }
}
