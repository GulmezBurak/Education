using _2_İleriRepository.Core;
using _2_İleriRepository.Data;
using _2_İleriRepository.DTO;

namespace _2_İleriRepository.Repositories.Abstract
{
    public interface IPersonnalRep : IBaseRepository<Personnal>
    {
        
        List<PersonnalGradeS> ListbyGrades();
        List<PersonnalDepartments> ListbyDepartments(); 
    }
}
