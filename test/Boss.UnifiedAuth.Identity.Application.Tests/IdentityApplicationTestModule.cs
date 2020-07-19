using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth.Identity
{
    [DependsOn(
        typeof(IdentityApplicationModule),
        typeof(IdentityDomainTestModule)
        )]
    public class IdentityApplicationTestModule : AbpModule
    {

    }
}
