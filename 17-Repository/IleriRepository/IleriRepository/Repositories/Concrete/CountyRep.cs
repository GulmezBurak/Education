using IleriRepository.Context;
using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.DTO;
using IleriRepository.Repositories.Abstract;

namespace IleriRepository.Repositories.Concrete
{
    public class CountyRep<T> : BaseRepository<County>, ICountyRep where T : class
    {
        public CountyRep(MyContext db) : base(db)
        {
        }

        public List<CountyDTO> GetCounties()
        {
            return Set().Select(x=> new CountyDTO
            {
                Id = x.Id,
                CountyName = x.CountyName,
                CityName = x.City.CityName,
            }).ToList();
        }
    }
}
