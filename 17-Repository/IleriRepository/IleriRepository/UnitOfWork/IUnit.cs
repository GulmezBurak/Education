using IleriRepository.Repositories.Abstract;

namespace IleriRepository.UnitOfWork
{
    public interface IUnit
    {
        IPersonelRep _personelRep { get; }
        IGradeRep _gradeRep { get; }
        IDepartmentRep _departmentRep { get; }
        ICityRep _cityRep { get; }
        ICountyRep _countyRep { get; }
        void Commit();

    }
}
