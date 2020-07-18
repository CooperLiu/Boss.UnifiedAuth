using Boss.UnifiedAuth.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Boss.UnifiedAuth.Permissions
{
    public class UnifiedAuthPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(UnifiedAuthPermissions.GroupName, L("Permission:UnifiedAuth"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<UnifiedAuthResource>(name);
        }
    }
}