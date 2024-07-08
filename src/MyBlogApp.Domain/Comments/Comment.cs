using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyBlogApp.Comments
{
    public class Comment : AuditedAggregateRoot<Guid>
    {
        [Required]
        public string Content { get; set; }

        public DateTime CommentDate { get; set; } = DateTime.Now;
    }
}
