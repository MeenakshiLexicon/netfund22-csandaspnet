
using System.ComponentModel.DataAnnotations;

namespace _00_Repetition_WebApi.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Du måste ange ett artikelnummer")]
        public string ArticleNumber { get; set; } = null!;
        
        [Required]
        public string Name { get; set; } = null!;
        
        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
