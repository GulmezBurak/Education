using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.DTO;

namespace IleriRepository.Repositories.Abstract
{
    public interface ICountyRep : IBaseRepository<County>
    {
        List<CountyDTO> GetCounties();
    }
}
