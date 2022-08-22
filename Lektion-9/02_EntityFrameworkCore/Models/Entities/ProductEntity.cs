using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _02_EntityFrameworkCore.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string? Description { get; set; }
        
        public string? ImageUrl { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal Price { get; set; }
    }
}
