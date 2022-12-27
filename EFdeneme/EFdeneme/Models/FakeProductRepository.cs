namespace EFdeneme.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products =>
            new List<Product>
            {
                new Product(){ProductId=1, Name="Product1", Description="Description1", Price=100, Category="Category1"},
                new Product(){ProductId=2, Name="Product2", Description="Description1", Price=100, Category="Category1"},
                new Product(){ProductId=3, Name="Product3", Description="Description1", Price=100, Category="Category1"},
                new Product(){ProductId=4, Name="Product4", Description="Description1", Price=100, Category="Category1"},
                new Product(){ProductId=5, Name="Product5", Description="Description1", Price=100, Category="Category1"}

            }.AsQueryable();

    }
}
