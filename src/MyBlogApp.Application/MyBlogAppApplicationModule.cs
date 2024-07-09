using Microsoft.Extensions.DependencyInjection;
using MyBlogApp.Data;
using MyBlogApp.EntityFrameworkCore.Repositories;
using MyBlogApp.Posts;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.Data;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace MyBlogApp;

[DependsOn(
    typeof(MyBlogAppDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(MyBlogAppApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class MyBlogAppApplicationModule : AbpModule
{

    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<AbpDataSeedOptions>(options =>
        {
            options.Contributors.Add<MyDataSeeder>();
        });
    }
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<MyBlogAppApplicationModule>();
        });

        // Register application services
        context.Services.AddTransient<IPostAppService, PostAppService>();

        // Register repositories
        context.Services.AddTransient<IPostRepository, PostRepository>();
    }
}
