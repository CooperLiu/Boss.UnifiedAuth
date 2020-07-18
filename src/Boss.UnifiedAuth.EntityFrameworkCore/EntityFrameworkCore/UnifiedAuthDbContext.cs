using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Boss.UnifiedAuth.EntityFrameworkCore
{
    [ConnectionStringName(UnifiedAuthDbProperties.ConnectionStringName)]
    public class UnifiedAuthDbContext : AbpDbContext<UnifiedAuthDbContext>, IUnifiedAuthDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public UnifiedAuthDbContext(DbContextOptions<UnifiedAuthDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureUnifiedAuth();
        }
    }
}