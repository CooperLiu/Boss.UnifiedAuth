using Boss.UnifiedAuth.AuthServer.Samples;
using Xunit;

namespace Boss.UnifiedAuth.AuthServer.MongoDB.Samples
{
    [Collection(MongoTestCollection.Name)]
    public class SampleRepository_Tests : SampleRepository_Tests<AuthServerMongoDbTestModule>
    {
        /* Don't write custom repository tests here, instead write to
         * the base class.
         * One exception can be some specific tests related to MongoDB.
         */
    }
}
