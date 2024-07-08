using MyBlogApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyBlogApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyBlogAppController : AbpControllerBase
{
    protected MyBlogAppController()
    {
        LocalizationResource = typeof(MyBlogAppResource);
    }
}
