using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork_1.Model
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product>  Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EI2CNGP\\SQLEXPRESS;Database=DeepakDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
