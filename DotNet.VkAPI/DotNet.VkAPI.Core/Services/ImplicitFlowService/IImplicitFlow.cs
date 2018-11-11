using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.VkAPI.Core.Services.ImplicitFlowService
{
    public interface IImplicitFlow
    {
        Uri BuildAuthUrl(int appId, int scope);
    }
}
