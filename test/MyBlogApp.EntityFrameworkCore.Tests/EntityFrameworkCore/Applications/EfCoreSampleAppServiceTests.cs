using MyBlogApp.Samples;
using Xunit;

namespace MyBlogApp.EntityFrameworkCore.Applications;

[Collection(MyBlogAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MyBlogAppEntityFrameworkCoreTestModule>
{

}
