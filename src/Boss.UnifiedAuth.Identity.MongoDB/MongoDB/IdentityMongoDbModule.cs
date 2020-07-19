using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Identity.MongoDB;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Boss.UnifiedAuth.Identity.MongoDB
{
    [DependsOn(
        typeof(IdentityDomainModule),
        typeof(AbpMongoDbModule),
        typeof(AbpIdentityMongoDbModule)
        )]
    public class IdentityMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<IdentityMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
