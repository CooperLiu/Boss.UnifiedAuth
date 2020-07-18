using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Boss.UnifiedAuth
{
    [DependsOn(
        typeof(UnifiedAuthDomainModule),
        typeof(UnifiedAuthApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class UnifiedAuthApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<UnifiedAuthApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<UnifiedAuthApplicationModule>(validate: true);
            });
        }
    }
}
