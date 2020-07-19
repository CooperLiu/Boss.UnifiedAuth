using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth.Identity
{
    [DependsOn(
        typeof(IdentityDomainSharedModule),
        typeof(AbpIdentityDomainModule)
        )]
    public class IdentityDomainModule : AbpModule
    {

    }
}
