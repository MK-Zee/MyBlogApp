using Xunit;

namespace MyBlogApp.EntityFrameworkCore;

[CollectionDefinition(MyBlogAppTestConsts.CollectionDefinitionName)]
public class MyBlogAppEntityFrameworkCoreCollection : ICollectionFixture<MyBlogAppEntityFrameworkCoreFixture>
{

}
