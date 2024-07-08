using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MyBlogApp.Pages;

public class Index_Tests : MyBlogAppWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
