using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MyBlogApp.Web;

[Dependency(ReplaceServices = true)]
public class MyBlogAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MyBlogApp";
}
