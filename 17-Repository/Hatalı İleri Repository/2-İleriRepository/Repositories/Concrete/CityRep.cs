using _2_İleriRepository.Context;
using _2_İleriRepository.Core;
using _2_İleriRepository.Data;
using _2_İleriRepository.Repositories.Abstract;

namespace _2_İleriRepository.Repositories.Concrete
{
    public class CityRep<T> : BaseRepository<City>, ICityRep where T : class
    {
        public CityRep(MyContext db) : base(db)
        {
        }
    }
}
