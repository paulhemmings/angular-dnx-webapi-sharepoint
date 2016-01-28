using Xunit;
using System.Collections.Generic;
using angular_dnx_webapi_sharepoint.Controllers;

/*
 * http://xunit.github.io/docs/getting-started-dnx.html
 */

namespace angular_dnx_webapi_sharepoint.test.Controllers
{
    public class ValuesControllerTest
    {
        [Fact]
        public void ShouldReturnCorrectValueWhenGettingById()
        {
            var controller = new ValuesController();
            Assert.Equal("value", controller.Get(1));
        }
    }
}
