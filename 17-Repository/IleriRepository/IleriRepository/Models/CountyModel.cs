using IleriRepository.Data;

namespace IleriRepository.Models
{
    public class CountyModel
    {
        public County County { get; set; }
        public string Head { get; set; }
        public string BtnText { get; set; }
        public string BtnCls { get; set; }
        public List<City> Cities { get; set; }
    }
}
