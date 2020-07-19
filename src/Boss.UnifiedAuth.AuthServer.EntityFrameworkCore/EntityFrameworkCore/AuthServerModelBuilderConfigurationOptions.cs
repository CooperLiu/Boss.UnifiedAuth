using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Boss.UnifiedAuth.AuthServer.EntityFrameworkCore
{
    public class AuthServerModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public AuthServerModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}