using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.VkAPI.Core.Models
{
    public sealed class WebCallResultModel
    {
        public WebCallResultModel(string url, Cookies cookies)
        {
            RequestUrl = new Uri(uriString: url);
            Cookies = cookies;
            Response = default;
        }

        public Uri RequestUrl { get; set; }
        public Uri ResponseUrl { get; private set; }
        public string Response { get; private set; }
        public Cookies Cookies { get; set; }
        public void SaveCookies(CookieCollection cookieCollection) => Cookies.AddForm(ResponseUrl, cookieCollection);

        public async Task SaveResponseAsync(Uri url, Stream stream, Encoding encoding)
        {
            ResponseUrl = url;
            using (var reader = new StreamReader(stream, encoding))
            {
                Response = await reader.ReadToEndAsync();
            }
        }
    }
}
