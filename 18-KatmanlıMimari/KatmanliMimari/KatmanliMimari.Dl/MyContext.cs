using KatmanliMimari.Ent;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Dl
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> db) : base(db)
        {

        }
        public DbSet<Personnal> Personnal { get; set; }
    }
}
