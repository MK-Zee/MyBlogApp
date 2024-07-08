using Volo.Abp.Modularity;

namespace MyBlogApp;

[DependsOn(
    typeof(MyBlogAppApplicationModule),
    typeof(MyBlogAppDomainTestModule)
)]
public class MyBlogAppApplicationTestModule : AbpModule
{

}
