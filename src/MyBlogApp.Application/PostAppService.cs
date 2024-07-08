using MyBlogApp.Posts;
using System;
using System.Threading.Tasks;
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
        private readonly IRepository<Post, Guid> _postRepository;

        public PostAppService(IRepository<Post, Guid> postRepository) : base(postRepository)
        {
            _postRepository = postRepository;
        }

        public Task<PostDto> GetPostWithCommentsAsync(Guid postId)
        {
            /*var post = await _postRepository
            .Include(p => p.Comments) // Ensure to include Comments
            .FirstOrDefaultAsync(p => p.Id == postId);

            return ObjectMapper.Map<Post, PostDto>(post);*/
            throw new NotImplementedException();
        }
    }
}
