namespace NAccessControl.Domain.Model;

public class Permission
{
    public int Id { get; set; }

    public string Key { get; set; }

    public string Name { get; set; }

    public Permission() { }

    public Permission(string key, string name)
    {
        Key = key;
        Name = name;
    }
}
