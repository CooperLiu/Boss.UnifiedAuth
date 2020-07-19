using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth.Identity.MongoDB
{
    [DependsOn(
        typeof(IdentityTestBaseModule),
        typeof(IdentityMongoDbModule)
        )]
    public class IdentityMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var connectionString = MongoDbFixture.ConnectionString.EnsureEndsWith('/') +
                                   "Db_" +
                                    Guid.NewGuid().ToString("N");

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}