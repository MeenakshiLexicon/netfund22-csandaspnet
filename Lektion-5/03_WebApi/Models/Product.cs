using System.ComponentModel.DataAnnotations;

namespace _03_WebApi.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }
    }
}
