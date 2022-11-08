namespace IleriRepository.Data
{
    public class Department : BaseInt
    {
        public string DepartmentName { get; set; }
        public ICollection<Personel> Personels{ get; set; }
    }
}
