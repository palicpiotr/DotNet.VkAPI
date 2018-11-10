
namespace DotNet.VkAPI.Core.Services.OAuthService.Models
{
    public class OAuthApiResultModel
    {
        public string AccessToken { get; set; }
        public int ExpiresIn { get; set; }
        public int UserId { get; set; }
        public string State { get; set; }
    }
}
