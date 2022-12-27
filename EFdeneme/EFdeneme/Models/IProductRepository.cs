namespace EFdeneme.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
    //this is readable file 
}
