using System.Threading.Tasks;

namespace MyBlogApp.Data;

public interface IMyBlogAppDbSchemaMigrator
{
    Task MigrateAsync();
}
