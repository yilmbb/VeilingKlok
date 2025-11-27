using Microsoft.EntityFrameworkCore;

namespace VeilingKlok.Data
{
    
    public class VeilingKlokContext : DbContext
    {
       
        public VeilingKlokContext(DbContextOptions<VeilingKlokContext> options) : base(options)
        {
        }

        
        public DbSet<Product> Producten { get; set; }
    }
}