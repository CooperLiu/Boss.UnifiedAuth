﻿using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace Boss.UnifiedAuth.Identity
{
    public class IdentityDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;

        public IdentityDataSeedContributor(
            IGuidGenerator guidGenerator)
        {
            _guidGenerator = guidGenerator;
        }
        
        public Task SeedAsync(DataSeedContext context)
        {
            /* Instead of returning the Task.CompletedTask, you can insert your test data
             * at this point!
             */

            return Task.CompletedTask;
        }
    }
}