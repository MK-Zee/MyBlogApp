using System;
using System.Collections.Generic;
using System.Text;
using MyBlogApp.Localization;
using Volo.Abp.Application.Services;

namespace MyBlogApp;

/* Inherit your application services from this class.
 */
public abstract class MyBlogAppAppService : ApplicationService
{
    protected MyBlogAppAppService()
    {
        LocalizationResource = typeof(MyBlogAppResource);
    }
}
