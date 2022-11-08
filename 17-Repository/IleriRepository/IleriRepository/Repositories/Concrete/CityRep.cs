using IleriRepository.Context;
using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.Repositories.Abstract;

namespace IleriRepository.Repositories.Concrete
{
    public class CityRep<T> : BaseRepository<City>, ICityRep where T:class
    {
        public CityRep(MyContext db) : base(db)
        {

        }
    }
}
