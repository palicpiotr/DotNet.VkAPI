using DotNet.VkAPI.Core.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.VkAPI.Core.Services.ImplicitFlowService
{
    public class ImplicitFlow : IImplicitFlow
    {

        public Uri BuildAuthUrl(int appId, int scope)
        {
            var builder = new StringBuilder(OpenAPIS.OAUTH_AUTHORIZE);
            builder.Append($"{UrlParamaters.CLIENT_ID}{appId}&");
            builder.Append($"{UrlParamaters.REDIRECT_URI}{OpenAPIS.OAUTH_BLANK}&");

            builder.Append($"{UrlParamaters.SCOPE}{scope}&");
            return default;
        }
    }
}
