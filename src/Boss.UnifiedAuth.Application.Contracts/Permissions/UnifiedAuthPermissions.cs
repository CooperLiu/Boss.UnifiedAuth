using Volo.Abp.Reflection;

namespace Boss.UnifiedAuth.Permissions
{
    public class UnifiedAuthPermissions
    {
        public const string GroupName = "UnifiedAuth";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(UnifiedAuthPermissions));
        }
    }
}