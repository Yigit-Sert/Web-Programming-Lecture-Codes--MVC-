using Microsoft.EntityFrameworkCore;


namespace EFdeneme.Models
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
