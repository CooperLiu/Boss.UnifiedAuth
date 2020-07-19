using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Boss.UnifiedAuth.AuthServer.MongoDB
{
    public class AuthServerMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public AuthServerMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}