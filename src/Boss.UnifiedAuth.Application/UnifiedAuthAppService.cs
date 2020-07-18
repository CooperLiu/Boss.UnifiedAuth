using Boss.UnifiedAuth.Localization;
using Volo.Abp.Application.Services;

namespace Boss.UnifiedAuth
{
    public abstract class UnifiedAuthAppService : ApplicationService
    {
        protected UnifiedAuthAppService()
        {
            LocalizationResource = typeof(UnifiedAuthResource);
            ObjectMapperContext = typeof(UnifiedAuthApplicationModule);
        }
    }
}
