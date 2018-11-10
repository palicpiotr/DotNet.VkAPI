
using System;

namespace DotNet.VkAPI.Core.Services.OAuthService.Models
{
    public class OAuthApiModel
    {
        public int AppId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string AccessToken { get; set; }
        public Func<string> TwoFactorAuthorization { get; set; }
    }
}
