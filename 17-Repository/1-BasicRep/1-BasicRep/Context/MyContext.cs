using _1_BasicRep.Data;
using Microsoft.EntityFrameworkCore;

namespace _1_BasicRep.Context
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> db):base(db)
        {

        }
        public DbSet<Personel> Personel { get; set; }
    }
}
