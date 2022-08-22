using _00_Repetition_EntityFrameWorkCore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _00_Repetition_EntityFrameWorkCore.Models;

namespace _00_Repetition_EntityFrameWorkCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<_00_Repetition_EntityFrameWorkCore.Models.Product>? Product { get; set; }
    }
}
