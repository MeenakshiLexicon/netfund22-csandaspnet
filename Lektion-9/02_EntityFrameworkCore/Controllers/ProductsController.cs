using _02_EntityFrameworkCore.Models;
using _02_EntityFrameworkCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _02_EntityFrameworkCore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }




        public async Task<IActionResult> Index()
        {
            return View(await _productRepository.GetAllAsync());
        }


        public async Task<IActionResult> Details(int id)
        {
            var product = await _productRepository.GetAsync(id);
            if (product == null)
                return NotFound();

            return View(product);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductRequest product)
        {
            if (ModelState.IsValid)
            {
                await _productRepository.CreateAsync(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
    }
}
