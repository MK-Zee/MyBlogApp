using System;
using Volo.Abp.Application.Dtos;

namespace MyBlogApp.Posts
{
    public class PostDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
