using MyBlogApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyBlogApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MyBlogAppEntityFrameworkCoreModule),
    typeof(MyBlogAppApplicationContractsModule)
    )]
public class MyBlogAppDbMigratorModule : AbpModule
{
}
