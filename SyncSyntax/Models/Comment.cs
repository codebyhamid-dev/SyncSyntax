using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncSyntax.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "UserName is requied!")]
        [MaxLength(100, ErrorMessage = "UserName cannot be longer than 100 characters!")]
        public string UserName { get; set; }
        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Content is requied!")]
        public string Content { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; } // Foreign key to Post
        public Post Post { get; set; } // Navigation property to Post
    }
}
