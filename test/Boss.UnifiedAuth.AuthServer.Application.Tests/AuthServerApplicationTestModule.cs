using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth.AuthServer
{
    [DependsOn(
        typeof(AuthServerApplicationModule),
        typeof(AuthServerDomainTestModule)
        )]
    public class AuthServerApplicationTestModule : AbpModule
    {

    }
}
