﻿using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Volo.Abp.Identity;

namespace Boss.UnifiedAuth.Identity
{
    [DependsOn(
        typeof(IdentityDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule),
        typeof(AbpIdentityApplicationContractsModule)
        )]
    public class IdentityApplicationContractsModule : AbpModule
    {

    }
}
