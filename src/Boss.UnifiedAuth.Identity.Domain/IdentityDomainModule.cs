using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth.Identity
{
    [DependsOn(
        typeof(IdentityDomainSharedModule)
        )]
    public class IdentityDomainModule : AbpModule
    {

    }
}
