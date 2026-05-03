using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        public IActionResult Details(int id)
        {
            //Temporary fake data for demonstration purposes
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Wireless Headphones", Description = "Premium sound quality", Price = 99.99m, Stock = 50 },
                new Product { Id = 2, Name = "Mechanical Keyboard", Description = "Tacticle and fast", Price = 149.99m, Stock = 30 },
                new Product { Id = 3, Name = "USB-C Hub", Description = "7 ports in one", Price = 49.99m, Stock = 100 },

            };
            //Find the product using matching id
            var product = products.FirstOrDefault(p => p.Id == id);

            //If product is not found, return NotFound result 404 page
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }

    
}
