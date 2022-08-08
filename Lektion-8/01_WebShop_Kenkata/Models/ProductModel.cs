namespace _01_WebShop_Kenkata.Models
{
    public class ProductModel
    {
        public string Name { get; set; } = ""; 
        public string CategoryName { get; set; } = "";
        public string ImageName { get; set; } = "";
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public bool InStock { get; set; }
        public int Rating { get; set; }

        public decimal DiscountPrice => Price * Discount; 
    }
}
