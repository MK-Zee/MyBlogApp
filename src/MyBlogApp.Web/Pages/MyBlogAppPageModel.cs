using MyBlogApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MyBlogApp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MyBlogAppPageModel : AbpPageModel
{
    protected MyBlogAppPageModel()
    {
        LocalizationResourceType = typeof(MyBlogAppResource);
    }
}
