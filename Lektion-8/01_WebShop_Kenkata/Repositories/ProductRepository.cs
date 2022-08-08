using _01_WebShop_Kenkata.Models;

namespace _01_WebShop_Kenkata.Repositories
{
    public interface IProductRepository
    {
        public List<ProductModel> GetAll();
        public List<ProductModel> GetAll(int take);
    }

    public class ProductRepository : IProductRepository
    {
        private List<ProductModel> _products = new List<ProductModel>
        {
            new ProductModel { Name = "Product 1", CategoryName = "Fashion", ImageName = "placeholder-male-chest.png", Price = 100, Discount = 0.5M, InStock = true, Rating = 5 },
            new ProductModel { Name = "Product 2", CategoryName = "Fashion", ImageName = "placeholder-male-chest.png", Price = 200, InStock = true, Rating = 2 },
            new ProductModel { Name = "Product 2", CategoryName = "Fashion", ImageName = "placeholder-male-chest.png", Price = 300, Discount = 0.5M, InStock = false, Rating = 3 },
            new ProductModel { Name = "Product 4", CategoryName = "Fashion", ImageName = "placeholder-male-chest.png", Price = 400, Discount = 0.5M, InStock = true, Rating = 4 }
        };

        public List<ProductModel> GetAll()
        {
            return _products;
        }

        public List<ProductModel> GetAll(int take)
        {
            return _products.Take(take).ToList();
        }
    }
}
