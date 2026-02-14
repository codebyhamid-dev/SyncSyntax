using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncSyntax.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Title is requied!")]
        [MaxLength(200, ErrorMessage = "Title cannot be longer than 200 characters!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Content is requied!")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Author is requied!")]
        public string Author { get; set; }
        public string FeaturedImageUrl { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; } = DateTime.Now;
        [ForeignKey("Category")]
        public int CategoryId { get; set; } // Foreign key to Category
        public Category Category { get; set; } // Navigation property to Category
        public List<Comment> Comments { get; set; } = new List<Comment>(); // Navigation property for related comments
    }
}
