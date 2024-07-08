using MyBlogApp.Samples;
using Xunit;

namespace MyBlogApp.EntityFrameworkCore.Domains;

[Collection(MyBlogAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MyBlogAppEntityFrameworkCoreTestModule>
{

}
