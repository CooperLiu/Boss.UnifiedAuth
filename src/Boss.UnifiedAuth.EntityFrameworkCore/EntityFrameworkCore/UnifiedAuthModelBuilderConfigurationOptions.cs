using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Boss.UnifiedAuth.EntityFrameworkCore
{
    public class UnifiedAuthModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public UnifiedAuthModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}