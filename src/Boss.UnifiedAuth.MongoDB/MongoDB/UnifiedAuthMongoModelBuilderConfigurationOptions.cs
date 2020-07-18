using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Boss.UnifiedAuth.MongoDB
{
    public class UnifiedAuthMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public UnifiedAuthMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}