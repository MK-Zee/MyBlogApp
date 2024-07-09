using MyBlogApp.Posts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;

namespace MyBlogApp
{
    public class PostAppService : CrudAppService<
        Post, //The Post entity
        PostDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateCommentDto>, //Used to create/update a book
        IPostAppService //implement the IBookAppService
    {
        private readonly IPostRepository _postRepository;

        public PostAppService(IPostRepository postRepository) : base(postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<List<PostDto>> GetAllPostsWithCommentsAsync()
        {
            var posts = await _postRepository.GetAllPostsWithCommentsAsync();
            return ObjectMapper.Map<List<Post>, List<PostDto>>(posts);
        }

        public async Task<PostDto> GetPostWithCommentsAsync(Guid id)
        {
            var post = await _postRepository.GetPostWithCommentsAsync(id);
            if (post == null)
            {
                throw new EntityNotFoundException(typeof(Post), id);
            }
            return ObjectMapper.Map<Post, PostDto>(post);
        }
    }
}
