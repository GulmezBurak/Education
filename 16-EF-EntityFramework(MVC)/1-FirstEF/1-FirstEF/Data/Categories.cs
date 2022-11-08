using NuGet.Protocol.Plugins;
using System.ComponentModel.DataAnnotations;

namespace _1_FirstEF.Data
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Products> Products { get; set; }

    }
}
