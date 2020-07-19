using Boss.UnifiedAuth.AuthServer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth.AuthServer
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(AuthServerEntityFrameworkCoreTestModule)
        )]
    public class AuthServerDomainTestModule : AbpModule
    {
        
    }
}
