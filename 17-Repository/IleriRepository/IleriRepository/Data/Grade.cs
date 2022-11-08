namespace IleriRepository.Data
{
    public class Grade : BaseStr
    {
        public string GradeName { get; set; }
        public ICollection<Personel> Personels { get; set; }
    }
}
