using _2_İleriRepository.Context;
using _2_İleriRepository.Repositories.Abstract;

namespace _2_İleriRepository.UnitofWork
{
    public class Unit : IUnit
    {
        MyContext _db;
        public IPersonnalRep _personnalRep {get; private set;}

        public IGradeRep _gradeRep { get; private set; }

        public IDepartmentRep _departmentRep { get; private set; }

        public ICountyRep _countyRep { get; private set; }

        public ICityRep _cityRep { get; private set; }

        public void Commit()
        {
            _db.SaveChanges();
        }
        //                                                   GradeRep nesnesi new lenir- GradeRep gradeRep = new CityRep()
        public Unit(MyContext db, IPersonnalRep personnalRep, IGradeRep gradeRep, IDepartmentRep departmentRep, ICountyRep countyRep, ICityRep cityRep)
        {
            _db = db;
            _personnalRep = personnalRep;
            _gradeRep = gradeRep;
            _departmentRep = departmentRep;
            _countyRep = countyRep;
            _cityRep = cityRep;
        }
    }
}
