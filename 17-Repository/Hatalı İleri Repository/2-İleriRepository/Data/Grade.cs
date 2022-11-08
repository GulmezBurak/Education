namespace _2_İleriRepository.Data
{
    public class Grade:BaseStr
    {
        public string GradeName { get; set; }
        public ICollection<Personnal> Personnals { get; set; }
    }
}
