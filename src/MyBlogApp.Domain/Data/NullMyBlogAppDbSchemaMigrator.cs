using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyBlogApp.Data;

/* This is used if database provider does't define
 * IMyBlogAppDbSchemaMigrator implementation.
 */
public class NullMyBlogAppDbSchemaMigrator : IMyBlogAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
