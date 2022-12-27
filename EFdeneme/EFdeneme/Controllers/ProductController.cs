using EFdeneme.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFdeneme.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List() => View(_productRepository.Products);
    }
}
