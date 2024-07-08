using MyBlogApp.Posts;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyBlogApp
{
    public class PostAppService : CrudAppService<
        Post, //The Post entity
        PostDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdatePostDto>, //Used to create/update a book
        IPostAppService //implement the IBookAppService
    {
        public PostAppService(IRepository<Post, Guid> repository)
        : base(repository)
        {

        }
    }
}
