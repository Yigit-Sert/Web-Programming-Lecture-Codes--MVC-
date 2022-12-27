namespace BF.Models
{
    public static class ProductRepository
    {
        private static List<Product> _products = new List<Product>();

        static ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product(){Id= 1,Name="Product1",Description="Des1",Price=100,isApproved=true},
                new Product(){Id= 2,Name="Product2",Description="Des2",Price=100,isApproved=false},
                new Product(){Id= 3,Name="Product3",Description="Des3",Price=1,isApproved=true},
                new Product(){Id= 4,Name="Product4",Description="Des4",Price=20,isApproved=false},
                new Product(){Id= 5,Name="Product5",Description="Des5",Price=100,isApproved=true}
            };
        }

        public static List<Product> Products
        {
            get { return _products; }    
        }

        public static void AddProduct(Product entity)
        {
            _products.Add(entity);
        }
    }
}
