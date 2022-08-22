using _02_EntityFrameworkCore.Data;
using _02_EntityFrameworkCore.Models;
using _02_EntityFrameworkCore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _02_EntityFrameworkCore.Repositories
{
    public interface IProductRepository
    {
        public Task<List<ProductEntity>> GetAllAsync();
        public Task<ProductEntity> GetAsync(int id);
        public Task<ProductEntity> CreateAsync(ProductRequest product);
    }

    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ProductEntity> CreateAsync(ProductRequest product)
        {
            var _product = new ProductEntity
            {
                Name = product.Name,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Price = product.Price
            };

            _context.Products.Add(_product);
            await _context.SaveChangesAsync();

            return _product;
        }

        public async Task<List<ProductEntity>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<ProductEntity> GetAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}
