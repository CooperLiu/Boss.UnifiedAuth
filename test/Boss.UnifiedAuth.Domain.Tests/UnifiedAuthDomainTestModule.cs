using Boss.UnifiedAuth.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(UnifiedAuthEntityFrameworkCoreTestModule)
        )]
    public class UnifiedAuthDomainTestModule : AbpModule
    {
        
    }
}
