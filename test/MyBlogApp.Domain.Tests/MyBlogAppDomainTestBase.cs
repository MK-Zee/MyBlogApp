using Volo.Abp.Modularity;

namespace MyBlogApp;

/* Inherit from this class for your domain layer tests. */
public abstract class MyBlogAppDomainTestBase<TStartupModule> : MyBlogAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
