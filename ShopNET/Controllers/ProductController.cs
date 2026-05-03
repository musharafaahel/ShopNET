using Microsoft.AspNetCore.Mvc;
using ShopNET.Models;

namespace ShopNET.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Wireless Headphones", Description = "Premium sound quality", Price = 99.99m, Stock = 50 },
                new Product { Id = 2, Name = "Mechanical Keyboard", Description = "Tacticle and fast", Price = 149.99m, Stock = 30 },
                new Product { Id = 3, Name = "USB-C Hub", Description = "7 ports in one", Price = 49.99m, Stock = 100 },
                
            };
            return View(products);
        }
    }
}
