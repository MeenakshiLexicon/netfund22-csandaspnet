namespace _01_WebShop_Kenkata.Models.PartialViewModels
{
    public class ProductSlider_PartialViewModel
    {
        public SectionTitleModel SectionTitle { get; set; } = new SectionTitleModel();
        public List<ProductModel> Products { get; set; } = new List<ProductModel>();
    }
}
