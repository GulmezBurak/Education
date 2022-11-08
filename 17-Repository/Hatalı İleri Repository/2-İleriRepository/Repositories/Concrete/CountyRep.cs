using _2_İleriRepository.Context;
using _2_İleriRepository.Core;
using _2_İleriRepository.Data;
using _2_İleriRepository.Repositories.Abstract;

namespace _2_İleriRepository.Repositories.Concrete
{
    public class CountyRep<T> : BaseRepository<County>, ICountyRep where T : class
    {
        public CountyRep(MyContext db) : base(db)
        {
        }
    }
}
