using _03_WebApi.Models;
using _03_WebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _03_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

       
        [HttpGet]
        // GET: https://localhost:7228/api/products
        public IActionResult GetAll()
        {
            return new OkObjectResult(_productRepository.GetAll());
        }


        [HttpPost]
        // POST: https://localhost:7228/api/products
        public IActionResult Create(Product product)
        {
            _productRepository.Create(product);
            return new OkResult();
        }
    }
}
