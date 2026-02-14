using System.ComponentModel.DataAnnotations;

namespace SyncSyntax.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "CategoryName is requied!")]
        [MaxLength(100, ErrorMessage = "CategoryName cannot be longer than 100 characters!")]
        public string CategoryName { get; set; }
        public string? Description { get; set; } // Optional description for the category
        public List<Post> Posts { get; set; } = new List<Post>(); // Navigation property for related posts
    }
}
