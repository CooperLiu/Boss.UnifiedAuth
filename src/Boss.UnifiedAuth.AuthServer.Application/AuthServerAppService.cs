using Boss.UnifiedAuth.AuthServer.Localization;
using Volo.Abp.Application.Services;

namespace Boss.UnifiedAuth.AuthServer
{
    public abstract class AuthServerAppService : ApplicationService
    {
        protected AuthServerAppService()
        {
            LocalizationResource = typeof(AuthServerResource);
            ObjectMapperContext = typeof(AuthServerApplicationModule);
        }
    }
}
