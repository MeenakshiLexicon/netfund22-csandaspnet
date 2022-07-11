using _01_AspNet_WebApi.Models;
using _01_AspNet_WebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _01_AspNet_WebApi.Controllers
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


        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productRepository.Create(product);
            return new OkResult();
        }

    }
}
