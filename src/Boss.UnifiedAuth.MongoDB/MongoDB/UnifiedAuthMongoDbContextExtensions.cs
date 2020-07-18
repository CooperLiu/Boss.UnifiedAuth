using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Boss.UnifiedAuth.MongoDB
{
    public static class UnifiedAuthMongoDbContextExtensions
    {
        public static void ConfigureUnifiedAuth(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new UnifiedAuthMongoModelBuilderConfigurationOptions(
                UnifiedAuthDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}