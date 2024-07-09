using System;
using System.Collections.Generic;
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
        CreateUpdateCommentDto> //Used to create/update a post
    {
        Task<PostDto> GetPostWithCommentsAsync(Guid postId);
        Task<List<PostDto>> GetAllPostsWithCommentsAsync();
    }
}
