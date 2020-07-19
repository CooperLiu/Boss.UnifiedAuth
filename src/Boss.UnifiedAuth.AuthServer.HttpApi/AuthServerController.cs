using Boss.UnifiedAuth.AuthServer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Boss.UnifiedAuth.AuthServer
{
    public abstract class AuthServerController : AbpController
    {
        protected AuthServerController()
        {
            LocalizationResource = typeof(AuthServerResource);
        }
    }
}
