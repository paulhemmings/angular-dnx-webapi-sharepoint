using Xunit;
using Moq;
using angular_dnx_webapi_sharepoint.Services;
using angular_dnx_webapi_sharepoint.Helpers;

namespace angular_dnx_webapi_sharepoint.test.Services
{
    public class SharePointServiceTest {

        [Fact]
        public async void ShouldCallRequestHelperWithFullListUrl()
        {
            // given

            string siteUrl = "http://test.com";
            string token = "some-test-token";

            var requestHelper = new Mock<RequestHelper>();
            var sharePointService = new SharePointService {
               requestHelper = requestHelper
            };

            // when

            var response = await sharePointService.List(siteUrl, token);

            // then

            Assert.Equal(true, response.Length > 0);
        }

    }
}
