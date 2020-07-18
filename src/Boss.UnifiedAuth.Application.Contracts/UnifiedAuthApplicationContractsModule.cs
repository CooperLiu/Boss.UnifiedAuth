using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Boss.UnifiedAuth
{
    [DependsOn(
        typeof(UnifiedAuthDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class UnifiedAuthApplicationContractsModule : AbpModule
    {

    }
}
