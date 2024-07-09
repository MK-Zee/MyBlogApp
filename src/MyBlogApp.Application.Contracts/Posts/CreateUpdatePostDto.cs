using System;
using System.ComponentModel.DataAnnotations;

namespace MyBlogApp.Posts
{
    public class CreateUpdateCommentDto
    {
        [Required]
        [StringLength(256)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime PublishDate { get; set; } = DateTime.Now;
    }
}
