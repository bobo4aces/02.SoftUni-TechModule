namespace ShoppingList.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class ProductController : Controller
    {
        private readonly ShoppingListDbContext dbContext;

        public ProductController(ShoppingListDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Product> products = dbContext.Products.ToList();
            return View(products);
        }

        [HttpGet]
        [Route("/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int? id)
        {
            Product product = dbContext
                .Products
                .Where(p => p.Id == id)
                .FirstOrDefault();

            return View(product);

        }

        [HttpPost]
        [Route("/edit/{id}")]
        public IActionResult Edit(Product product)
        {
            dbContext.Products.Update(product);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
