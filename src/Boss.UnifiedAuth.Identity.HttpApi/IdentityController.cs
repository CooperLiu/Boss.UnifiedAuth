using Boss.UnifiedAuth.Identity.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Boss.UnifiedAuth.Identity
{
    public abstract class IdentityController : AbpController
    {
        protected IdentityController()
        {
            LocalizationResource = typeof(IdentityResource);
        }
    }
}
