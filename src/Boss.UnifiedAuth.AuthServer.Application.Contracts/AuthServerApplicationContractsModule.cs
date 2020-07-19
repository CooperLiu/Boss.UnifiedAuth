using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Boss.UnifiedAuth.AuthServer
{
    [DependsOn(
        typeof(AuthServerDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class AuthServerApplicationContractsModule : AbpModule
    {

    }
}
