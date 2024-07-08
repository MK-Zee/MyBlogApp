using Volo.Abp.Modularity;

namespace MyBlogApp;

[DependsOn(
    typeof(MyBlogAppDomainModule),
    typeof(MyBlogAppTestBaseModule)
)]
public class MyBlogAppDomainTestModule : AbpModule
{

}
