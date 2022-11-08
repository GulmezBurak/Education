using System.ComponentModel.DataAnnotations.Schema;

namespace IleriRepository.Data
{
    public class Personel : BaseInt
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DepartmentId { get; set; }
        public string GradeId { get; set; }
        public char Gender { get; set; }
        public string Street { get; set; }
        public string Avenue { get; set; }
        private string Phone { get; set; }
        public int No { get; set; }
        public int CountyId { get; set; }
        public string ImgUrl { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        [ForeignKey("GradeId")]
        public Grade Grade { get; set; }
        [ForeignKey("CountyId")]
        public County County { get; set; }

        public string FullName()
        {
            if (Gender == 'M')
            {
                return $"Dear Mr. {Name} {SurName}";
            }
            else
            {
                return $"Dear Mrs. {Name} {SurName}";
            }
        }
        public int GetAge()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - DateOfBirth.Year;
            DateTime BirthDay = DateOfBirth.AddYears(age);
            if (BirthDay < today)
            {
                age++;
            }
            return age;
        }
        public List<string> GetAddress()
        {
            List<string> adress = new List<string>();
            adress.Add(FullName());
            adress.Add(Street);
            adress.Add(Avenue);
            adress.Add(No.ToString());
            adress.Add(County.CountyName + " / " + County.City.CityName);
            return adress;


        }
    }
}
