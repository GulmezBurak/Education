namespace _2_İleriRepository.Data
{
    public class Department:BaseInt
    {
        public string DepartmentName { get; set; }
        public ICollection<Personnal> Personnals { get; set; }
    }
}
