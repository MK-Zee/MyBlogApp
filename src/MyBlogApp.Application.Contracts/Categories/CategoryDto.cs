using System;
using Volo.Abp.Application.Dtos;

namespace MyBlogApp.Categories
{
    public class CategoryDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
