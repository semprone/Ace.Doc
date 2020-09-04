using Ace.Doc.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Ace.Doc.Permissions
{
    public class DocPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DocPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(DocPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DocResource>(name);
        }
    }
}
