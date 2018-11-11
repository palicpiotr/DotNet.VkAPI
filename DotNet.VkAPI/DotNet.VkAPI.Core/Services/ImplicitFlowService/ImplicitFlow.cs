using DotNet.VkAPI.Core.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.VkAPI.Core.Services.ImplicitFlowService
{
    public class ImplicitFlow : IImplicitFlow
    {
       
        private string _appId { get; set; }
        private string _scope { get; set; }

        public Uri BuildAuthUrl(int appId, int scope)
        {
            var builder = new StringBuilder(OpenAPIS.OAUTH_AUTHORIZE);
            builder.Append(true);
            return default;
        }
    }
}
