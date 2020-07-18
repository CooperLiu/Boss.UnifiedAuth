using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Boss.UnifiedAuth.MongoDB
{
    [DependsOn(
        typeof(UnifiedAuthDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class UnifiedAuthMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<UnifiedAuthMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
