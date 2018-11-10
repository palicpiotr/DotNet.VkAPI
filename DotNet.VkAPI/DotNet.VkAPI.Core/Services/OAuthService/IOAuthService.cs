using DotNet.VkAPI.Core.Services.OAuthService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.VkAPI.Core.Services.OAuthService
{
    public interface IOAuthService
    {
        string Authorize(OAuthApiModel model);
    }
}
