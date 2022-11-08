using IleriRepository.Context;
using IleriRepository.Repositories.Abstract;

namespace IleriRepository.UnitOfWork
{
    public class Unit : IUnit
    {
        MyContext _db;

        public IPersonelRep _personelRep { get; private set; }

        public IGradeRep _gradeRep { get; private set; }

        public IDepartmentRep _departmentRep { get; private set; }

        public ICityRep _cityRep { get; private set; }

        public ICountyRep _countyRep { get; private set; }

        public void Commit()
        {
            _db.SaveChanges();
        }

        // Arka Planda            PersonelRep nesnesi newlenir. PersonelRep personelRep = new PersonelRep();
        public Unit(MyContext db, IPersonelRep personelRep, IGradeRep gradeRep, IDepartmentRep departmentRep, ICityRep cityRep, ICountyRep countyRep)
        {
            _db = db;
            _personelRep = personelRep;
            _gradeRep = gradeRep;
            _departmentRep = departmentRep;
            _cityRep = cityRep;
            _countyRep = countyRep;
        }
    }
}
