using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.DTO;

namespace IleriRepository.Repositories.Abstract
{
    public interface IPersonelRep:IBaseRepository<Personel>
    {
        
        List<PersonelGrades> ListByGrades();
        List<PersonelDepartments> ListByDepartments();
        public int GetAge(Personel personel);
        public List<string> GetAddress(Personel personel);
        public string FullName(Personel personel);
        Personel FindDetail(int Id);

    }
}
