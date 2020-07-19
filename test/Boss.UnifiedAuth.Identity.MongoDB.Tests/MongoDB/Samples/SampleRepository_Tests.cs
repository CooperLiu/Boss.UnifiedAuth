﻿using Boss.UnifiedAuth.Identity.Samples;
using Xunit;

namespace Boss.UnifiedAuth.Identity.MongoDB.Samples
{
    [Collection(MongoTestCollection.Name)]
    public class SampleRepository_Tests : SampleRepository_Tests<IdentityMongoDbTestModule>
    {
        /* Don't write custom repository tests here, instead write to
         * the base class.
         * One exception can be some specific tests related to MongoDB.
         */
    }
}
