using MyBlogApp.Comments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyBlogApp.Posts
{
    public class Post : AuditedAggregateRoot<Guid>
    {
        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime PublishDate { get; set; } = DateTime.Now;


        // Navigation property for comments associated with this post
        public ICollection<Comment> Comments { get; set; }

    }
}
