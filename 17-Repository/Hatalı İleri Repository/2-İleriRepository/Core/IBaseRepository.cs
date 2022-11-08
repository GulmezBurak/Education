using _2_İleriRepository.Context;
using Microsoft.EntityFrameworkCore;

namespace _2_İleriRepository.Core
{
    public interface IBaseRepository<T> where T : class
    {

        public List<T> List();
        public T Find(int Id);
        public bool Update(T entity);
        public bool Add(T entity);
        public bool Delete(int Id);
        public DbSet<T> Set();
    }
}
