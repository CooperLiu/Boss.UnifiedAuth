using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Boss.UnifiedAuth.EntityFrameworkCore
{
    [DependsOn(
        typeof(UnifiedAuthDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class UnifiedAuthEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<UnifiedAuthDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}