using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1_FirstEF.Data
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")] //CategoryId yi Categories classındaki key e yani Id ye bağlıyor.
        public Categories Categories { get; set; }

    }
}
