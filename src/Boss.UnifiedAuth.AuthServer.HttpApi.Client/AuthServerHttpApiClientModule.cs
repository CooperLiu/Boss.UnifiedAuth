using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth.AuthServer
{
    [DependsOn(
        typeof(AuthServerApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class AuthServerHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "AuthServer";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(AuthServerApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
