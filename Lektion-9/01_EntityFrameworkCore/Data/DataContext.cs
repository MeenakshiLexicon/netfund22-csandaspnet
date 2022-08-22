using _01_EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;

namespace _01_EntityFrameworkCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
