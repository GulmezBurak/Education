using IleriRepository.Context;
using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.Repositories.Abstract;

namespace IleriRepository.Repositories.Concrete
{
    public class GradeRep<T> : BaseRepository<Grade>, IGradeRep where T : class
    {
        public GradeRep(MyContext db) : base(db)
        {

        }


    }
}
