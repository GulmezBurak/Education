using _2_İleriRepository.Data;
using Microsoft.EntityFrameworkCore;

namespace _2_İleriRepository.Context
{
    public class MyContext: DbContext
    {
        MyContext _db;
        public MyContext(DbContextOptions<MyContext> db):base(db)
        {
            
        }
        //sql de tabloyu oluşturan kod.
        public DbSet<Personnal> Personnal { get; set; }
        public DbSet<County> County { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
