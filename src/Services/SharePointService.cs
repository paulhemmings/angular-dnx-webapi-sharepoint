using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using angular_dnx_webapi_sharepoint.Helpers;

namespace angular_dnx_webapi_sharepoint.Services
{
    public class SharePointService {

        public RequestHelper requestHelper { get; set; }

        public Task<string> List(string siteUrl, string token) {
            return requestHelper.GetResponse(siteUrl + "/_api/web/lists", token);
        }


    }
}
