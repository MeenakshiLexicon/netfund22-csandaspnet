using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _01_EntityFrameworkCore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";


        public string? Description { get; set; }


        [Required]
        [Column(TypeName = "decimal")]
        public decimal Price { get; set; }
    }
}
