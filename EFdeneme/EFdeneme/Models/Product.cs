namespace EFdeneme.Models
{
    public class Product
    {

        //this is my entity class, db schema
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
