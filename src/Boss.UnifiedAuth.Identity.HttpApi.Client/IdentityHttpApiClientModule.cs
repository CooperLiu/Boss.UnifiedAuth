using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth.Identity
{
    [DependsOn(
        typeof(IdentityApplicationContractsModule),
        typeof(AbpHttpClientModule),
        typeof(AbpIdentityHttpApiClientModule)
        )]
    public class IdentityHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Identity";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(IdentityApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
