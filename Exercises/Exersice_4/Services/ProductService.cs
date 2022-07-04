using Exersice_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice_4.Services
{
    internal class ProductService
    {
        private readonly string _filePath;
        private List<Product> _products = new();
        private readonly FileService _fileService = new FileService();

        public ProductService(string filePath)
        {
            _filePath = filePath;
            _products = _fileService.ReadFromFile(_filePath).ToList();
        }

        public IEnumerable<Product> ProductCatalog()
        {
            return _products;
        }

        public Product Details(Guid id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Guid id)
        {
            _products = _products.Where(x => x.Id != id).ToList();
        }

        public void Save()
        {
            _fileService.SaveToFile(_filePath, _products);
        }
    }
}
