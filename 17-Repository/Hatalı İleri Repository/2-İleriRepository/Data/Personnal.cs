using System.ComponentModel.DataAnnotations.Schema;

namespace _2_İleriRepository.Data
{
    public class Personnal: BaseInt
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateofBirth { get; set; }
        public int DepartmentId { get; set; }
        public string GradeId { get; set; }
        public char Gender { get; set; }
        public string Street { get; set; }
        public string Avenue { get; set; }
        private string Phone { get; set; }
        public int No { get; set; }
        public int CountyId { get; set; }
        public string ImgUrl { get; set; }
        [ForeignKey("DepatmentId")]
        public Department Department { get; set; }
        [ForeignKey("GradeId")]
        public Grade Grade { get; set; }
        [ForeignKey("CountyId")]
        public County County { get; set; }
        public string FullName()
        {
            if (Gender == 'M')
            {
                return $"Dear Mr. {Name} {Surname}";
            }
            else return $"Dear Mrs. {Name} {Surname}";
        }
        public int GetAge()
        {
            // 23.03.1998
            DateTime today = DateTime.Now;
            // 21.10.2022
            int age = today.Year - DateofBirth.Year;
            //        2022-1998 = 24
            DateTime birthDay = DateofBirth.AddYears(age);
            //                  23.03.1998 + 24 = 23.03.2022
            // 23.03.2022
            if (birthDay > today)
            {
                age++;
            }
            return age;
        }
        List<string> GetAddress()
        {
            List<string> address = new List<string>();
            address.Add(FullName());
            address.Add(Street);
            address.Add(Avenue);
            address.Add(No.ToString());
            address.Add(County.CountyName + "/" + County.City.CityName);
            return address;
        }


    }
}
