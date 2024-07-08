using MyBlogApp.Comments;
using MyBlogApp.Posts;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace MyBlogApp.Data
{
    public class MyBlogDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Post, Guid> _postRepository;
        private readonly IRepository<Comment, Guid> _commentRepository;

        public MyBlogDataSeederContributor(IRepository<Post, Guid> postRepository, IRepository<Comment, Guid> commentRepository)
        {
            _postRepository = postRepository;
            _commentRepository = commentRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            //await SeedPostsAndCommentsAsync(context);
            var post1 = await _postRepository.InsertAsync(
                    new Post
                    {
                        Title = "my Morning Routine ",
                        Content = "Successful people have a strict routine to start a successful day ",
                        PublishDate = DateTime.Now
                    },
                    autoSave: true
                );
            // Seed comments associated with the posts
            await _commentRepository.InsertAsync(
                new Comment { Content = "First comment on Morning Routine post", PostId = post1.Id },
                autoSave: true
            );

        }

        private async Task SeedPostsAndCommentsAsync(DataSeedContext context)
        {
            if (await _postRepository.GetCountAsync() <= 0)
            {
                var post1 = await _postRepository.InsertAsync(
                    new Post
                    {
                        Title = "my Morning Routine ",
                        Content = "Successful people have a strict routine to start a successful day ",
                        PublishDate = DateTime.Now
                    },
                    autoSave: true
                );

                var post2 = await _postRepository.InsertAsync(
                    new Post
                    {
                        Title = "wanna Be Happy ",
                        Content = "if you want to Be Happy as you get older say goodbye to these 10 habits ",
                        PublishDate = DateTime.Now
                    },
                    autoSave: true
                );

                // Seed comments associated with the posts
                await _commentRepository.InsertAsync(
                    new Comment { Content = "First comment on Morning Routine post", PostId = post1.Id },
                    autoSave: true
                );

                await _commentRepository.InsertAsync(
                    new Comment { Content = "Second comment on Morning Routine post", PostId = post1.Id },
                    autoSave: true
                );

                await _commentRepository.InsertAsync(
                    new Comment { Content = "Comment on Be Happy post", PostId = post2.Id },
                    autoSave: true
                );

                // Add more comments as needed
            }
        }
    }
}
