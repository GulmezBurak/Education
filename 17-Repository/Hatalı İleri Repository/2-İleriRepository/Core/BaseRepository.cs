using _2_İleriRepository.Context;
using Microsoft.EntityFrameworkCore;

namespace _2_İleriRepository.Core
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        MyContext _db;
        public BaseRepository(MyContext db)
        {
            _db = db;
        }
        public bool Add(T entity)
        {
            try
            {
                Set().Add(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                Set().Remove(Find(Id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T Find(int Id)
        {
            return Set().Find(Id);
        }
        public T Find(string Id)
        {
            return Set().Find(Id);
        }

        public List<T> List()
        {
            return Set().ToList();
        }

        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }

        public bool Update(T entity)
        {
            try
            {
                Set().Update(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
