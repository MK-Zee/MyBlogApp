using MyBlogApp.Comments;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace MyBlogApp.Posts
{
    public class PostDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
}
