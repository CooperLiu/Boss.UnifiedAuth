using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Boss.UnifiedAuth.EntityFrameworkCore
{
    public class UnifiedAuthHttpApiHostMigrationsDbContext : AbpDbContext<UnifiedAuthHttpApiHostMigrationsDbContext>
    {
        public UnifiedAuthHttpApiHostMigrationsDbContext(DbContextOptions<UnifiedAuthHttpApiHostMigrationsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureUnifiedAuth();
        }
    }
}
