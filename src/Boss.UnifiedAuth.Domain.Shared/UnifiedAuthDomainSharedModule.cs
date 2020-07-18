using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Boss.UnifiedAuth.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace Boss.UnifiedAuth
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class UnifiedAuthDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<UnifiedAuthDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<UnifiedAuthResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/UnifiedAuth");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("UnifiedAuth", typeof(UnifiedAuthResource));
            });
        }
    }
}
