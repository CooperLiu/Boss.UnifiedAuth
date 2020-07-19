using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.IdentityServer.MongoDB;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Boss.UnifiedAuth.AuthServer.MongoDB
{
    [DependsOn(
        typeof(AuthServerDomainModule),
        typeof(AbpMongoDbModule),
        typeof(AbpIdentityServerMongoDbModule)        
        )]
    public class AuthServerMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<AuthServerMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
