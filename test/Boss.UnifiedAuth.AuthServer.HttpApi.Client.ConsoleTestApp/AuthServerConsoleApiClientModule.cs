using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth.AuthServer
{
    [DependsOn(
        typeof(AuthServerHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AuthServerConsoleApiClientModule : AbpModule
    {
        
    }
}
