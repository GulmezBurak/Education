using _2_İleriRepository.Repositories.Abstract;

namespace _2_İleriRepository.UnitofWork
{
    public interface IUnit
    {
        IPersonnalRep _personnalRep { get; }
        IGradeRep _gradeRep { get; }
        IDepartmentRep _departmentRep { get; }
        ICountyRep _countyRep { get; }
        ICityRep _cityRep { get; }
        void Commit();
    }
}
