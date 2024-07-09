using MyBlogApp.Posts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyBlogApp.Comments
{
    public class Comment : AuditedAggregateRoot<Guid>
    {
        [Required]
        public string Content { get; set; }

        public DateTime CommentDate { get; set; } = DateTime.Now;

        public Guid PostId { get; set; }
        // Navigation property to the associated Post entity
        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; }
    }
}
