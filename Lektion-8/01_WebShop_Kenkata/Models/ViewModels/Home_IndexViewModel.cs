using _01_WebShop_Kenkata.Models.PartialViewModels;

namespace _01_WebShop_Kenkata.Models.ViewModels
{
    public class Home_IndexViewModel
    {
        public ProductSlider_PartialViewModel NewArrivals { get; set; } = new();
        public ProductSlider_PartialViewModel FeaturedProducts { get; set; } = new();
    }
}
