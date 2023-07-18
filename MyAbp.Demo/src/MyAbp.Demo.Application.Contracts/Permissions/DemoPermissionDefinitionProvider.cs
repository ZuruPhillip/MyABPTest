using MyAbp.Demo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyAbp.Demo.Permissions;

public class DemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DemoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DemoPermissions.MyPermission1, L("Permission:MyPermission1"));

        var todoPermission = myGroup.AddPermission(DemoPermissions.Todo.Default, L("Permission:Todo"));
        todoPermission.AddChild(DemoPermissions.Todo.Create, L("Permission:Create"));
        todoPermission.AddChild(DemoPermissions.Todo.Update, L("Permission:Update"));
        todoPermission.AddChild(DemoPermissions.Todo.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DemoResource>(name);
    }
}
