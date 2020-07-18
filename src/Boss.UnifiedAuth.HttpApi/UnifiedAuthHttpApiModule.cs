using Localization.Resources.AbpUi;
using Boss.UnifiedAuth.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Boss.UnifiedAuth
{
    [DependsOn(
        typeof(UnifiedAuthApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class UnifiedAuthHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(UnifiedAuthHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<UnifiedAuthResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
