using Boss.UnifiedAuth.Identity.Localization;
using Volo.Abp.Application.Services;

namespace Boss.UnifiedAuth.Identity
{
    public abstract class IdentityAppService : ApplicationService
    {
        protected IdentityAppService()
        {
            LocalizationResource = typeof(IdentityResource);
            ObjectMapperContext = typeof(IdentityApplicationModule);
        }
    }
}
