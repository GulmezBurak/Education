using _1_FirstEF.Data;

namespace _1_FirstEF.Models
{
    public class ProductsModel
    {
        public Products Products { get; set; }
        public string Head { get; set; }
        public string Text { get; set; }
        public string Cls { get; set; }
        public List<Categories> Categories { get; set; }
    }
}
