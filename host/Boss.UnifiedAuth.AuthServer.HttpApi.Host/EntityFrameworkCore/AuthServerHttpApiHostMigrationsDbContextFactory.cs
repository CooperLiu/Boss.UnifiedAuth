using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Boss.UnifiedAuth.AuthServer.EntityFrameworkCore
{
    public class AuthServerHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AuthServerHttpApiHostMigrationsDbContext>
    {
        public AuthServerHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AuthServerHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("AuthServer"));

            return new AuthServerHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
