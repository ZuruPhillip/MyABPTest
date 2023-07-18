namespace MyAbp.Demo.Permissions;

public static class DemoPermissions
{
    public const string GroupName = "Demo";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    /// <summary>
    /// 
    /// </summary>
    public class Todo
    {
        public const string Default = GroupName + ".Todo";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
}
