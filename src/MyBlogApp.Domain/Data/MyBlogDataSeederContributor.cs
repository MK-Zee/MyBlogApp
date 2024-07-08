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

        public MyBlogDataSeederContributor(IRepository<Post, Guid> postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _postRepository.GetCountAsync() <= 0)
            {
                await _postRepository.InsertAsync(
                    new Post
                    {
                        Title = "Morning Routine for successful people",
                        Content = "Successful people have a strict routine to start a successful day ",
                        PublishDate = DateTime.Now
                    },
                    autoSave: true
                );

                await _postRepository.InsertAsync(
                    new Post
                    {
                        Title = "Be Happy as you get older",
                        Content = "if you want to Be Happy as you get older say goodbye to these 10 habits ",
                        PublishDate = DateTime.Now
                    },
                    autoSave: true
                );
            }
        }
    }
}
