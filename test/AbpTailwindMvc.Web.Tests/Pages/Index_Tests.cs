using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpTailwindMvc.Pages
{
    public class Index_Tests : AbpTailwindMvcWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
