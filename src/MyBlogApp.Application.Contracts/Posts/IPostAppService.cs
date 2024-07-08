using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MyBlogApp.Posts
{
    public interface IPostAppService :
    ICrudAppService< //Defines CRUD methods
        PostDto, //Used to show posts
        Guid, //Primary key of the post entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdatePostDto> //Used to create/update a post
    {
        Task<PostDto> GetPostWithCommentsAsync(Guid postId);
    }
}
