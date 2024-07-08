using Volo.Abp.Modularity;

namespace MyBlogApp;

public abstract class MyBlogAppApplicationTestBase<TStartupModule> : MyBlogAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
