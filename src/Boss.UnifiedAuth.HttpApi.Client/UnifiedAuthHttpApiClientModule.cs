using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth
{
    [DependsOn(
        typeof(UnifiedAuthApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class UnifiedAuthHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "UnifiedAuth";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(UnifiedAuthApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
