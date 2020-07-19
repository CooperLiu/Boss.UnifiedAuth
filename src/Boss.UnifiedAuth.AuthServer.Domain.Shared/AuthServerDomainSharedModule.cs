using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Boss.UnifiedAuth.AuthServer.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.IdentityServer;

namespace Boss.UnifiedAuth.AuthServer
{
    [DependsOn(
        typeof(AbpValidationModule),
        typeof(AbpIdentityServerDomainSharedModule)
    )]
    public class AuthServerDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AuthServerDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<AuthServerResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/AuthServer");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("AuthServer", typeof(AuthServerResource));
            });
        }
    }
}
