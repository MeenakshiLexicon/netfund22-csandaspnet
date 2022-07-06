using _01_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interfaces.Services
{
    internal interface IProductService
    {
        public Product Create(string name, string description, decimal price);
        public Product GetProduct(int id);
        public List<Product> GetAllProducts();
        public void DeleteProduct(int id);
    }

    internal class ProductService : IProductService
    {
        private List<Product> _products = new List<Product>();

        public Product Create(string name, string description, decimal price)
        {
            var product = new Product
            {
                Id = _products.Count + 1,
                Name = name,
                Description = description,
                Price = price
            };

            _products.Add(product);
            return product;
        }

        public void DeleteProduct(int id)
        {
            _products = _products.Where(product => product.Id != id).ToList();
        }

        public List<Product> GetAllProducts()
        {
            return _products.OrderBy(product => product.Id).ToList();
        }

        public Product GetProduct(int id)
        {
            return _products.FirstOrDefault(product => product.Id == id);
        }
    }
}
