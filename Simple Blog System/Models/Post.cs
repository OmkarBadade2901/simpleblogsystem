using System.ComponentModel.DataAnnotations;

namespace Simple_Blog_System.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(200, ErrorMessage = "Title cannot exceed 200 characters")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        public string? Content { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Published Date")]
        public DateTime PublishedDate { get; set; }
    }
}
