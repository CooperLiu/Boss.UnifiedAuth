using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth
{
    [DependsOn(
        typeof(UnifiedAuthApplicationModule),
        typeof(UnifiedAuthDomainTestModule)
        )]
    public class UnifiedAuthApplicationTestModule : AbpModule
    {

    }
}
