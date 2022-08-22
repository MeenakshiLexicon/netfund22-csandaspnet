using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _01_Identity.Models.Entities
{
    public class UserProfileEntity
    {
        [Key, Column(TypeName = "nvarchar(450)")]
        public string UserId { get; set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
    }
}
