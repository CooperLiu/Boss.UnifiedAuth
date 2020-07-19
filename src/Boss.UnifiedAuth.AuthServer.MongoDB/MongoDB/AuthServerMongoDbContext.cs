using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Boss.UnifiedAuth.AuthServer.MongoDB
{
    [ConnectionStringName(AuthServerDbProperties.ConnectionStringName)]
    public class AuthServerMongoDbContext : AbpMongoDbContext, IAuthServerMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureAuthServer();
        }
    }
}