using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace angular_dnx_webapi_sharepoint.Helpers
{
    public class RequestHelper {

        public async Task<string> GetResponse(string url) {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync(new Uri(url));
            }
        }

        /*
         * https://msdn.microsoft.com/en-us/library/office/jj164022.aspx
         */

        public async Task<string> GetResponse(string url, string accessToken) {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage() {
                    RequestUri = new Uri(url),
                    Method = HttpMethod.Get
                };

                request.Headers.Add("Authorization", "Bearer " + accessToken);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json;odata=verbose"));

                HttpResponseMessage responseMessage = await client.SendAsync(request);
                HttpContent content = responseMessage.Content;
                return await content.ReadAsStringAsync();
            }
        }
    }
}
