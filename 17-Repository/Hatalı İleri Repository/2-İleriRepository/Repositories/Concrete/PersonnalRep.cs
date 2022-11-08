using _2_İleriRepository.Context;
using _2_İleriRepository.Core;
using _2_İleriRepository.Data;
using _2_İleriRepository.DTO;
using _2_İleriRepository.Repositories.Abstract;

namespace _2_İleriRepository.Repositories.Concrete
{
    public class PersonnalRep<T> : BaseRepository<Personnal>, IPersonnalRep where T : class
    {
        public PersonnalRep(MyContext db) : base(db)
        {

        }


        public List<PersonnalDepartments> ListbyDepartments()
        {
            return Set().Select(x => new PersonnalDepartments
            {
                Department = x.Department.DepartmentName,
                FullName = x.Name + " " + x.Surname,
                Id = x.Id,
            }).ToList();
            //return ls;
        }

        public List<PersonnalGradeS> ListbyGrades()
        {
            return Set().Select(x => new PersonnalGradeS
            {
                Grade = x.Grade.GradeName,
                FullName = x.Name + " " + x.Surname,
                Id = x.Id,
                GradeId = x.GradeId,
            }).OrderBy(x => x.GradeId).ToList();
        }
    }
}
