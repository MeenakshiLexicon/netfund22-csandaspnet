using _02_EntityFrameworkCore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _02_EntityFrameworkCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
