using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFdeneme.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            ApplicationDbContext con = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            con.Database.Migrate();

            if (!con.Products.Any())
            {
                con.Products.AddRange(
                    new Product(){Name="Product1", Description="Desc1", Price=100, Category="cat1"},
                    new Product() { Name = "Product2", Description = "Desc2", Price = 100, Category = "cat1" },
                    new Product() { Name = "Product3", Description = "Desc3", Price = 100, Category = "cat1" }

                    );
                con.SaveChanges();
            }
        }
    }
}
