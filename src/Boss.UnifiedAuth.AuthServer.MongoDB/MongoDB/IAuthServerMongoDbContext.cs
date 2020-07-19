using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Boss.UnifiedAuth.AuthServer.MongoDB
{
    [ConnectionStringName(AuthServerDbProperties.ConnectionStringName)]
    public interface IAuthServerMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
