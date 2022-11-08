using _1_FirstEF.Data;
using Microsoft.EntityFrameworkCore;
using _1_FirstEF.DTO;

namespace _1_FirstEF.Context
{
    public class SatisContext:DbContext
    {
        // DbContext class yarat
        // Classları yarat
        // appsettings.json da Db bağlantı yaz (.net core entity framework connection string googleda arat)
        // program.cs SQL context tanımı yap
        // Migration yap
        // 1. Add-Migration isim --değişiklikleri alglar
        // 2. Update-Database    --değişiklikleri uygular
        // 3. Gerekli ise 1. adıma git
        public SatisContext(DbContextOptions<SatisContext> db) : base(db)
        {
            
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<_1_FirstEF.Data.Categories> Categories { get; set; }
        public DbSet<_1_FirstEF.DTO.ProductsDTO> ProductsDTO { get; set; }

    } 
}
