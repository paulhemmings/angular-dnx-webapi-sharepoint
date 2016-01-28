using Xunit;
using angular_dnx_webapi_sharepoint.Helpers;

namespace angular_dnx_webapi_sharepoint.test.Helpers
{
    public class RequestHelperTest {

        [Fact]
        public async void ShouldReturnAWebResponse()
        {
            var requestHelper = new RequestHelper();
            var response = await requestHelper.GetResponse("http://www.google.com");
            Assert.Equal(true, response.Length > 0);
        }

    }
}
