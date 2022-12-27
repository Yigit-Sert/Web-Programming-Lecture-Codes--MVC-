using EcommAPI_Application.Abstractions;
using EcommAPI_Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommAPI_Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new()
        {
            new() { Id= 1, Name="pro1", Price= 100, StockNumber= 10, CreatedDate=DateTime.Now},
            new() { Id= 2, Name="pro1", Price= 100, StockNumber= 10, CreatedDate=DateTime.Now},
            new() { Id= 3, Name="pro1", Price= 100, StockNumber= 10, CreatedDate=DateTime.Now}
        };
    }
}
