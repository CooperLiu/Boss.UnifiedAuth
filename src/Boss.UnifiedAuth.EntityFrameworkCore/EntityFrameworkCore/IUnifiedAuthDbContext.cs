using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Boss.UnifiedAuth.EntityFrameworkCore
{
    [ConnectionStringName(UnifiedAuthDbProperties.ConnectionStringName)]
    public interface IUnifiedAuthDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}