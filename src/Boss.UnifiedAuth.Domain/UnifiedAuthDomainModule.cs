using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth
{
    [DependsOn(
        typeof(UnifiedAuthDomainSharedModule)
        )]
    public class UnifiedAuthDomainModule : AbpModule
    {

    }
}
