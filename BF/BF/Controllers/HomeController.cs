using BF.Models;
using Microsoft.AspNetCore.Mvc;

namespace BF.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(ProductRepository.Products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product pro)
        {
            ProductRepository.AddProduct(pro); 
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Search(string q)
        {
            if (string.IsNullOrWhiteSpace(q))
                return View();
          
            return View("Index", ProductRepository.Products.Where(i => i.Name.Contains(q)));           
        }
    }
}
