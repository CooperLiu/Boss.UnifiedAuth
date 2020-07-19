using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Boss.UnifiedAuth.AuthServer.EntityFrameworkCore
{
    public class AuthServerHttpApiHostMigrationsDbContext : AbpDbContext<AuthServerHttpApiHostMigrationsDbContext>
    {
        public AuthServerHttpApiHostMigrationsDbContext(DbContextOptions<AuthServerHttpApiHostMigrationsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureAuthServer();
        }
    }
}
