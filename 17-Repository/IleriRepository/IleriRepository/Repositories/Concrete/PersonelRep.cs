using IleriRepository.Context;
using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.DTO;
using IleriRepository.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace IleriRepository.Repositories.Concrete
{
    public class PersonelRep<T> : BaseRepository<Personel>, IPersonelRep where T : class
    {
        public PersonelRep(MyContext db) : base(db)
        {

        }

        public Personel FindDetail(int Id)
        {
            return Set().Include(x => x.Department).Include(x => x.County).ThenInclude(x => x.City).FirstOrDefault(x => x.Id == Id);
        }

        public string FullName(Personel personel)
        {
            return personel.FullName();
        }

        public List<string> GetAddress(Personel personel)
        {
            return personel.GetAddress();
        }

        public int GetAge(Personel personel)
        {
            return personel.GetAge();
        }

        public List<PersonelDepartments> ListByDepartments()
        {
            return Set().Select(x => new PersonelDepartments
            {
                Id = x.Id,
                Department = x.Department.DepartmentName,
                FullName = x.Name + " " + x.SurName
                
            }).ToList();
        }

        public List<PersonelGrades> ListByGrades()
        {
            return Set().Select(x => new PersonelGrades
            {
                Id = x.Id,
                Grade = x.Grade.GradeName,
                FullName = x.Name + " " + x.SurName,
                GradeId = x.GradeId,
                ImgUrl = x.ImgUrl
            }).OrderBy(x => x.GradeId).ToList();
        }
    }
}
