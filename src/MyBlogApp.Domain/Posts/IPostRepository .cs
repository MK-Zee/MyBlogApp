using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace MyBlogApp.Posts
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<Post> GetPostWithCommentsAsync(Guid id);
        Task<List<Post>> GetAllPostsWithCommentsAsync();
    }
}
