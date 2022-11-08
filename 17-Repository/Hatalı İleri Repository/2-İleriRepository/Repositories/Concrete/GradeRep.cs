using _2_İleriRepository.Context;
using _2_İleriRepository.Core;
using _2_İleriRepository.Data;
using _2_İleriRepository.Repositories.Abstract;

namespace _2_İleriRepository.Repositories.Concrete
{
    public class GradeRep<T> : BaseRepository<Grade>, IGradeRep where T : class
    {
        public GradeRep(MyContext db) : base(db)
        {
        }
    }
}
