using System.ComponentModel.DataAnnotations;

namespace _1_BasicRep.Data
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
    }
}
