using Microsoft.AspNetCore.Builder;
using MyBlogApp;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<MyBlogAppWebTestModule>();

public partial class Program
{
}
