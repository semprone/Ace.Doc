using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Ace.Doc.Pages
{
    public class Index_Tests : DocWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
