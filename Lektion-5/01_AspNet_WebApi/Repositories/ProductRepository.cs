using _01_AspNet_WebApi.Models;

namespace _01_AspNet_WebApi.Repositories
{
    public interface IProductRepository
    {
        public void Create(Product product);
        public Product Read(int id);
        public IEnumerable<Product> Read();
        public void Update(int id, Product updatedProduct);
        public void Delete(int id);
    }

    public class ProductRepository : IProductRepository
    {
        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Read(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Product updatedProduct)
        {
            throw new NotImplementedException();
        }
    }
}
