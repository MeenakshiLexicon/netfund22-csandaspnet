using _03_WebApi.Models;
using Newtonsoft.Json;

namespace _03_WebApi.Repositories
{
    public interface IProductRepository
    {
        public void Create(Product product);
        public IEnumerable<Product> GetAll();
    }

    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new();
        }

        public void Create(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);

            using (var sw = new StreamWriter(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file.json"))
            {
                sw.WriteLine(JsonConvert.SerializeObject(_products));
            }
        }

        public IEnumerable<Product> GetAll()
        {
            try
            {
                using (var sr = new StreamReader(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file.json"))
                {
                    _products = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
                }
            }
            catch { }

            return _products;
        }
    }
}
