using _01_WebShop_Kenkata.Models.PartialViewModels;
using _01_WebShop_Kenkata.Models.ViewModels;
using _01_WebShop_Kenkata.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _01_WebShop_Kenkata.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Shop is more fun";
            var viewModel = new Home_IndexViewModel();

            viewModel.NewArrivals = new ProductSlider_PartialViewModel
            {
                SectionTitle = new() { Title = "NEW", SpanTitle = "ARRIVALS", Text = "Check out our latest products from top fashion designers" },
                Products = _productRepository.GetAll(4)
            };

            viewModel.FeaturedProducts = new ProductSlider_PartialViewModel
            {
                SectionTitle = new() { Title = "FEATURED", SpanTitle = "PRODUCTS", Text = "Check out our monthly featured products from top brands" },
                Products = _productRepository.GetAll(3)
            };

            return View(viewModel);
        }

    }
}