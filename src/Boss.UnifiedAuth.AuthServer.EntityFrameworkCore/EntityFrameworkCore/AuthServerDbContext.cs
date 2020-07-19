using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Boss.UnifiedAuth.AuthServer.EntityFrameworkCore
{
    [ConnectionStringName(AuthServerDbProperties.ConnectionStringName)]
    public class AuthServerDbContext : AbpDbContext<AuthServerDbContext>, IAuthServerDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public AuthServerDbContext(DbContextOptions<AuthServerDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureAuthServer();
        }
    }
}