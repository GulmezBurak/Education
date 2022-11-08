using _1_BasicRep.Context;
using Microsoft.EntityFrameworkCore;

namespace _1_BasicRep.Repository
{
    public class Repos<T> where T : class
    {
        MyContext _db;
        public Repos(MyContext db)
        {
            _db = db;
        }
        public List<T> List()
        {
            return Set().ToList();
            //return _db.Set<T>().ToList();
        }
        public T Find(int Id)
        {
            return Set().Find(Id);
            //return _db.Set<T>().Find(Id);
        }
        public T Find(string Id)
        {
            return Set().Find(Id);
            //return _db.Set<T>().Find(Id);
        }
        public void Update(T entity)
        {
            Set().Update(entity);
            //_db.Set<T>().Update(entity);
        }
        public bool Create(T entity)
        {
            try
            {
                Set().Add(entity);
                return true;
                //_db.Set<T>().Add(entity);
            }
            catch (Exception)
            {
                return false;
            }

        }
        public void Delete(T entity)
        {
            Set().Remove(entity);
            //_db.Set<T>().Remove(entity);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }
    }
}
