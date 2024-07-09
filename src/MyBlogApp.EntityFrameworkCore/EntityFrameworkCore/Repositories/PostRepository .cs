using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyBlogApp.Posts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MyBlogApp.EntityFrameworkCore.Repositories
{
    public class PostRepository : EfCoreRepository<MyBlogAppDbContext, Post, Guid>, IPostRepository
    {
        private readonly ILogger<PostRepository> _logger;
        public PostRepository(IDbContextProvider<MyBlogAppDbContext> dbContextProvider, ILogger<PostRepository> logger)
            : base(dbContextProvider)
        {
            _logger = logger;
        }

        public async Task<Post> GetPostWithCommentsAsync(Guid id)
        {
            _logger.LogInformation($"Fetching post with ID: {id}");
            var post = await DbContext.Posts
            .Include(p => p.Comments)
            .FirstOrDefaultAsync(p => p.Id == id);

            if (post == null)
            {
                _logger.LogWarning($"Post with ID: {id} not found.");
            }
            else
            {
                _logger.LogInformation($"Post with ID: {id} found with {post.Comments.Count} comments.");
            }

            return post;
        }

        public async Task<List<Post>> GetAllPostsWithCommentsAsync()
        {
            _logger.LogInformation("Fetching all posts with comments.");
            var posts = await DbContext.Posts
                .Include(p => p.Comments)
                .ToListAsync();

            _logger.LogInformation($"Found {posts.Count} posts with comments.");

            return posts;
        }
    }
}
