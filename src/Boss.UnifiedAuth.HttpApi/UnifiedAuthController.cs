using Boss.UnifiedAuth.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Boss.UnifiedAuth
{
    public abstract class UnifiedAuthController : AbpController
    {
        protected UnifiedAuthController()
        {
            LocalizationResource = typeof(UnifiedAuthResource);
        }
    }
}
