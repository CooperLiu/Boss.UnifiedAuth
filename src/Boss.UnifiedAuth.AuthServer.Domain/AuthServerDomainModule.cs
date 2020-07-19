using Volo.Abp.IdentityServer;
using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth.AuthServer
{
    [DependsOn(
        typeof(AuthServerDomainSharedModule),
        typeof(AbpIdentityServerDomainModule)
        )]
    public class AuthServerDomainModule : AbpModule
    {

    }
}
