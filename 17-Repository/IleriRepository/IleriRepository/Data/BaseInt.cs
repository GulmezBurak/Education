using System.ComponentModel.DataAnnotations;

namespace IleriRepository.Data
{
    public class BaseInt
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUptadatedDate { get; set; }
        public BaseInt()
        {
            LastUptadatedDate = DateTime.Now;
        }

    }
}
