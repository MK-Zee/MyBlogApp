using System;
using Volo.Abp.Application.Dtos;

namespace MyBlogApp.Comments
{
    public class CommentDto : AuditedEntityDto<Guid>
    {
        public string Content { get; set; }

        public DateTime CommentDate { get; set; }
        public Guid PostId { get; set; }
    }
}
