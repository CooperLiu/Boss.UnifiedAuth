using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Boss.UnifiedAuth.MongoDB
{
    [ConnectionStringName(UnifiedAuthDbProperties.ConnectionStringName)]
    public class UnifiedAuthMongoDbContext : AbpMongoDbContext, IUnifiedAuthMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureUnifiedAuth();
        }
    }
}