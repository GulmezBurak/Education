using System.ComponentModel.DataAnnotations;

namespace _2_İleriRepository.Data
{
    public class BaseInt
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }

    }
}
