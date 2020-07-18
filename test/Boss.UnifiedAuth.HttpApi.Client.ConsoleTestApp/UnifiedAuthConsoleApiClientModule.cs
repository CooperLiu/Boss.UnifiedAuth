using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth
{
    [DependsOn(
        typeof(UnifiedAuthHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class UnifiedAuthConsoleApiClientModule : AbpModule
    {
        
    }
}
