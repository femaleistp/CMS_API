using System.ComponentModel.DataAnnotations;

namespace CMS_API.Models
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
