using AbpTailwindMvc.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpTailwindMvc.Permissions
{
    public class AbpTailwindMvcPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpTailwindMvcPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpTailwindMvcPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpTailwindMvcResource>(name);
        }
    }
}
