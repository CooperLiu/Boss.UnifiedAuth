using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Boss.UnifiedAuth.EntityFrameworkCore
{
    public class UnifiedAuthHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<UnifiedAuthHttpApiHostMigrationsDbContext>
    {
        public UnifiedAuthHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<UnifiedAuthHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("UnifiedAuth"));

            return new UnifiedAuthHttpApiHostMigrationsDbContext(builder.Options);
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
