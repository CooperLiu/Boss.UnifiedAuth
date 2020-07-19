using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Boss.UnifiedAuth.AuthServer.MongoDB
{
    public static class AuthServerMongoDbContextExtensions
    {
        public static void ConfigureAuthServer(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new AuthServerMongoModelBuilderConfigurationOptions(
                AuthServerDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}